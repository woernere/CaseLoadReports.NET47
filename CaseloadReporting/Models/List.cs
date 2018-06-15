using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace CaseloadReporting.Models
{
    public class List
    {
        [JsonProperty(PropertyName = "Count")]
        public int Count { get; set; }
        [JsonProperty(PropertyName = "GroupName")]
        public string GroupName { get; set; }
        [JsonProperty(PropertyName = "ActionName")]
        public string ActionName { get; set; }
    }
}
