using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ticketsystem
{
    public static class Repository
    {
        public static string ticketsFilePath = @"Tickets.JSON";
        public static string erstellerFilePath = @"Ersteller.JSON";
        public static string bearbeiterFilePath = @"Bearbeiter.JSON";
    }
}
