using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ES.FX.Alexa.CustomSkill.Dialog;

namespace ES.FX.Alexa.CustomSkill
{
    public static class SkillResponseExtensions
    {
        internal static SsmlOutputSpeech ToSsmlSpeech(this string speech)
        {
            var ssml = string.IsNullOrWhiteSpace(speech) ? string.Empty : speech;
            if (ssml.StartsWith("<speak>") && ssml.EndsWith("</speak>"))
                ssml = ssml.Substring(7, ssml.Length - 8).Trim();
            return new SsmlOutputSpeech
            {
                Ssml = $"<speak>{ssml}</speak>"
            };
        }

        public static ResponseBody Speak(this ResponseBody response, StringBuilder speechBuilder)
        {
            response.Speak(speechBuilder.ToString());
            return response;
        }
        public static SkillResponse Speak(this SkillResponse skillResponse, StringBuilder speechBuilder)
        {
            skillResponse.Response.Speak(speechBuilder);
            return skillResponse;
        }


        public static ResponseBody Speak(this ResponseBody response, string speech)
        {
            return response.Speak(speech.ToSsmlSpeech());
        }
        public static SkillResponse Speak(this SkillResponse skillResponse, string speech)
        {
            skillResponse.Response.Speak(speech);
            return skillResponse;
        }


        public static ResponseBody Speak(this ResponseBody response, OutputSpeech speech)
        {
            response.OutputSpeech = speech;
            return response;
        }
        public static SkillResponse Speak(this SkillResponse skillResponse, OutputSpeech speech)
        {
            skillResponse.Response.Speak(speech);
            return skillResponse;
        }


        public static ResponseBody Reprompt(this ResponseBody response, string speech)
        {
            return response.Reprompt(speech.ToSsmlSpeech());
        }
        public static SkillResponse Reprompt(this SkillResponse skillResponse, string speech)
        {
            skillResponse.Response.Reprompt(speech);
            return skillResponse;
        }


        public static ResponseBody Reprompt(this ResponseBody response, OutputSpeech speech)
        {
            response.Reprompt = new Reprompt
            {
                OutputSpeech = speech
            };
            response.ShouldEndSession = false;
            return response;
        }
        public static SkillResponse Reprompt(this SkillResponse skillResponse, OutputSpeech speech)
        {
            skillResponse.Response.Reprompt(speech);
            return skillResponse;
        }


        public static ResponseBody AddDirective(this ResponseBody response, Directive directive)
        {
            response.Directives.Add(directive);
            return response;
        }
        public static SkillResponse AddDirective(this SkillResponse skillResponse, Directive directive)
        {
            skillResponse.Response.AddDirective(directive);
            return skillResponse;
        }


        public static ResponseBody ShouldEndSession(this ResponseBody response, bool endSession)
        {
            response.ShouldEndSession = endSession;
            return response;
        }
        public static SkillResponse ShouldEndSession(this SkillResponse skillResponse, bool endSession)
        {
            skillResponse.Response.ShouldEndSession(endSession);
            return skillResponse;
        }


        public static ResponseBody AddDialogDelegate(this ResponseBody response, Intent updatedIntent = null)
        {
            return response.AddDirective(new DialogDelegateDirective
            {
                UpdatedIntent = updatedIntent
            }).ShouldEndSession(false);
        }
        public static SkillResponse AddDialogDelegate(this SkillResponse skillResponse, Intent updatedIntent = null)
        {
            skillResponse.Response.AddDialogDelegate(updatedIntent);
            return skillResponse;
        }


        public static ResponseBody AddDialogElicitSlot(this ResponseBody response, string slotName,
            Intent updatedIntent = null)
        {
            return response.AddDirective(new DialogElicitSlotDirective
            {
                SlotName = slotName,
                UpdatedIntent = updatedIntent
            })
                .ShouldEndSession(false);
        }
        public static SkillResponse AddDialogElicitSlot(this SkillResponse skillResponse, string slotName,
            Intent updatedIntent = null)
        {
            skillResponse.Response.AddDialogElicitSlot(slotName, updatedIntent);
            return skillResponse;
        }


