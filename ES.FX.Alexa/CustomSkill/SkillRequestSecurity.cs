using System;
using System.Collections.Concurrent;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ES.FX.Alexa.CustomSkill
{
    public static class SkillRequestSecurity
    {
        private static ConcurrentDictionary<string, byte[]> CertificateDictionary { get; } =
            new ConcurrentDictionary<string, byte[]>();

        public static bool UseInMemoryCache { get; set; }

        public static async Task<bool> ValidateRequest(string certificateUrl, string signature, string body)
        {
            try
            {
                if (!Uri.TryCreate(certificateUrl, UriKind.RelativeOrAbsolute, out var certificateUri))
                    return false;


                if (!certificateUri.Scheme.Equals("https", StringComparison.OrdinalIgnoreCase) &&
                    !certificateUri.Host.Equals("s3.amazonaws.com", StringComparison.OrdinalIgnoreCase) &&
                    !certificateUri.LocalPath.StartsWith("/echo.api", StringComparison.OrdinalIgnoreCase) &&
                    !certificateUri.IsDefaultPort)
                    return false;


                byte[] certificateData = null;
                if (UseInMemoryCache) CertificateDictionary.TryGetValue(certificateUrl, out certificateData);
                certificateData = certificateData ?? await new WebClient().DownloadDataTaskAsync(certificateUrl);


                var certificate = new X509Certificate2(certificateData);
                var certificateSimpleName = certificate.GetNameInfo(X509NameType.SimpleName, false);
                if (certificate.NotAfter < DateTime.Now || certificate.NotBefore > DateTime.Now ||
                    !certificateSimpleName.Equals("echo-api.amazon.com", StringComparison.OrdinalIgnoreCase))
                    return false;


                if (!new X509Chain {ChainPolicy = {RevocationMode = X509RevocationMode.NoCheck}}.Build(certificate))
                    return false;


                var valid = certificate.GetRSAPublicKey().VerifyData(
                    Encoding.UTF8.GetBytes(body),
                    Convert.FromBase64String(signature),
                    HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                if (valid && UseInMemoryCache) CertificateDictionary.TryAdd(certificateUrl, certificateData);
                return valid;
            }
            catch
            {
                return false;
            }
        }
    }
}