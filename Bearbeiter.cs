using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ticketsystem
{
    class Bearbeiter
    {
        [JsonProperty]
        private string name;
        [JsonProperty]
        private string kuerzel;
        [JsonProperty]
        private string bearbeiter_email;

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

        public void SetBearbeiterEmail(string email)
        {
            this.bearbeiter_email = email;
        }
        public string GetBearbeiterEmail()
        {
            return this.bearbeiter_email;
        }

    }
}
