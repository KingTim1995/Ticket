using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ticketsystem
{
    class Ersteller
    {
        [JsonProperty]
        private string name;
        [JsonProperty]
        private string kuerzel;
        [JsonProperty]
        private string email;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetKuerzel(string kuerzel)
        {
            this.kuerzel = kuerzel;
        }
        public string GetKuerzel()
        {
            return this.kuerzel;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return this.email;
        }
    }
}
