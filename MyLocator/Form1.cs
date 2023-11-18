﻿using System;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace MyLocator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CurrentValue = 1;
        

        public void Berechnen_Click(object sender, EventArgs e)
        {
            #region Entfernung und Richtung berechnen aus zwei Textfeldern

            // die beiden Locatoreingaben holen und in der Klasse MaidenheadLocator ausrechnen lassen
            double entfernung = MaidenheadLocator.Distance(tbHeimatlocator.Text, tbZiellocator.Text);

            // Richtung berechnen aus den zwei Textfeldern
            double richtung = MaidenheadLocator.Azimuth(tbHeimatlocator.Text, tbZiellocator.Text);

            // Heimatlocator aus dem Textfeld
            //string heimatLocator = tbHeimatlocator.Text;

            // Koordinaten vom Lacator aus dem Textfeld des Heimatlocators
            LatLng heimatkoordinaten = MaidenheadLocator.LocatorToLatLng(tbHeimatlocator.Text);

            // Koordinaten vom Lacator aus dem Textfeld des Ziellocators
            LatLng zielkoordinaten = MaidenheadLocator.LocatorToLatLng(tbZiellocator.Text);

            // Breite/Länge in Locator konvertieren
            //string myLoc = MaidenheadLocator.LatLngToLocator(52.41, 12.55);

            //Richtungswert auf 2 Kommastellen runden
            tbRichtung.Text = Math.Round(double.Parse(richtung.ToString()), 2).ToString() + " °";
            
            // EntfernungsWert auf 2 Kommastellen runden 
            tbEntfernung.Text = Math.Round(double.Parse(entfernung.ToString()), 2).ToString() + " km";

            // in Textfeld eintragen
            lblZielKoordinaten.Text = zielkoordinaten.ToString(); 
            
            // in Textfeld eintragen
            lblEigeneKoordinaten.Text = heimatkoordinaten.ToString(); 
            
            // umwandeln der Gradanzahl in eine Ganzahlige Zahl
            CurrentValue = Convert.ToInt32(richtung); 
            
            // in Label eintragen
            lblDegrees.Text = CurrentValue.ToString() + " °"; 

            // neuzeichnen der Kompassnadel bei Änderung 
            picHeading.Refresh();

        }
        #endregion

        #region Berechnung Locator aus dem Koordinator
        private void btnBerechnen2_Click(object sender, EventArgs e)
        {
            //double Long = 12.41;
            // konvertieren und aus der Textbox die Werte holen
            double Long = double.Parse(tbKoordinatenLongitude.Text);

            //double Lat = 52.41;
            // konvertieren und aus der Textbox die Werte holen
            double Lat = double.Parse(tbKoordinatenLatitude.Text);

            // Breite/Länge in Locator konvertieren
            string myLoc = MaidenheadLocator.LatLngToLocator(Lat, Long);

            // Locator in Textfeld eintragen
            tbBerechneterLocator.Text = myLoc.ToString();

        }
        #endregion

        #region laden der letzten gespeicherten Daten
        private void Form1_Load(object sender, EventArgs e)
        {
            // während des Ladens den Wert aus der Variablen heimatLocator holen und in die Textbox eintragen.
            tbHeimatlocator.Text = Properties.Settings.Default.heimatLocator;
            // während des Ladens den Wert aus der Variablen heimatLocator holen und in die Textbox eintragen.
            tbZiellocator.Text = Properties.Settings.Default.zielLocator;
            // während des Ladens den Wert aus der Variablen KoordinatenLatitude holen und in die Textbox eintragen.
            tbKoordinatenLatitude.Text = Properties.Settings.Default.KoordinatenLatitude;
            // während des Ladens den Wert aus der Variablen heimatLocator holen und in die Textbox eintragen.
            tbKoordinatenLongitude.Text = Properties.Settings.Default.KoordinatenLongitude;
            Berechnen_Click(this, EventArgs.Empty);
        }
        #endregion

        #region während des schließens den Wert speichern
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // speichert den Wert aus der Textbox in die Variable heimatLocator beim schließen der Form
            Properties.Settings.Default.heimatLocator = tbHeimatlocator.Text;
            // speichert den Wert aus der Textbox in die Variable zielLocator beim schließen der Form
            Properties.Settings.Default.zielLocator = tbZiellocator.Text;
            // speichert den Wert aus der Textbox in die Variable tbKoordinatenLatitude
            Properties.Settings.Default.KoordinatenLatitude = tbKoordinatenLatitude.Text;
            // speichert den Wert aus der Textbox in die Variable tbKoordinatenLongitude
            Properties.Settings.Default.KoordinatenLongitude = tbKoordinatenLongitude.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region runder Kompass
        private void picHeading_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(picHeading.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            // Draw the heading picture.
            using (Font nsew_font = new Font("Times New Roman", 18,
                FontStyle.Bold))
            {
                DrawHeading(e.Graphics, CurrentValue, nsew_font);
            }
        }
        #endregion

        #region Zeichnen runder Kompass
        private void DrawHeading(Graphics gr, int value, Font font)
        {
            float cx = picHeading.ClientSize.Width / 2f;
            float cy = picHeading.ClientSize.Height / 2f;

            // Draw NSEW.
            float letter_r = Math.Min(cx, cy) * 0.85f;
            string[] letters = { "0°", "90°", "180°", "270°" };
            int[] degrees = { 270, 0, 90, 180 };
            for (int i = 0; i < 4; i++)
            {
                float letter_x = letter_r * (float)Math.Cos(DegreesToRadians(degrees[i]));
                float letter_y = letter_r * (float)Math.Sin(DegreesToRadians(degrees[i]));
                PointF point = new PointF(cx + letter_x, cy + letter_y);
                DrawRotatedText(gr, font, Brushes.Black,
                    letters[i], point, degrees[i] + 90);
            }

            // Draw tick marks.
            const int large_tick_freq = 30; // Draw a large tick mark every 30 degrees.
            const int small_tick_freq = 15; // Draw a small tick mark every 15 degrees.
            const int tiny_tick_freq = 3;   // Draw a tiny tick mark every 3 degrees.
            float outer_r = letter_r * 0.9f;
            float large_r = outer_r * 0.8f;
            float small_r = outer_r * 0.9f;
            float tiny_r = outer_r * 0.95f;
            using (Pen pen = new Pen(Color.Blue, 3))
            {
                for (int i = tiny_tick_freq; i <= 360; i += tiny_tick_freq)
                {
                    float cos = (float)Math.Cos(DegreesToRadians(i));
                    float sin = (float)Math.Sin(DegreesToRadians(i));
                    float x0 = cx + outer_r * cos;
                    float y0 = cy + outer_r * sin;

                    float x1, y1;
                    if (i % large_tick_freq == 0)
                    {
                        pen.Width = 3;
                        x1 = cx + large_r * cos;
                        y1 = cy + large_r * sin;
                    }
                    else if (i % small_tick_freq == 0)
                    {
                        pen.Width = 2;
                        x1 = cx + small_r * cos;
                        y1 = cy + small_r * sin;
                    }
                    else
                    {
                        pen.Width = 1;
                        x1 = cx + tiny_r * cos;
                        y1 = cy + tiny_r * sin;
                    }
                    gr.DrawLine(pen, x0, y0, x1, y1);
                }
            }

            // Draw the pointer.
            // Rotate 90 degrees so North is at 0.
            double radians = DegreesToRadians(value - 90);

            const int tip_r = 4;
            float pointer_r = large_r * 1.0f;
            float tip_x = cx + pointer_r * (float)Math.Cos(radians);
            float tip_y = cx + pointer_r * (float)Math.Sin(radians);
            float tip_x1 = cx + tip_r * (float)Math.Cos(radians + Math.PI / 2.0);
            float tip_y1 = cy + tip_r * (float)Math.Sin(radians + Math.PI / 2.0);
            float tip_x2 = cx + tip_r * (float)Math.Cos(radians - Math.PI / 2.0);
            float tip_y2 = cy + tip_r * (float)Math.Sin(radians - Math.PI / 2.0);
            PointF[] points =
            {
                new PointF(tip_x, tip_y),
                new PointF(tip_x1, tip_y1),
                new PointF(tip_x2, tip_y2),
            };
            gr.FillPolygon(Brushes.Black, points); // Zeiger

            // Draw the center.
            const int center_r = 6; // Durchmesser Mittelpunktkreis
            RectangleF rect = new RectangleF(
                cx - center_r, cy - center_r,
                2 * center_r, 2 * center_r);
            gr.FillEllipse(Brushes.LightBlue, rect); // Füllung Kreis Mittelpunkt
            gr.DrawEllipse(Pens.Black, rect);// Kreis im Mittelpunkt
            
        }
        
        private double DegreesToRadians(float degrees)
        {
            return degrees * Math.PI / 180;
        }
        #endregion

        #region Zeiger drehen im runden Kompass
        private void DrawRotatedText(Graphics gr, Font font, Brush brush,
            string text, PointF location, float degrees)
        {
            GraphicsState state = gr.Save();
            gr.ResetTransform();
            gr.RotateTransform(degrees);
            gr.TranslateTransform(location.X, location.Y, MatrixOrder.Append);
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                gr.DrawString(text, font, brush, 0, 0, sf);
            }
            gr.Restore(state);
        }
        #endregion

        #region Button Hilfe Infobox aufrufen
        private void btnInfobox_Click(object sender, EventArgs e)
        {
            Info MyAboutBox = new Info();
            MyAboutBox.ShowDialog();
        }
        #endregion

        #region Heimatlocator Prüfen auf Richtigkeit der eingegebenen Buchstaben
        private void tbHeimatlocator_TextChanged(object sender, EventArgs e)
        {
            if (new Regex("^[A-R,a-r]{2}[0-9]{2}[A-X,a-x]{2}$").IsMatch(tbHeimatlocator.Text))
            {
                tbHeimatlocator.Enabled = true;
                tbHeimatlocator.ForeColor = Color.Black;
            }
            else
            {
                //MessageBox.Show("Dieser Locator gibt es nicht!");
                tbHeimatlocator.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Ziellocator Prüfen auf Richtigkeit der eingegebenen Buchstaben
        private void destLoc_TextChanged(object sender, EventArgs e)
        {
            if (new Regex("^[A-R,a-r]{2}[0-9]{2}[A-X,a-x]{2}$").IsMatch(tbZiellocator.Text))
            {
                tbZiellocator.Enabled = true;
                tbZiellocator.ForeColor = Color.Black;
            }
            else
            {
               // MessageBox.Show("Dieser Locator gibt es nicht!");
                tbZiellocator.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Link auf die Webseite für Hilfe
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String hamgeocoding = "https://lutz-baer.homepage.t-online.de/wordpress/?p=2560";
            try
            {
                System.Diagnostics.Process.Start(hamgeocoding);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        #endregion

        #region öffnet Webseite mit Locator
        private void button1_Click(object sender, EventArgs e)
        {
            String hamgeocoding = "https://dxcluster.ha8tks.hu/hamgeocoding/";
            try
            {
                System.Diagnostics.Process.Start(hamgeocoding);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

        }
        #endregion

        #region Leer
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1meinlocator_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }


        private void lblZielKoordinaten_Click(object sender, EventArgs e)
        {

        }

        private void lblEigeneKoordinaten_Click(object sender, EventArgs e)
        {

        }


        private void lblDegrees_Click(object sender, EventArgs e)
        {

        }
  
        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1Koordinaten_Click(object sender, EventArgs e)
        {

        }

        private void tbHeimatlocator_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbZiellocator_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRichtung_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbEntfernung_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblEigeneKoordinaten2_Click(object sender, EventArgs e)
        {

        }

        private void lblZielKoordinaten2_Click(object sender, EventArgs e)
        {

        }

        private void tbBerechneterLocator_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKoordinatenLongitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKoordinatenLatitude_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
