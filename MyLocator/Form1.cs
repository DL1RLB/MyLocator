using System;
using System.Windows.Forms;


namespace MyLocator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    private void Berechnen_Click(object sender, EventArgs e)
        {
            // Entfernung berechnen aus zwei Textfeldern
            double entfernung = MaidenheadLocator.Distance(heimatlocator.Text, ziellocator.Text);
            
            // Richtung berechnen aus zwei Textfeldern
            double richtung = MaidenheadLocator.Azimuth(heimatlocator.Text, ziellocator.Text);
            
            
            // Heimatlocator aus dem Textfeld
            string heimatLocator = heimatlocator.Text;

            // Koordinaten vom Lacator aus dem Textfeld des Heimatlocators
            LatLng heimatkoordinaten = MaidenheadLocator.LocatorToLatLng(heimatlocator.Text);
            LatLng zielkoordinaten = MaidenheadLocator.LocatorToLatLng(ziellocator.Text);

            // Breite/Länge in Locator konvertieren
            string myLoc = MaidenheadLocator.LatLngToLocator(52.41, 12.55);

            tbRichtung.Text = Math.Round(double.Parse(richtung.ToString()),2).ToString() +" °";
            tbEntfernung.Text = Math.Round(double.Parse(entfernung.ToString()),2).ToString() + " km";
           // tbKoordinaten.Text = heimatkoordinaten.ToString();
           // tbHeimatlocator.Text = heimatLocator.ToString();
            lblZielKoordinaten.Text = zielkoordinaten.ToString();
            lblEigeneKoordinaten.Text = heimatkoordinaten.ToString();
        }

        #region alte einträge
        // Zwei Locatorangaben definieren
        //    string homeLoc = "JO62GK";
        //    string destLoc = "JO63GJ";
        // Entfernung [km] und Richtung [°] berechnen
        //    double distance = MaidenheadLocator.Distance(homeLoc, destLoc);
        //    double azimuth = MaidenheadLocator.Azimuth(homeLoc, destLoc);

        // Locator in Breite/Länge konvertieren
        //     LatLng homeLL = MaidenheadLocator.LocatorToLatLng(homeLoc);
          //string myLoc = MaidenheadLocator.LatLngToLocator(49.57, 11.08);

        #endregion

        #region Leer
        private void homeLoc_TextChanged(object sender, EventArgs e)
        {
        }

        private void destLoc_TextChanged(object sender, EventArgs e)
        {
        }

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
        #endregion
    }
}
