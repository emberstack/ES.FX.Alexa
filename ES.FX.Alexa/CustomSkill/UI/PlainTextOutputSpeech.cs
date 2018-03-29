namespace ES.FX.Alexa.CustomSkill.UI
{
    public class PlainTextOutputSpeech : OutputSpeech
    {
        public string Text { get; set; }

        public override string Type => "PlainText";
    }
}