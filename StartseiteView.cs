using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Ticketsystem
{
    public partial class StartseiteView : Form
    {
        private List<Ticket> Tickets_ausgelesen = new List<Ticket>();
        public StartseiteView()
        {
            InitializeComponent();

            // DataGriedView Gerüst erstellen
            DataGridView Ticketinfos = new DataGridView();
            Ticketinfos = dataGridView_ticket_overview;
            Ticketinfos.ColumnCount = 6;
            Ticketinfos.Columns[0].Name = "Datum";
            Ticketinfos.Columns[1].Name = "Thema";
            Ticketinfos.Columns[2].Name = "Ersteller";
            Ticketinfos.Columns[3].Name = "Priorität";
            Ticketinfos.Columns[4].Name = "Status";
            Ticketinfos.Columns[5].Name = "Beschreibung";




            if (File.Exists(Repository.ticketsFilePath) == false)
            {
                File.Create(Repository.ticketsFilePath).Close();
            }
            if (File.Exists(Repository.erstellerFilePath) == false)
            {
                File.Create(Repository.erstellerFilePath).Close();
            }
            if (File.Exists(Repository.bearbeiterFilePath) == false)
            {
                File.Create(Repository.bearbeiterFilePath).Close();
            }

            comboBox_filter.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_filter.Items.Add("Alle");
            comboBox_filter.Items.Add("Neu");
            comboBox_filter.Items.Add("Offen");
            comboBox_filter.Items.Add("In Bearbeitung");
            comboBox_filter.Items.Add("Geschlossen");

            
        }

        private void Button_neuesTicket_Click(object sender, EventArgs e)
        {
            TicketView TicketView = new TicketView();
            TicketView.ShowDialog();
        }

        private void Button_ticketLoeschen_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = 
        }

        private void Button_Bearbeiter_Click(object sender, EventArgs e)
        {
            BearbeiterView BearbeiterView = new BearbeiterView();
            BearbeiterView.ShowDialog();
        }

        private void Button_Ersteller_Click(object sender, EventArgs e)
        {
            ErstellerView ErstellerView = new ErstellerView();
            ErstellerView.ShowDialog();
        }

        //Tickets wieder einlesen beim Laden der Form
        public void StartseiteView_Load(object sender, EventArgs e)
        {
            List<Ticket> users = new List<Ticket>();           
            string[] zeile = File.ReadAllLines(Repository.ticketsFilePath);
            foreach (string line in zeile)
            {
                try
                {
                    Ticket objTicket = JsonConvert.DeserializeObject<Ticket>(line);
                    users.Add(objTicket);
                }
                catch (Exception) { }
            }

            // Tickets in neue Liste schreiben
            for (int i = 0; i < users.Count; i++)
            {
                Tickets_ausgelesen.Add(users[i]);
            }

            // Datagriedview mit Ticketdaten Füllen
            for (int i = 0; i < Tickets_ausgelesen.Count; i++)
            {
                string[] row = new string[] { Convert.ToString(Tickets_ausgelesen[i].GetDatum()), Tickets_ausgelesen[i].GetThema(), Tickets_ausgelesen[i].GetErsteller(), Tickets_ausgelesen[i].GetPrioritaet(), Tickets_ausgelesen[i].GetStatus(), Tickets_ausgelesen[i].GetBeschreibung()};
                dataGridView_ticket_overview.Rows.Add(row);
            }
        }

        // Filtern nach Status
        private void comboBox_filter_TextChanged(object sender, EventArgs e)
        {
            DataGridView Ticketinfos = new DataGridView();
            Ticketinfos = dataGridView_ticket_overview;
            Ticketinfos.Rows.Clear();

            for (int i = 0; i < Tickets_ausgelesen.Count; i++)
            {
                if (comboBox_filter.Text == Tickets_ausgelesen[i].GetStatus())
                {
                    string[] row = new string[] { Tickets_ausgelesen[i].GetThema(), Convert.ToString(Tickets_ausgelesen[i].GetDatum()), Tickets_ausgelesen[i].GetErsteller(), Tickets_ausgelesen[i].GetPrioritaet(), Tickets_ausgelesen[i].GetStatus(), Tickets_ausgelesen[i].GetBeschreibung(), Convert.ToString(Tickets_ausgelesen[i].GetID()) };
                    Ticketinfos.Rows.Add(row);
                }
                if (comboBox_filter.Text == "Alle")
                {
                    string[] row = new string[] { Tickets_ausgelesen[i].GetThema(), Convert.ToString(Tickets_ausgelesen[i].GetDatum()), Tickets_ausgelesen[i].GetErsteller(), Tickets_ausgelesen[i].GetPrioritaet(), Tickets_ausgelesen[i].GetStatus(), Tickets_ausgelesen[i].GetBeschreibung(), Convert.ToString(Tickets_ausgelesen[i].GetID()) };
                    Ticketinfos.Rows.Add(row);
                }
            }
        }

        // Suche nach Titel/Beschreibung/Ersteller/
        private void textBox_suche_TextChanged(object sender, EventArgs e)
        {
            // DataGried View Initialisieren
            DataGridView Ticketinfos = new DataGridView();
            Ticketinfos = dataGridView_ticket_overview;
            Ticketinfos.Rows.Clear();

            for (int i = 0; i < Tickets_ausgelesen.Count; i++)
            {
                // Suche unabhängig von Groß-/Kleinschreibung
                string ticket_thema = Tickets_ausgelesen[i].GetThema().ToUpper();
                string text_suche = textBox_suche.Text.ToUpper();
                string ticket_beschreibung = Tickets_ausgelesen[i].GetBeschreibung().ToUpper();
                string ticket_ersteller = Tickets_ausgelesen[i].GetErsteller().ToUpper();

                if (comboBox_filter.Text != "Alle")
                {
                    // Suche
                    if (ticket_thema.Contains(text_suche) | ticket_beschreibung.Contains(text_suche) | ticket_ersteller.Contains(text_suche) && (comboBox_filter.Text == Tickets_ausgelesen[i].GetStatus()))
                    {
                        string[] row = new string[] { Tickets_ausgelesen[i].GetThema(), Convert.ToString(Tickets_ausgelesen[i].GetDatum()), Tickets_ausgelesen[i].GetErsteller(), Tickets_ausgelesen[i].GetPrioritaet(), Tickets_ausgelesen[i].GetStatus(), Tickets_ausgelesen[i].GetBeschreibung(), Convert.ToString(Tickets_ausgelesen[i].GetID()) };
                        Ticketinfos.Rows.Add(row);
                    }
                }
                else
                {
                    if (ticket_thema.Contains(text_suche) | ticket_beschreibung.Contains(text_suche) | ticket_ersteller.Contains(text_suche))
                    {
                        string[] row = new string[] { Tickets_ausgelesen[i].GetThema(), Convert.ToString(Tickets_ausgelesen[i].GetDatum()), Tickets_ausgelesen[i].GetErsteller(), Tickets_ausgelesen[i].GetPrioritaet(), Tickets_ausgelesen[i].GetStatus(), Tickets_ausgelesen[i].GetBeschreibung(), Convert.ToString(Tickets_ausgelesen[i].GetID()) };
                        Ticketinfos.Rows.Add(row);
                    }
                }
            }
        }

        private void button_beenden_Click(object sender, EventArgs e)
        {
            string message = "Möchten Sie die Anwendung wirklich beenden";
            string caption = "Infobox";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                //Hier neue Ticketdaten einlesen und alte Liste überschreiben
                Environment.Exit(0);
            }
            else
            if (result == DialogResult.No) { }                          
        }
    }
}