        public static ResponseBody AddDialogConfirmSlot(this ResponseBody response, string slotName,
            Intent updatedIntent = null)
        {
            return response.AddDirective(new DialogConfirmSlotDirective
            {
                SlotName = slotName,
                UpdatedIntent = updatedIntent
            })
                .ShouldEndSession(false);
        }
        public static SkillResponse AddDialogConfirmSlot(this SkillResponse skillResponse, string slotName,
            Intent updatedIntent = null)
        {
            skillResponse.Response.AddDialogConfirmSlot(slotName, updatedIntent);
            return skillResponse;
        }


        public static ResponseBody AddDialogConfirmIntent(this ResponseBody response, Intent updatedIntent = null)
        {
            return response.AddDirective(new DialogConfirmIntentDirective
            {
                UpdatedIntent = updatedIntent
            }).ShouldEndSession(false);
        }
        public static SkillResponse AddDialogConfirmIntent(this SkillResponse skillResponse, Intent updatedIntent = null)
        {
            skillResponse.Response.AddDialogConfirmIntent(updatedIntent);
            return skillResponse;
        }


        public static ResponseBody AddHintDirective(this ResponseBody response, string hint)
        {
            return response.AddDirective(new HintDirective
            {
                Hint = new PlainTextHint
                {
                    Text = hint
                }
            });
        }
        public static SkillResponse AddHintDirective(this SkillResponse skillResponse, string hint)
        {
            skillResponse.Response.AddHintDirective(hint);
            return skillResponse;
        }


        public static ResponseBody WithCard(this ResponseBody response, Card card)
        {
            response.Card = card;
            return response;
        }
        public static SkillResponse WithCard(this SkillResponse skillResponse, Card card)
        {
            skillResponse.Response.WithCard(card);
            return skillResponse;
        }


        public static ResponseBody WithSimpleCard(this ResponseBody response, string title, string content)
        {
            return response.WithCard(new SimpleCard
            {
                Title = title,
                Content = content
            });
        }
        public static SkillResponse WithSimpleCard(this SkillResponse skillResponse, string title, string content)
        {
            skillResponse.Response.WithSimpleCard(title, content);
            return skillResponse;
        }

        public static ResponseBody WithStandardCard(this ResponseBody response, string title, string content, string smallImageUrl = null, string largeImageUrl = null)
        {
            return response.WithCard(new StandardCard
            {
                Title = title,
                Content = content,
                Image = new CardImage
                {
                    SmallImageUrl = smallImageUrl,
                    LargeImageUrl = largeImageUrl
                }
            });
        }
        public static SkillResponse WithStandardCard(this SkillResponse skillResponse, string title, string content, string smallImageUrl = null, string largeImageUrl = null)
        {
            skillResponse.Response.WithSimpleCard(title, content);
            return skillResponse;
        }


        public static ResponseBody WithLinkAccountCard(this ResponseBody response)
        {
            return response.WithCard(new LinkAccountCard());
        }
        public static SkillResponse WithLinkAccountCard(this SkillResponse skillResponse)
        {
            skillResponse.Response.WithLinkAccountCard();
            return skillResponse;
        }


        public static ResponseBody WithAskForPermissionsConsentCard(this ResponseBody response, IEnumerable<string> permissions)
        {
            return response.WithCard(new AskForPermissionsConsentCard
            {
                Permissions = permissions?.ToList()
            });
        }
        public static ResponseBody WithAskForPermissionsConsentCard(this ResponseBody response, params string[] permissions)
        {
            return response.WithAskForPermissionsConsentCard(permissions as IEnumerable<string>);
        }
        public static SkillResponse WithAskForPermissionsConsentCard(this SkillResponse skillResponse, IEnumerable<string> permissions)
        {
            skillResponse.Response.WithAskForPermissionsConsentCard(permissions);
            return skillResponse;
        }


        public static SkillResponse WithAskForPermissionsConsentCard(this SkillResponse skillResponse, params string[] permissions)
        {
            skillResponse.Response.WithAskForPermissionsConsentCard(permissions);
            return skillResponse;
        }
    }
}