using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UebungOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bKreis_Click(object sender, EventArgs e)
        {
            double dRadius = Convert.ToDouble(tbRadius.Text);

            KreisMathe EinKreis = new KreisMathe(dRadius);
            EinKreis.UmfangBerechnen();

            KreisAnzeige EinKreisAnzeige = new KreisAnzeige(pbZeichenflaeche, dRadius, EinKreis.dKreisUmfang);
            EinKreisAnzeige.KreisZeichnen();
            EinKreisAnzeige.UmfangSchreiben();
           
        }

        private void bZufallKreis_Click(object sender, EventArgs e)
        {
            int iAnzahl = Convert.ToInt32(tbAnzahl.Text);
            int iRadiusVar = Convert.ToInt32(tbRadiusVar.Text);

            Random rZufall = new Random();
            int iRadiusGewuerfelt = 0;  

            for (int i = 0; i < iAnzahl; i++)
            {
                iRadiusGewuerfelt = rZufall.Next(1, iRadiusVar);

                KreisMathe ZufallsKreis = new KreisMathe(iRadiusGewuerfelt);
                ZufallsKreis.UmfangBerechnen();

                KreisAnzeige ZufallsKreisAnzeige = new KreisAnzeige(pbZeichenflaeche, iRadiusGewuerfelt, ZufallsKreis.dKreisUmfang);
                ZufallsKreisAnzeige.KreisZufaelligZeichnen();

                if (chUmfang.Checked)
                {
                    ZufallsKreisAnzeige.UmfangSchreiben();
                }     
                

            }

        }
    }
}
