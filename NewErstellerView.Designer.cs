namespace Ticketsystem
{
    partial class NewErstellerView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ersteller_zuruecksetzen = new System.Windows.Forms.Button();
            this.button_ersteller_speichern = new System.Windows.Forms.Button();
            this.textBox_ersteller_name = new System.Windows.Forms.TextBox();
            this.textBox_ersteller_kuerzel = new System.Windows.Forms.TextBox();
            this.textBox_ersteller_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kürzel";
            // 
            // button_ersteller_zuruecksetzen
            // 
            this.button_ersteller_zuruecksetzen.Location = new System.Drawing.Point(220, 178);
            this.button_ersteller_zuruecksetzen.Name = "button_ersteller_zuruecksetzen";
            this.button_ersteller_zuruecksetzen.Size = new System.Drawing.Size(86, 23);
            this.button_ersteller_zuruecksetzen.TabIndex = 15;
            this.button_ersteller_zuruecksetzen.Text = "Zurücksetzen";
            this.button_ersteller_zuruecksetzen.UseVisualStyleBackColor = true;
            this.button_ersteller_zuruecksetzen.Click += new System.EventHandler(this.button_zuruecksetzen_Click);
            // 
            // button_ersteller_speichern
            // 
            this.button_ersteller_speichern.Location = new System.Drawing.Point(19, 178);
            this.button_ersteller_speichern.Name = "button_ersteller_speichern";
            this.button_ersteller_speichern.Size = new System.Drawing.Size(75, 23);
            this.button_ersteller_speichern.TabIndex = 14;
            this.button_ersteller_speichern.Text = "Speichern";
            this.button_ersteller_speichern.UseVisualStyleBackColor = true;
            this.button_ersteller_speichern.Click += new System.EventHandler(this.button_speichern_Click);
            // 
            // textBox_ersteller_name
            // 
            this.textBox_ersteller_name.Location = new System.Drawing.Point(115, 22);
            this.textBox_ersteller_name.Name = "textBox_ersteller_name";
            this.textBox_ersteller_name.Size = new System.Drawing.Size(180, 20);
            this.textBox_ersteller_name.TabIndex = 13;
            // 
            // textBox_ersteller_kuerzel
            // 
            this.textBox_ersteller_kuerzel.Location = new System.Drawing.Point(115, 72);
            this.textBox_ersteller_kuerzel.Name = "textBox_ersteller_kuerzel";
            this.textBox_ersteller_kuerzel.Size = new System.Drawing.Size(180, 20);
            this.textBox_ersteller_kuerzel.TabIndex = 12;
            // 
            // textBox_ersteller_email
            // 
            this.textBox_ersteller_email.Location = new System.Drawing.Point(115, 122);
            this.textBox_ersteller_email.Name = "textBox_ersteller_email";
            this.textBox_ersteller_email.Size = new System.Drawing.Size(180, 20);
            this.textBox_ersteller_email.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // NewErstellerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ersteller_zuruecksetzen);
            this.Controls.Add(this.button_ersteller_speichern);
            this.Controls.Add(this.textBox_ersteller_name);
            this.Controls.Add(this.textBox_ersteller_kuerzel);
            this.Controls.Add(this.textBox_ersteller_email);
            this.Controls.Add(this.label1);
            this.Name = "NewErstellerView";
            this.Text = "Ersteller anpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ersteller_zuruecksetzen;
        private System.Windows.Forms.Button button_ersteller_speichern;
        private System.Windows.Forms.TextBox textBox_ersteller_name;
        private System.Windows.Forms.TextBox textBox_ersteller_kuerzel;
        private System.Windows.Forms.TextBox textBox_ersteller_email;
        private System.Windows.Forms.Label label1;
    }
}