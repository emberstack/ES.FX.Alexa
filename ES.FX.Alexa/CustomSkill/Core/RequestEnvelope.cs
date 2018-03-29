namespace ES.FX.Alexa.CustomSkill.Core
{
    public class RequestEnvelope
    {
        public string Version { get; internal set; }

        public Session Session { get; internal set; }

        public Context Context { get; internal set; }
    }
}