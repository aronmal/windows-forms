using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_IV_TI_G21
{
    public partial class Form1 : Form
    {
        int iZug = 0; //globale Variable
        bool bZug = true; //true => x; false => o
        int iZugZaehler = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Spiel_Event(object sender, EventArgs e)
        {
            
            // x und o drauf schreiben - abwechselnd
            // Gewinner ermittelt
            // Deaktivieren des Buttons, wenn er einmal geklickt wurde

            Button bButton = (Button)sender;

            bButton.Text = "x";

           //Tertiäre Opertor: Bedingung ? Konsequenz : Alternative
            bButton.Text = bZug ? "x" : "o";
            bZug = !bZug;
            iZugZaehler++;
            bButton.Enabled = false;
            ErmittelGewinner();



        }


        public void ErmittelGewinner() 
        {
            
            bool bGewinner = false;

            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                MessageBox.Show(A1.Text);
                bGewinner = true;
                Tastensperre();
            }
            else if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                MessageBox.Show(A1.Text);
                bGewinner = true;
                Tastensperre();
            }

            if (iZugZaehler == 9 && bGewinner == false)
            {
                MessageBox.Show("unentschieden");

            }

        }

        public void Tastensperre() 
        {
            
            int[] aNochMehrZahlen = {1,2, 3, 4, 5,6, 7, 8, 9 };

            Button[] bButtons = {A1, A2, A3 };
            
            for (int i = 0; i < bButtons.Length; i++)
            {                
                bButtons[i].Enabled = false;
            }

        }
    }
}
