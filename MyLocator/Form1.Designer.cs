namespace MyLocator
{
    partial class Form1
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
            this.heimatlocator = new System.Windows.Forms.TextBox();
            this.ziellocator = new System.Windows.Forms.TextBox();
            this.Berechnen = new System.Windows.Forms.Button();
            this.tbRichtung = new System.Windows.Forms.TextBox();
            this.tbEntfernung = new System.Windows.Forms.TextBox();
            this.label1meinlocator = new System.Windows.Forms.Label();
            this.label1andererlocator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2entfernung = new System.Windows.Forms.Label();
            this.lblZielKoordinaten = new System.Windows.Forms.Label();
            this.lblEigeneKoordinaten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heimatlocator
            // 
            this.heimatlocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heimatlocator.Location = new System.Drawing.Point(94, 13);
            this.heimatlocator.Name = "heimatlocator";
            this.heimatlocator.Size = new System.Drawing.Size(100, 26);
            this.heimatlocator.TabIndex = 0;
            this.heimatlocator.Text = "JO62GK";
            this.heimatlocator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.heimatlocator.TextChanged += new System.EventHandler(this.homeLoc_TextChanged);
            // 
            // ziellocator
            // 
            this.ziellocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ziellocator.Location = new System.Drawing.Point(94, 45);
            this.ziellocator.Name = "ziellocator";
            this.ziellocator.Size = new System.Drawing.Size(100, 26);
            this.ziellocator.TabIndex = 1;
            this.ziellocator.Text = "JO62QM";
            this.ziellocator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ziellocator.TextChanged += new System.EventHandler(this.destLoc_TextChanged);
            // 
            // Berechnen
            // 
            this.Berechnen.Location = new System.Drawing.Point(240, 115);
            this.Berechnen.Name = "Berechnen";
            this.Berechnen.Size = new System.Drawing.Size(75, 23);
            this.Berechnen.TabIndex = 4;
            this.Berechnen.Text = "Berechnen";
            this.Berechnen.Click += new System.EventHandler(this.Berechnen_Click);
            // 
            // tbRichtung
            // 
            this.tbRichtung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRichtung.Location = new System.Drawing.Point(94, 77);
            this.tbRichtung.Name = "tbRichtung";
            this.tbRichtung.Size = new System.Drawing.Size(100, 26);
            this.tbRichtung.TabIndex = 3;
            this.tbRichtung.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbEntfernung
            // 
            this.tbEntfernung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEntfernung.Location = new System.Drawing.Point(94, 109);
            this.tbEntfernung.Name = "tbEntfernung";
            this.tbEntfernung.Size = new System.Drawing.Size(101, 26);
            this.tbEntfernung.TabIndex = 5;
            this.tbEntfernung.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1meinlocator
            // 
            this.label1meinlocator.AutoSize = true;
            this.label1meinlocator.Location = new System.Drawing.Point(12, 21);
            this.label1meinlocator.Name = "label1meinlocator";
            this.label1meinlocator.Size = new System.Drawing.Size(69, 13);
            this.label1meinlocator.TabIndex = 8;
            this.label1meinlocator.Text = "Mein Locator";
            this.label1meinlocator.Click += new System.EventHandler(this.label1meinlocator_Click);
            // 
            // label1andererlocator
            // 
            this.label1andererlocator.AutoSize = true;
            this.label1andererlocator.Location = new System.Drawing.Point(57, 56);
            this.label1andererlocator.Name = "label1andererlocator";
            this.label1andererlocator.Size = new System.Drawing.Size(24, 13);
            this.label1andererlocator.TabIndex = 8;
            this.label1andererlocator.Text = "Ziel";
            this.label1andererlocator.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Richtung";
            // 
            // label2entfernung
            // 
            this.label2entfernung.AutoSize = true;
            this.label2entfernung.Location = new System.Drawing.Point(22, 120);
            this.label2entfernung.Name = "label2entfernung";
            this.label2entfernung.Size = new System.Drawing.Size(59, 13);
            this.label2entfernung.TabIndex = 9;
            this.label2entfernung.Text = "Entfernung";
            this.label2entfernung.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblZielKoordinaten
            // 
            this.lblZielKoordinaten.AutoSize = true;
            this.lblZielKoordinaten.Location = new System.Drawing.Point(200, 56);
            this.lblZielKoordinaten.Name = "lblZielKoordinaten";
            this.lblZielKoordinaten.Size = new System.Drawing.Size(64, 13);
            this.lblZielKoordinaten.TabIndex = 10;
            this.lblZielKoordinaten.Text = "Koordinaten";
            this.lblZielKoordinaten.Click += new System.EventHandler(this.lblZielKoordinaten_Click);
            // 
            // lblEigeneKoordinaten
            // 
            this.lblEigeneKoordinaten.AutoSize = true;
            this.lblEigeneKoordinaten.Location = new System.Drawing.Point(200, 21);
            this.lblEigeneKoordinaten.Name = "lblEigeneKoordinaten";
            this.lblEigeneKoordinaten.Size = new System.Drawing.Size(64, 13);
            this.lblEigeneKoordinaten.TabIndex = 11;
            this.lblEigeneKoordinaten.Text = "Koordinaten";
            this.lblEigeneKoordinaten.Click += new System.EventHandler(this.lblEigeneKoordinaten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 157);
            this.Controls.Add(this.lblEigeneKoordinaten);
            this.Controls.Add(this.lblZielKoordinaten);
            this.Controls.Add(this.label2entfernung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1andererlocator);
            this.Controls.Add(this.label1meinlocator);
            this.Controls.Add(this.tbEntfernung);
            this.Controls.Add(this.tbRichtung);
            this.Controls.Add(this.Berechnen);
            this.Controls.Add(this.ziellocator);
            this.Controls.Add(this.heimatlocator);
            this.Name = "Form1";
            this.Text = "MyLocator";
            this.Load += new System.EventHandler(this.Berechnen_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heimatlocator;
        private System.Windows.Forms.TextBox ziellocator;
        private System.Windows.Forms.Button Berechnen;
        private System.Windows.Forms.TextBox tbRichtung;
        private System.Windows.Forms.TextBox tbEntfernung;
        private System.Windows.Forms.Label label1meinlocator;
        private System.Windows.Forms.Label label1andererlocator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2entfernung;
        private System.Windows.Forms.Label lblZielKoordinaten;
        private System.Windows.Forms.Label lblEigeneKoordinaten;
    }
}

