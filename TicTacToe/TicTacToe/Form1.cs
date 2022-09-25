using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool bZug = true; // X ist am Zug, wenn true; O ist am Zug wenn false
        private void SpielZugClick(object sender, EventArgs e)
        {
            

            if (sender.GetType() != typeof(Button))
            {
                return;
            }
            Button bButton1 = (Button)sender;

            /*
            if (bZug == false)
            {
                bButton1.Text = "O";
            }
            else
            {
                bButton1.Text = "X";               
            }
            */

            bButton1.Text = bZug ? "X" : "O";
            ErmittelGewinner();

            bButton1.Enabled = false;

            bZug = !bZug; //Aus true wird false im Wechsel           
        }

        void ButtonDisablen()
        {
            //int[] iZahlenarray = new int[6];
            Button[] bButtonArray = { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            for (int i = 0; i < bButtonArray.Length; i++)
            {
                bButtonArray[i].Enabled = false; 
            }
        }

        void ErmittelGewinner()

        {
            bool bGewinnerStehtFest = false;

            //Horizontal

            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") 
            {
                bGewinnerStehtFest = true;
            }

            if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            //Diagonal

            if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            //Vertikal

            if (A1.Text == B1.Text && C1.Text == A1.Text && A1.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            if (A2.Text == B2.Text && C2.Text == A2.Text && A2.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            if (A3.Text == B3.Text && C3.Text == A3.Text && A3.Text != "")
            {
                bGewinnerStehtFest = true;
            }


            if (bGewinnerStehtFest && bZug == true)
            {
                MessageBox.Show("Der Spieler X hat gewonnen!");
                ButtonDisablen();            
            }
            else if (bGewinnerStehtFest && bZug == false)
            {
                MessageBox.Show("Der Spieler O hat gewonnen!");
                ButtonDisablen();
            }
        }

        private void neustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
