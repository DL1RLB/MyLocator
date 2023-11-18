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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1Koordinaten = new System.Windows.Forms.TabPage();
            this.btnInfobox = new System.Windows.Forms.Button();
            this.lblEigeneKoordinaten = new System.Windows.Forms.Label();
            this.lblZielKoordinaten = new System.Windows.Forms.Label();
            this.tbEntfernung = new System.Windows.Forms.TextBox();
            this.tbRichtung = new System.Windows.Forms.TextBox();
            this.tbZiellocator = new System.Windows.Forms.TextBox();
            this.tbHeimatlocator = new System.Windows.Forms.TextBox();
            this.lblDegrees = new System.Windows.Forms.Label();
            this.Berechnen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picHeading = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBerechnen2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBerechneterLocator = new System.Windows.Forms.TextBox();
            this.tbKoordinatenLongitude = new System.Windows.Forms.TextBox();
            this.tbKoordinatenLatitude = new System.Windows.Forms.TextBox();
            this.tabPage1Hilfe = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1Koordinaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeading)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1Hilfe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1Koordinaten);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1Hilfe);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 328);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Click += new System.EventHandler(this.btnBerechnen2_Click);
            this.tabControl1.Enter += new System.EventHandler(this.btnBerechnen2_Click);
            // 
            // tabPage1Koordinaten
            // 
            this.tabPage1Koordinaten.Controls.Add(this.btnInfobox);
            this.tabPage1Koordinaten.Controls.Add(this.lblEigeneKoordinaten);
            this.tabPage1Koordinaten.Controls.Add(this.lblZielKoordinaten);
            this.tabPage1Koordinaten.Controls.Add(this.tbEntfernung);
            this.tabPage1Koordinaten.Controls.Add(this.tbRichtung);
            this.tabPage1Koordinaten.Controls.Add(this.tbZiellocator);
            this.tabPage1Koordinaten.Controls.Add(this.tbHeimatlocator);
            this.tabPage1Koordinaten.Controls.Add(this.lblDegrees);
            this.tabPage1Koordinaten.Controls.Add(this.Berechnen);
            this.tabPage1Koordinaten.Controls.Add(this.label5);
            this.tabPage1Koordinaten.Controls.Add(this.label6);
            this.tabPage1Koordinaten.Controls.Add(this.label7);
            this.tabPage1Koordinaten.Controls.Add(this.label8);
            this.tabPage1Koordinaten.Controls.Add(this.picHeading);
            this.tabPage1Koordinaten.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Koordinaten.Name = "tabPage1Koordinaten";
            this.tabPage1Koordinaten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Koordinaten.Size = new System.Drawing.Size(467, 302);
            this.tabPage1Koordinaten.TabIndex = 0;
            this.tabPage1Koordinaten.Text = "Locator";
            this.tabPage1Koordinaten.UseVisualStyleBackColor = true;
            this.tabPage1Koordinaten.Click += new System.EventHandler(this.tabPage1Koordinaten_Click);
            // 
            // btnInfobox
            // 
            this.btnInfobox.Location = new System.Drawing.Point(6, 273);
            this.btnInfobox.Name = "btnInfobox";
            this.btnInfobox.Size = new System.Drawing.Size(42, 23);
            this.btnInfobox.TabIndex = 38;
            this.btnInfobox.Text = "Help";
            this.btnInfobox.UseVisualStyleBackColor = true;
            this.btnInfobox.Click += new System.EventHandler(this.btnInfobox_Click);
            // 
            // lblEigeneKoordinaten
            // 
            this.lblEigeneKoordinaten.AutoSize = true;
            this.lblEigeneKoordinaten.Location = new System.Drawing.Point(80, 36);
            this.lblEigeneKoordinaten.Name = "lblEigeneKoordinaten";
            this.lblEigeneKoordinaten.Size = new System.Drawing.Size(64, 13);
            this.lblEigeneKoordinaten.TabIndex = 37;
            this.lblEigeneKoordinaten.Text = "Koordinaten";
            // 
            // lblZielKoordinaten
            // 
            this.lblZielKoordinaten.AutoSize = true;
            this.lblZielKoordinaten.Location = new System.Drawing.Point(80, 81);
            this.lblZielKoordinaten.Name = "lblZielKoordinaten";
            this.lblZielKoordinaten.Size = new System.Drawing.Size(64, 13);
            this.lblZielKoordinaten.TabIndex = 36;
            this.lblZielKoordinaten.Text = "Koordinaten";
            // 
            // tbEntfernung
            // 
            this.tbEntfernung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEntfernung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbEntfernung.Location = new System.Drawing.Point(82, 164);
            this.tbEntfernung.Name = "tbEntfernung";
            this.tbEntfernung.Size = new System.Drawing.Size(101, 26);
            this.tbEntfernung.TabIndex = 35;
            this.tbEntfernung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEntfernung.TextChanged += new System.EventHandler(this.tbEntfernung_TextChanged);
            // 
            // tbRichtung
            // 
            this.tbRichtung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRichtung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbRichtung.Location = new System.Drawing.Point(83, 110);
            this.tbRichtung.Name = "tbRichtung";
            this.tbRichtung.Size = new System.Drawing.Size(100, 26);
            this.tbRichtung.TabIndex = 34;
            this.tbRichtung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRichtung.TextChanged += new System.EventHandler(this.tbRichtung_TextChanged);
            // 
            // tbZiellocator
            // 
            this.tbZiellocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZiellocator.Location = new System.Drawing.Point(83, 52);
            this.tbZiellocator.Name = "tbZiellocator";
            this.tbZiellocator.Size = new System.Drawing.Size(100, 26);
            this.tbZiellocator.TabIndex = 1;
            this.tbZiellocator.Text = "JO62QM";
            this.tbZiellocator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbZiellocator.TextChanged += new System.EventHandler(this.destLoc_TextChanged);
            // 
            // tbHeimatlocator
            // 
            this.tbHeimatlocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeimatlocator.Location = new System.Drawing.Point(83, 7);
            this.tbHeimatlocator.Name = "tbHeimatlocator";
            this.tbHeimatlocator.Size = new System.Drawing.Size(100, 26);
            this.tbHeimatlocator.TabIndex = 2;
            this.tbHeimatlocator.Text = "JO62GJ";
            this.tbHeimatlocator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHeimatlocator.TextChanged += new System.EventHandler(this.tbHeimatlocator_TextChanged);
            // 
            // lblDegrees
            // 
            this.lblDegrees.AutoSize = true;
            this.lblDegrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegrees.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDegrees.Location = new System.Drawing.Point(314, 110);
            this.lblDegrees.Name = "lblDegrees";
            this.lblDegrees.Size = new System.Drawing.Size(36, 20);
            this.lblDegrees.TabIndex = 31;
            this.lblDegrees.Text = "80 °";
            this.lblDegrees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Berechnen
            // 
            this.Berechnen.Location = new System.Drawing.Point(93, 250);
            this.Berechnen.Name = "Berechnen";
            this.Berechnen.Size = new System.Drawing.Size(75, 23);
            this.Berechnen.TabIndex = 29;
            this.Berechnen.Text = "Berechnen";
            this.Berechnen.Click += new System.EventHandler(this.Berechnen_Click);
            this.Berechnen.Enter += new System.EventHandler(this.Berechnen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entfernung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Richtung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ziel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mein Locator";
            // 
            // picHeading
            // 
            this.picHeading.BackColor = System.Drawing.Color.White;
            this.picHeading.Dock = System.Windows.Forms.DockStyle.Right;
            this.picHeading.Location = new System.Drawing.Point(192, 3);
            this.picHeading.Name = "picHeading";
            this.picHeading.Size = new System.Drawing.Size(272, 296);
            this.picHeading.TabIndex = 30;
            this.picHeading.TabStop = false;
            this.picHeading.Paint += new System.Windows.Forms.PaintEventHandler(this.picHeading_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBerechnen2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbBerechneterLocator);
            this.tabPage2.Controls.Add(this.tbKoordinatenLongitude);
            this.tabPage2.Controls.Add(this.tbKoordinatenLatitude);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Koordinaten";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.btnBerechnen2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.btnBerechnen2_Click);
            // 
            // btnBerechnen2
            // 
            this.btnBerechnen2.Location = new System.Drawing.Point(183, 187);
            this.btnBerechnen2.Name = "btnBerechnen2";
            this.btnBerechnen2.Size = new System.Drawing.Size(75, 23);
            this.btnBerechnen2.TabIndex = 47;
            this.btnBerechnen2.Text = "Berechnen";
            this.btnBerechnen2.UseVisualStyleBackColor = true;
            this.btnBerechnen2.Click += new System.EventHandler(this.btnBerechnen2_Click);
            this.btnBerechnen2.Enter += new System.EventHandler(this.btnBerechnen2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Auf Karte anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Bitte mit Komma eintragen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Longitude (Breite)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Latitude (Länge)";
            // 
            // tbBerechneterLocator
            // 
            this.tbBerechneterLocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBerechneterLocator.Location = new System.Drawing.Point(126, 32);
            this.tbBerechneterLocator.Name = "tbBerechneterLocator";
            this.tbBerechneterLocator.Size = new System.Drawing.Size(207, 44);
            this.tbBerechneterLocator.TabIndex = 42;
            this.tbBerechneterLocator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBerechneterLocator.TextChanged += new System.EventHandler(this.tbBerechneterLocator_TextChanged);
            // 
            // tbKoordinatenLongitude
            // 
            this.tbKoordinatenLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKoordinatenLongitude.Location = new System.Drawing.Point(290, 105);
            this.tbKoordinatenLongitude.Name = "tbKoordinatenLongitude";
            this.tbKoordinatenLongitude.Size = new System.Drawing.Size(100, 31);
            this.tbKoordinatenLongitude.TabIndex = 41;
            this.tbKoordinatenLongitude.Text = "12,55";
            this.tbKoordinatenLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKoordinatenLongitude.TextChanged += new System.EventHandler(this.tbKoordinatenLongitude_TextChanged);
            // 
            // tbKoordinatenLatitude
            // 
            this.tbKoordinatenLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKoordinatenLatitude.Location = new System.Drawing.Point(60, 105);
            this.tbKoordinatenLatitude.Name = "tbKoordinatenLatitude";
            this.tbKoordinatenLatitude.Size = new System.Drawing.Size(100, 31);
            this.tbKoordinatenLatitude.TabIndex = 40;
            this.tbKoordinatenLatitude.Text = "52,41";
            this.tbKoordinatenLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbKoordinatenLatitude.TextChanged += new System.EventHandler(this.tbKoordinatenLatitude_TextChanged);
            // 
            // tabPage1Hilfe
            // 
            this.tabPage1Hilfe.AutoScroll = true;
            this.tabPage1Hilfe.Controls.Add(this.linkLabel1);
            this.tabPage1Hilfe.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Hilfe.Name = "tabPage1Hilfe";
            this.tabPage1Hilfe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Hilfe.Size = new System.Drawing.Size(467, 302);
            this.tabPage1Hilfe.TabIndex = 2;
            this.tabPage1Hilfe.Text = "Hilfe";
            this.tabPage1Hilfe.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(81, 129);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(288, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://lutz-baer.homepage.t-online.de/wordpress/?p=2560";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.Berechnen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(510, 400);
            this.MinimumSize = new System.Drawing.Size(510, 400);
            this.Name = "Form1";
            this.Text = "Locatorberechnung Richtung und Entfernung";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1Koordinaten.ResumeLayout(false);
            this.tabPage1Koordinaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeading)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1Hilfe.ResumeLayout(false);
            this.tabPage1Hilfe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1Koordinaten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
     //   private System.Windows.Forms.Button btnBerechnenAusKoordinaten;
        private System.Windows.Forms.Button btnInfobox;
        private System.Windows.Forms.Label lblEigeneKoordinaten;
        private System.Windows.Forms.Label lblZielKoordinaten;
        private System.Windows.Forms.TextBox tbEntfernung;
        private System.Windows.Forms.TextBox tbRichtung;
        private System.Windows.Forms.TextBox tbZiellocator;
        private System.Windows.Forms.TextBox tbHeimatlocator;
        private System.Windows.Forms.Label lblDegrees;
        private System.Windows.Forms.PictureBox picHeading;
        private System.Windows.Forms.Button Berechnen;
        private System.Windows.Forms.TabPage tabPage1Hilfe;
        private System.Windows.Forms.TextBox tbKoordinatenLongitude;
        private System.Windows.Forms.TextBox tbKoordinatenLatitude;
        private System.Windows.Forms.TextBox tbBerechneterLocator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnBerechnen2;
    }
}

