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
            //Zeile 3
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                MessageBox.Show(C1.Text);
                bGewinner = true;
                Tastensperre();
            }
            //Spalte 1
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
            {
                MessageBox.Show(A1.Text);
                bGewinner = true;
                Tastensperre();
            }
            //Spalte 2
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
            {
                MessageBox.Show(A2.Text);
                bGewinner = true;
                Tastensperre();
            }
            //Spalte 3
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
            {
                MessageBox.Show(A3.Text);
                bGewinner = true;
                Tastensperre();
            }
            //Diagonale von oben links nach unten rechts
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                MessageBox.Show(A1.Text);
                bGewinner = true;
                Tastensperre();
            }
            //Diagonale von oben rechts nach unten links
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
            {
                MessageBox.Show(A3.Text);
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
            Button[] bButtons = {A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            
            for (int i = 0; i < bButtons.Length; i++)
            {                
                bButtons[i].Enabled = false;
            }

        }
    }
}
