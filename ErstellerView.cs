using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketsystem
{
    public partial class ErstellerView : Form
    {
        List<Ersteller> Erstellerliste = new List<Ersteller>();

        public ErstellerView()
        {
            InitializeComponent();
            DataGridView Erstellerinfos = new DataGridView();
            Erstellerinfos = dataGridView_ersteller_uebersicht;
            Erstellerinfos.ColumnCount = 3;

            Erstellerinfos.Columns[0].Name = "Name";
            Erstellerinfos.Columns[1].Name = "Kürzel";
            Erstellerinfos.Columns[2].Name = "Email";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewErstellerView NEV = new NewErstellerView();
            NEV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewErstellerView NEV = new NewErstellerView();
            NEV.ShowDialog();
        }

        private void ErstellerView_Load(object sender, EventArgs e)
        {
            List<Ersteller> ersteller = new List<Ersteller>();
            string[] zeile = File.ReadAllLines(Repository.erstellerFilePath);
            foreach (string line in zeile)
            {
                try
                {
                    Ersteller objBearbeiter = JsonConvert.DeserializeObject<Ersteller>(line);
                    ersteller.Add(objBearbeiter);
                }
                catch (Exception) { }
            }

            // Tickets in neue Liste schreiben
            for (int i = 0; i < ersteller.Count; i++)
            {
                Erstellerliste.Add(ersteller[i]);
            }

            // Datagriedview mit Erstellerdaten Füllen
            for (int i = 0; i < Erstellerliste.Count; i++)
            {
                string[] row = new string[] { Erstellerliste[i].GetName(), Erstellerliste[i].GetKuerzel(), Erstellerliste[i].GetEmail()};
                dataGridView_ersteller_uebersicht.Rows.Add(row);
            }
        }
    }
}
