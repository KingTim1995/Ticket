namespace Ticketsystem
{
    partial class TicketView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_thema = new System.Windows.Forms.TextBox();
            this.button_speichern = new System.Windows.Forms.Button();
            this.textBox_beschreibung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_ersteller = new System.Windows.Forms.ComboBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.comboBox_prioritaet = new System.Windows.Forms.ComboBox();
            this.button_neuesTicket = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_bearbeiter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thema";
            // 
            // textBox_thema
            // 
            this.textBox_thema.Location = new System.Drawing.Point(150, 28);
            this.textBox_thema.Name = "textBox_thema";
            this.textBox_thema.Size = new System.Drawing.Size(121, 20);
            this.textBox_thema.TabIndex = 1;
            // 
            // button_speichern
            // 
            this.button_speichern.Location = new System.Drawing.Point(17, 303);
            this.button_speichern.Name = "button_speichern";
            this.button_speichern.Size = new System.Drawing.Size(104, 36);
            this.button_speichern.TabIndex = 2;
            this.button_speichern.Text = "Speichern";
            this.button_speichern.UseVisualStyleBackColor = true;
            this.button_speichern.Click += new System.EventHandler(this.button_speichern_Click);
            // 
            // textBox_beschreibung
            // 
            this.textBox_beschreibung.Location = new System.Drawing.Point(368, 69);
            this.textBox_beschreibung.Multiline = true;
            this.textBox_beschreibung.Name = "textBox_beschreibung";
            this.textBox_beschreibung.Size = new System.Drawing.Size(302, 204);
            this.textBox_beschreibung.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beschreibung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ersteller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Priorität";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comboBox_ersteller
            // 
            this.comboBox_ersteller.FormattingEnabled = true;
            this.comboBox_ersteller.Location = new System.Drawing.Point(150, 118);
            this.comboBox_ersteller.Name = "comboBox_ersteller";
            this.comboBox_ersteller.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ersteller.TabIndex = 14;
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(150, 207);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_status.TabIndex = 15;
            // 
            // comboBox_prioritaet
            // 
            this.comboBox_prioritaet.FormattingEnabled = true;
            this.comboBox_prioritaet.Location = new System.Drawing.Point(150, 162);
            this.comboBox_prioritaet.Name = "comboBox_prioritaet";
            this.comboBox_prioritaet.Size = new System.Drawing.Size(121, 21);
            this.comboBox_prioritaet.TabIndex = 16;
            // 
            // button_neuesTicket
            // 
            this.button_neuesTicket.Location = new System.Drawing.Point(150, 303);
            this.button_neuesTicket.Name = "button_neuesTicket";
            this.button_neuesTicket.Size = new System.Drawing.Size(104, 36);
            this.button_neuesTicket.TabIndex = 17;
            this.button_neuesTicket.Text = "Neues Ticket";
            this.button_neuesTicket.UseVisualStyleBackColor = true;
            this.button_neuesTicket.Click += new System.EventHandler(this.button_neuesTicket_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bearbeiter";
            // 
            // comboBox_bearbeiter
            // 
            this.comboBox_bearbeiter.FormattingEnabled = true;
            this.comboBox_bearbeiter.Location = new System.Drawing.Point(150, 252);
            this.comboBox_bearbeiter.Name = "comboBox_bearbeiter";
            this.comboBox_bearbeiter.Size = new System.Drawing.Size(121, 21);
            this.comboBox_bearbeiter.TabIndex = 19;
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 361);
            this.Controls.Add(this.comboBox_bearbeiter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_neuesTicket);
            this.Controls.Add(this.comboBox_prioritaet);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.comboBox_ersteller);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_beschreibung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_speichern);
            this.Controls.Add(this.textBox_thema);
            this.Controls.Add(this.label1);
            this.Name = "TicketView";
            this.Text = "Ticket anpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_thema;
        private System.Windows.Forms.Button button_speichern;
        private System.Windows.Forms.TextBox textBox_beschreibung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_ersteller;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.ComboBox comboBox_prioritaet;
        private System.Windows.Forms.Button button_neuesTicket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_bearbeiter;
    }
}

