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
            TextBox[] tbLottoZiehung = { Ausgabe1, Ausgabe2, Ausgabe3, Ausgabe4, Ausgabe5, Ausgabe6 };

            // Für die positiven ganzen Zahlen unserer Lottotipp Eingabe
            UInt32[] iLottotipp = new UInt32[6];

            for (int i = 0; i < tbLottotipp.Length; i++)
            {
                tbLottotipp[i].BackColor = Color.White;
            }

            for (int i = 0; i < iLottotipp.Length; i++)
            {
                try
                {
                    iLottotipp[i] = Convert.ToUInt32(tbLottotipp[i].Text);                                  

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Bitte als Tipp nur positive Zahlen (1-49) ein!");
                    tbLottotipp[i].BackColor = Color.Red;
                   
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("Bitte nur positive Zahlen eingeben!");
                    tbLottotipp[i].BackColor = Color.Red;
                    
                }

            }

                       


            for (int i = 0; i < tbLottoZiehung.Length; i++)
            {
                tbLottoZiehung[i].Text = tbLottotipp[i].Text;
            }





        }
    }
}
