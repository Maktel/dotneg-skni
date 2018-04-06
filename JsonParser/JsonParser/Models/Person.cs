using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JsonParser.Models
{
    [DataContract] // necessary for System.Runtime.Serialization
    internal class Person
    {
        // JsonProperties are for Newtonsoft, DataMembers for System.Runtime.Serialization
        [JsonProperty("_id")] [DataMember(Name = "_id")] public string Id;
        [JsonProperty("index")] [DataMember(Name = "index")] public int Index;
        [JsonProperty("guid")] [DataMember(Name = "guid")] public Guid Guid;
        [JsonProperty("isActive")] [DataMember(Name = "isActive")] public bool IsActive;
        [JsonProperty("balance")] [DataMember(Name = "balance")] public string Balance;
        [JsonProperty("picture")] [DataMember(Name = "picture")] public string Picture;
        [JsonProperty("age")] [DataMember(Name = "age")] public int Age;
        [JsonProperty("eyeColor")] [DataMember(Name = "eyeColor")] public string EyeColor;
        [JsonProperty("name")] [DataMember(Name = "name")] public string Name;
        [JsonProperty("gender")] [DataMember(Name = "gender")] public string Gender;
        [JsonProperty("company")] [DataMember(Name = "company")] public string Company;
        [JsonProperty("email")] [DataMember(Name = "email")] public string Email;
        [JsonProperty("phone")] [DataMember(Name = "phone")] public string Phone;
        [JsonProperty("address")] [DataMember(Name = "address")] public string Address;
        [JsonProperty("about")] [DataMember(Name = "about")] public string About;
        [JsonProperty("registered")] [DataMember(Name = "registered")] public string Registered;
        [JsonProperty("latitude")] [DataMember(Name = "latitude")] public string Latitude;
        [JsonProperty("longitude")] [DataMember(Name = "longitude")] public string Longitude;
        [JsonProperty("tags")] [DataMember(Name = "tags")] public List<string> Tags;
        [JsonProperty("friends")] [DataMember(Name = "friends")] public List<Friend> Friends;
        [JsonProperty("greeting")] [DataMember(Name = "greeting")]  public string Greeting;
        [JsonProperty("favoriteFruit")] [DataMember(Name = "favoriteFruit")] public string FavoriteFruit;
    }
}