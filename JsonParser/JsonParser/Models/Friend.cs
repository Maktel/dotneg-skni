using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JsonParser.Models
{
    [DataContract]
    internal class Friend
    {
        [JsonProperty("id")] [DataMember(Name = "id")]
        public int Id;

        [JsonProperty("name")] [DataMember(Name = "name")]
        public string Name;
    }
}