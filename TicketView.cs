using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Ticketsystem
{
    public partial class TicketView : Form
    {
        public TicketView()
        {
            InitializeComponent();

            comboBox_prioritaet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_prioritaet.Items.Add("Hoch");
            comboBox_prioritaet.Items.Add("Mittel");
            comboBox_prioritaet.Items.Add("Niedrig");

            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.Items.Add("Neu");
            comboBox_status.Items.Add("In Bearbeitung");
            comboBox_status.Items.Add("Geschlossen");

            comboBox_ersteller.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button_neuesTicket_Click(object sender, EventArgs e)
        {
            textBox_thema.Clear();
            textBox_beschreibung.Clear();

        }

        private void button_speichern_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket Ticket = new Ticket();

                Ticket.SetThema(textBox_thema.Text);
                Ticket.SetBeschreibung(textBox_beschreibung.Text);
                Ticket.SetDatum(Convert.ToDateTime(dateTimePicker1.Text));
                Ticket.SetErsteller(comboBox_ersteller.Text);
                Ticket.SetPrioritaet(comboBox_prioritaet.Text);
                Ticket.SetStatus(comboBox_status.Text);
                Ticket.SetID();

                var content = JsonConvert.SerializeObject(Ticket);
                File.AppendAllText(Repository.ticketsFilePath, content);
                File.AppendAllText(Repository.ticketsFilePath, "\n");

                MessageBox.Show("Ticket wurde gespeichert.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ticket konnte nicht gespeichert werden.");
                throw;
            }
        }
    }
}
