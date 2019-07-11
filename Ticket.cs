using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ticketsystem
{
    public class Ticket
    {
        [JsonProperty]
        public string thema;
        [JsonProperty]
        public string beschreibung;
        [JsonProperty]
        public DateTime datum;
        [JsonProperty]
        public string ersteller;
        [JsonProperty]
        public string prioritaet;
        [JsonProperty]
        public string status;
        [JsonProperty]
        public Guid ID;

        public void SetThema(string thema)
        {
            this.thema = thema;
        }

        public string GetThema()
        {
            return thema;
        }

        public void SetBeschreibung(string beschreibung)
        {
            this.beschreibung = beschreibung;
        }

        public string GetBeschreibung()
        {
            return beschreibung;
        }

        public void SetDatum(DateTime datum)
        {
            this.datum = datum;
        }

        public DateTime GetDatum()
        {
            return datum;
        }

        public void SetErsteller(string ersteller)
        {
            this.ersteller = ersteller;
        }
        public string GetErsteller()
        {
            return this.ersteller;
        }
        public void SetPrioritaet(string prioritaet)
        {
            this.prioritaet = prioritaet;
        }

        public string GetPrioritaet()
        {
            return this.prioritaet;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }
        public string GetStatus()
        {
            return this.status;
        }
        public void SetID()
        {
            this.ID = Guid.NewGuid();

        }
        public Guid GetID()
        {
            return this.ID;
        }

    }
}
