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
using Newtonsoft.Json;

namespace Ticketsystem
{
    public partial class NewBearbeiterView : Form
    {
        public NewBearbeiterView()
        {
            InitializeComponent();
        }

        private void button_speichern_Click(object sender, EventArgs e)
        {
            try
            {
                Bearbeiter Bearbeiter = new Bearbeiter();

                Bearbeiter.SetName(textBox_bearbeiter_name.Text);
                Bearbeiter.SetKuerzel(textBox_bearbeiter_kuerzel.Text);
                Bearbeiter.SetBearbeiterEmail(textBox_bearbeiter_email.Text);

                var content = JsonConvert.SerializeObject(Bearbeiter);
                File.AppendAllText(Repository.bearbeiterFilePath, content);
                File.AppendAllText(Repository.bearbeiterFilePath, "\n");

                MessageBox.Show("Gespeichert.");
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler! Konnte nicht gespeichert werden.");
                throw;
            }
        }

        private void button_zuruecksetzen_Click(object sender, EventArgs e)
        { 
            textBox_bearbeiter_name.Text = "";
            textBox_bearbeiter_kuerzel.Text = "";
            textBox_bearbeiter_email.Text = "";           
        }
    }
}
