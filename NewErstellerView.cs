using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Ticketsystem
{
    public partial class NewErstellerView : Form
    {
        public NewErstellerView()
        {
            InitializeComponent();
        }

        private void button_speichern_Click(object sender, EventArgs e)
        {
            try
            {
                Ersteller Ersteller = new Ersteller();

                Ersteller.SetName(textBox_ersteller_name.Text);
                Ersteller.SetKuerzel(textBox_ersteller_kuerzel.Text);
                Ersteller.SetEmail(textBox_ersteller_email.Text);

                var content = JsonConvert.SerializeObject(Ersteller);
                File.AppendAllText(Repository.erstellerFilePath, content);
                File.AppendAllText(Repository.erstellerFilePath, "\n");

                MessageBox.Show("Gespeichert!");
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler: Ersteller Konnte nicht gespeichert werden!");
                throw;
            }
        }

        private void button_zuruecksetzen_Click(object sender, EventArgs e)
        {
            textBox_ersteller_name.Text = "";
            textBox_ersteller_kuerzel.Text = "";
            textBox_ersteller_email.Text = "";
        }
    }
}
