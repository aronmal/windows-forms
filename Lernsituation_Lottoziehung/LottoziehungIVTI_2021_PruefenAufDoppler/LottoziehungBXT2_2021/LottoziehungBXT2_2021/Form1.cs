using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoziehungBXT2_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLottoziehung_Click(object sender, EventArgs e)
        {
            
            TextBox[] tbLottotipp = { Eingabe1, Eingabe2, Eingabe3, Eingabe4, Eingabe5, Eingabe6 };
            TextBox[] tbLottoZiehung = { Ausgabe1, Ausgabe2, Ausgabe3, Ausgabe4, Ausgabe5, Ausgabe6};

            // Für die positiven ganzen Zahlen unserer Lottotipp Eingabe
            UInt32[] iLottotipp = new UInt32[6];


            #region Prüfung des Tipps
            for (int i = 0; i < iLottotipp.Length; i++)
            {
                tbLottotipp[i].BackColor = Color.White;
                try
                {
                    iLottotipp[i] = Convert.ToUInt32(tbLottotipp[i].Text);
                    
                    if (iLottotipp[i] > 49 || iLottotipp[i] <1 )
                    {
                        MessageBox.Show("Bitte nur Zahlen zwischen 1 und 49 eingeben");
                        tbLottotipp[i].BackColor = Color.Red;
                        return; //Bricht die Schleife ab, damit der Nutzer noch einmal die Zahl eingeben kann, bevor die
                                // Schleife für die anderen Zahlen weiter durchlaufen wird.
                    }

                }
                catch (System.FormatException) //fängt system-Fehler, wenn der Nutzer strings, chars und double eingegeben hat
                {
                    MessageBox.Show("Bitte als Tipp nur positive Zahlen (1-49) ein!");
                    tbLottotipp[i].BackColor = Color.Red;
                    return;
                   
                }
                catch (System.OverflowException) //fängt system-Fehler, wenn negative Zahlen eingegeben werden
                                                 // das das 32 Bit kein Vorzeichen- Bit ist
                {
                    MessageBox.Show("Bitte nur positive Zahlen eingeben!");
                    tbLottotipp[i].BackColor = Color.Red;
                    return;
                }

            }

            //Prüfen von Dopplern
            for (int i = 0; i < iLottotipp.Length-1; i++)
            {
                for (int j = i+1; j < iLottotipp.Length; j++)
                {
                    if (iLottotipp[i] == iLottotipp[j])
                    {
                        MessageBox.Show("Bitte keine doppelte Zahl in Feld "+ (j+1) + " eintragen!");
                        tbLottotipp[j].BackColor = Color.Red;
                        return;
                    }
                }

            }

            #endregion

            for (int i = 0; i < tbLottoZiehung.Length; i++)
            {
                tbLottoZiehung[i].Text = tbLottotipp[i].Text;
            }





        }
    }
}
