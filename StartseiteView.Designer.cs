namespace Ticketsystem
{
    partial class StartseiteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_ticket_overview = new System.Windows.Forms.DataGridView();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.textBox_suche = new System.Windows.Forms.TextBox();
            this.button_neuesTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Bearbeiter = new System.Windows.Forms.Button();
            this.Button_Ersteller = new System.Windows.Forms.Button();
            this.button_beenden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket_overview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ticket_overview
            // 
            this.dataGridView_ticket_overview.AllowUserToAddRows = false;
            this.dataGridView_ticket_overview.AllowUserToDeleteRows = false;
            this.dataGridView_ticket_overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ticket_overview.Location = new System.Drawing.Point(23, 102);
            this.dataGridView_ticket_overview.Name = "dataGridView_ticket_overview";
            this.dataGridView_ticket_overview.Size = new System.Drawing.Size(697, 185);
            this.dataGridView_ticket_overview.TabIndex = 0;
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Location = new System.Drawing.Point(23, 61);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(121, 21);
            this.comboBox_filter.TabIndex = 1;
            this.comboBox_filter.TextChanged += new System.EventHandler(this.comboBox_filter_TextChanged);
            // 
            // textBox_suche
            // 
            this.textBox_suche.Location = new System.Drawing.Point(580, 63);
            this.textBox_suche.Name = "textBox_suche";
            this.textBox_suche.Size = new System.Drawing.Size(140, 20);
            this.textBox_suche.TabIndex = 2;
            this.textBox_suche.TextChanged += new System.EventHandler(this.textBox_suche_TextChanged);
            // 
            // button_neuesTicket
            // 
            this.button_neuesTicket.Location = new System.Drawing.Point(25, 310);
            this.button_neuesTicket.Name = "button_neuesTicket";
            this.button_neuesTicket.Size = new System.Drawing.Size(95, 23);
            this.button_neuesTicket.TabIndex = 3;
            this.button_neuesTicket.Text = "Neues Ticket";
            this.button_neuesTicket.UseVisualStyleBackColor = true;
            this.button_neuesTicket.Click += new System.EventHandler(this.Button_neuesTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtern nach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(650, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suche:";
            // 
            // Button_Bearbeiter
            // 
            this.Button_Bearbeiter.Location = new System.Drawing.Point(126, 310);
            this.Button_Bearbeiter.Name = "Button_Bearbeiter";
            this.Button_Bearbeiter.Size = new System.Drawing.Size(104, 23);
            this.Button_Bearbeiter.TabIndex = 7;
            this.Button_Bearbeiter.Text = "Bearbeiter";
            this.Button_Bearbeiter.UseVisualStyleBackColor = true;
            this.Button_Bearbeiter.Click += new System.EventHandler(this.Button_Bearbeiter_Click);
            // 
            // Button_Ersteller
            // 
            this.Button_Ersteller.Location = new System.Drawing.Point(236, 310);
            this.Button_Ersteller.Name = "Button_Ersteller";
            this.Button_Ersteller.Size = new System.Drawing.Size(104, 23);
            this.Button_Ersteller.TabIndex = 8;
            this.Button_Ersteller.Text = "Ersteller";
            this.Button_Ersteller.UseVisualStyleBackColor = true;
            this.Button_Ersteller.Click += new System.EventHandler(this.Button_Ersteller_Click);
            // 
            // button_beenden
            // 
            this.button_beenden.Location = new System.Drawing.Point(616, 310);
            this.button_beenden.Name = "button_beenden";
            this.button_beenden.Size = new System.Drawing.Size(104, 23);
            this.button_beenden.TabIndex = 9;
            this.button_beenden.Text = "Beenden";
            this.button_beenden.UseVisualStyleBackColor = true;
            this.button_beenden.Click += new System.EventHandler(this.button_beenden_Click);
            // 
            // StartseiteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 370);
            this.Controls.Add(this.button_beenden);
            this.Controls.Add(this.Button_Ersteller);
            this.Controls.Add(this.Button_Bearbeiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_neuesTicket);
            this.Controls.Add(this.textBox_suche);
            this.Controls.Add(this.comboBox_filter);
            this.Controls.Add(this.dataGridView_ticket_overview);
            this.Name = "StartseiteView";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.StartseiteView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket_overview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.TextBox textBox_suche;
        private System.Windows.Forms.Button button_neuesTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Bearbeiter;
        private System.Windows.Forms.Button Button_Ersteller;
        internal System.Windows.Forms.DataGridView dataGridView_ticket_overview;
        private System.Windows.Forms.Button button_beenden;
    }
}