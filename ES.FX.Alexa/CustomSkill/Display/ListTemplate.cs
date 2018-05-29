using System.Collections.Generic;
using Newtonsoft.Json;

namespace ES.FX.Alexa.CustomSkill.Display
{
    public abstract class ListTemplate : DisplayTemplate
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("listItems", Required = Required.Always)]
        public List<ListItem> Items { get; set; } = new List<ListItem>();
    }
}