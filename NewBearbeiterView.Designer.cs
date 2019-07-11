namespace Ticketsystem
{
    partial class NewBearbeiterView
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_bearbeiter_email = new System.Windows.Forms.TextBox();
            this.textBox_bearbeiter_kuerzel = new System.Windows.Forms.TextBox();
            this.textBox_bearbeiter_name = new System.Windows.Forms.TextBox();
            this.button_bearbeiter_speichern = new System.Windows.Forms.Button();
            this.button_bearbeiter_zuruecksetzen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox_bearbeiter_email
            // 
            this.textBox_bearbeiter_email.Location = new System.Drawing.Point(115, 122);
            this.textBox_bearbeiter_email.Name = "textBox_bearbeiter_email";
            this.textBox_bearbeiter_email.Size = new System.Drawing.Size(180, 20);
            this.textBox_bearbeiter_email.TabIndex = 3;
            // 
            // textBox_bearbeiter_kuerzel
            // 
            this.textBox_bearbeiter_kuerzel.Location = new System.Drawing.Point(115, 72);
            this.textBox_bearbeiter_kuerzel.Name = "textBox_bearbeiter_kuerzel";
            this.textBox_bearbeiter_kuerzel.Size = new System.Drawing.Size(180, 20);
            this.textBox_bearbeiter_kuerzel.TabIndex = 4;
            // 
            // textBox_bearbeiter_name
            // 
            this.textBox_bearbeiter_name.Location = new System.Drawing.Point(115, 22);
            this.textBox_bearbeiter_name.Name = "textBox_bearbeiter_name";
            this.textBox_bearbeiter_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_bearbeiter_name.TabIndex = 5;
            // 
            // button_bearbeiter_speichern
            // 
            this.button_bearbeiter_speichern.Location = new System.Drawing.Point(19, 178);
            this.button_bearbeiter_speichern.Name = "button_bearbeiter_speichern";
            this.button_bearbeiter_speichern.Size = new System.Drawing.Size(75, 23);
            this.button_bearbeiter_speichern.TabIndex = 6;
            this.button_bearbeiter_speichern.Text = "Speichern";
            this.button_bearbeiter_speichern.UseVisualStyleBackColor = true;
            this.button_bearbeiter_speichern.Click += new System.EventHandler(this.button_speichern_Click);
            // 
            // button_bearbeiter_zuruecksetzen
            // 
            this.button_bearbeiter_zuruecksetzen.Location = new System.Drawing.Point(209, 178);
            this.button_bearbeiter_zuruecksetzen.Name = "button_bearbeiter_zuruecksetzen";
            this.button_bearbeiter_zuruecksetzen.Size = new System.Drawing.Size(86, 23);
            this.button_bearbeiter_zuruecksetzen.TabIndex = 7;
            this.button_bearbeiter_zuruecksetzen.Text = "Zurücksetzen";
            this.button_bearbeiter_zuruecksetzen.UseVisualStyleBackColor = true;
            this.button_bearbeiter_zuruecksetzen.Click += new System.EventHandler(this.button_zuruecksetzen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kürzel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-Mail";
            // 
            // NewBearbeiterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_bearbeiter_zuruecksetzen);
            this.Controls.Add(this.button_bearbeiter_speichern);
            this.Controls.Add(this.textBox_bearbeiter_name);
            this.Controls.Add(this.textBox_bearbeiter_kuerzel);
            this.Controls.Add(this.textBox_bearbeiter_email);
            this.Controls.Add(this.label1);
            this.Name = "NewBearbeiterView";
            this.Text = "Bearbeiter anpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_bearbeiter_email;
        private System.Windows.Forms.TextBox textBox_bearbeiter_kuerzel;
        private System.Windows.Forms.TextBox textBox_bearbeiter_name;
        private System.Windows.Forms.Button button_bearbeiter_speichern;
        private System.Windows.Forms.Button button_bearbeiter_zuruecksetzen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}