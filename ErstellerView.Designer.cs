namespace Ticketsystem
{
    partial class ErstellerView
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
            this.button_ersteller_loeschen = new System.Windows.Forms.Button();
            this.button_ersteller_neu = new System.Windows.Forms.Button();
            this.dataGridView_ersteller_uebersicht = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ersteller_aendern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ersteller_uebersicht)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ersteller_loeschen
            // 
            this.button_ersteller_loeschen.Location = new System.Drawing.Point(437, 23);
            this.button_ersteller_loeschen.Name = "button_ersteller_loeschen";
            this.button_ersteller_loeschen.Size = new System.Drawing.Size(75, 23);
            this.button_ersteller_loeschen.TabIndex = 11;
            this.button_ersteller_loeschen.Text = "Löschen";
            this.button_ersteller_loeschen.UseVisualStyleBackColor = true;
            // 
            // button_ersteller_neu
            // 
            this.button_ersteller_neu.Location = new System.Drawing.Point(275, 23);
            this.button_ersteller_neu.Name = "button_ersteller_neu";
            this.button_ersteller_neu.Size = new System.Drawing.Size(75, 23);
            this.button_ersteller_neu.TabIndex = 9;
            this.button_ersteller_neu.Text = "Neu";
            this.button_ersteller_neu.UseVisualStyleBackColor = true;
            this.button_ersteller_neu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_ersteller_uebersicht
            // 
            this.dataGridView_ersteller_uebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ersteller_uebersicht.Location = new System.Drawing.Point(12, 53);
            this.dataGridView_ersteller_uebersicht.Name = "dataGridView_ersteller_uebersicht";
            this.dataGridView_ersteller_uebersicht.Size = new System.Drawing.Size(518, 150);
            this.dataGridView_ersteller_uebersicht.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Suche:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button_ersteller_aendern
            // 
            this.button_ersteller_aendern.Location = new System.Drawing.Point(356, 23);
            this.button_ersteller_aendern.Name = "button_ersteller_aendern";
            this.button_ersteller_aendern.Size = new System.Drawing.Size(75, 23);
            this.button_ersteller_aendern.TabIndex = 10;
            this.button_ersteller_aendern.Text = "Ändern";
            this.button_ersteller_aendern.UseVisualStyleBackColor = true;
            this.button_ersteller_aendern.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErstellerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 245);
            this.Controls.Add(this.button_ersteller_loeschen);
            this.Controls.Add(this.button_ersteller_aendern);
            this.Controls.Add(this.button_ersteller_neu);
            this.Controls.Add(this.dataGridView_ersteller_uebersicht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ErstellerView";
            this.Text = "Ersteller";
            this.Load += new System.EventHandler(this.ErstellerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ersteller_uebersicht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ersteller_loeschen;
        private System.Windows.Forms.Button button_ersteller_neu;
        private System.Windows.Forms.DataGridView dataGridView_ersteller_uebersicht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_ersteller_aendern;
    }
}