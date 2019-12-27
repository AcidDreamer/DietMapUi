using System;
using System.Collections.Generic;

namespace DietMap.Client.Classes
{
    public class ClientsList{
        public List<Client> Clients { get; set; }
    }
    public class Client
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastVisit { get; set; }
        public string Id { get; set; }
        public string FullName {get;set;}
    }

}