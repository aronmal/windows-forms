using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiderholungKlausur
{
    public partial class Form1 : Form
    {
        uint[] iZufallszahl = new uint[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint iMinimum = 0;
            uint iMaximum = 0;
            

            TextBox[] tbZufallszahlen = { textBoxZahl1Zufall,textBoxZahl2Zufall,textBoxZahl3Zufall };

            Random rZufall = new Random();


            try
            {
                iMinimum = Convert.ToUInt32(textBoxMinimumZahl.Text);
                iMaximum = Convert.ToUInt32(textBoxMaximumZahl.Text);

               

            }
            catch (System.FormatException)
            {

                MessageBox.Show("Bitte geben Sie ganze Zahlen ein");
            }
            catch (System.OverflowException) 
            {
                MessageBox.Show("Bitte geben Sie positive Zahlen ein");

            }

            for (int i = 0; i < iZufallszahl.Length; i++)
            {
                iZufallszahl[i] = Convert.ToUInt32(rZufall.Next((int)iMinimum, (int)iMaximum + 1));
                // forschleife für Doppler
                
                
                tbZufallszahlen[i].Text = iZufallszahl[i].ToString();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sortieren wie mit Bubblesort auf globalem Array
        }

        private void appBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
