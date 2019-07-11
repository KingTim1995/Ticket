using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Ticketsystem
{
    public partial class BearbeiterView : Form
    {

        List<Bearbeiter> Bearbeiterliste = new List<Bearbeiter>();
        public BearbeiterView()
        {
            InitializeComponent();
            DataGridView Bearbeiterinfos = new DataGridView();
            Bearbeiterinfos = dataGridView_bearbeiter_uebersicht;
            Bearbeiterinfos.ColumnCount = 3;

            Bearbeiterinfos.Columns[0].Name = "Name";
            Bearbeiterinfos.Columns[1].Name = "Kürzel";
            Bearbeiterinfos.Columns[2].Name = "Email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewBearbeiterView NBV = new NewBearbeiterView();
            NBV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewBearbeiterView NBV = new NewBearbeiterView();
            NBV.ShowDialog();
        }

        private void BearbeiterView_Load(object sender, EventArgs e)
        {
            List<Bearbeiter> ersteller = new List<Bearbeiter>();
            string[] zeile = File.ReadAllLines(Repository.erstellerFilePath);
            foreach (string line in zeile)
            {
                try
                {
                    Bearbeiter objBearbeiter = JsonConvert.DeserializeObject<Bearbeiter>(line);
                    ersteller.Add(objBearbeiter);
                }
                catch (Exception) { }
            }

            // Tickets in neue Liste schreiben
            for (int i = 0; i < ersteller.Count; i++)
            {
                Bearbeiterliste.Add(ersteller[i]);
            }

            // Datagriedview mit Erstellerdaten Füllen
            for (int i = 0; i < Bearbeiterliste.Count; i++)
            {
                string[] row = new string[] { Bearbeiterliste[i].GetName(), Bearbeiterliste[i].GetKuerzel(), Bearbeiterliste[i].GetBearbeiterEmail() };
                dataGridView_bearbeiter_uebersicht.Rows.Add(row);
            }
        }
    }
}
