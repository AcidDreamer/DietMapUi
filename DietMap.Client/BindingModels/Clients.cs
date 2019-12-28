using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace DietMap.Client.BindingModels
{
    public class ClientsList{
        [JsonProperty("clients")]
        public List<Client> Clients { get; set; }
    }
    public class Client
    {
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("lastVisit")]
        public DateTime? LastVisit { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("fullname")]
        public string FullName {get;set;}
    }

}