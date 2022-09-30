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

        bool bZug = true; // X ist am Zug, wenn true; O ist am Zug, wenn false
        int iCounter = 1;
        int iGewinnerCountX = 0;
        int iGewinnerCountO = 0;
        private void SpielzugClick(object sender, EventArgs e)
        {
            //ButtonDisablen();
            //int iGanzahl = (int)2.5;
            if (sender.GetType() != typeof(Button))
            {
                return;
            }
            Button bButton = (Button)sender;

            /*
            if (bZug == false)
            {
                bButton.Text = "O";
                bZug = true;
            }
            else
            { 
                bButton.Text = "X";
                bZug = false;
            }
            */



            bButton.Text = bZug ? "X" : "O";
            ErmittelGewinner();
            bButton.Enabled = false;
            bZug = !bZug;
            iCounter++;

            //Klausur 
            //Zufallszaheln 
            //Random rndZufallszahlen = new Random();
            //int iZahl = rndZufallszahlen.Next(1, 50);
            //MessageBox.Show(iZahl.ToString());


            //Verarbeiten Tag 
            //int iTag = Convert.ToInt32(bButton.Tag);

        }

        /*
        int HalloMethodenwelt(int TestZahl) 
        {
            int iErgebnis = TestZahl * 2;
            MessageBox.Show("Ich wurde von einer Methode erzeugt");
            MessageBox.Show($"Es wurde die folgende Testzahl übergeben : {TestZahl}");

            return iErgebnis;
        }
        */

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

            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
            {
                bGewinnerStehtFest = true;
            }
            else if (C1.Text == B2.Text && B2.Text == A3.Text && C1.Text != "")
            {
                bGewinnerStehtFest = true;
            }

            if (bGewinnerStehtFest == false && iCounter == 9)
            {
                MessageBox.Show("Patt");
                ButtonDisablen();
                iCounter = 0;
            }

            if (bGewinnerStehtFest && bZug == true)
            {
                MessageBox.Show("Spieler X hat gewonnen");
                ButtonDisablen();
                iCounter = 0;
                iGewinnerCountX++;
            }
            else if (bGewinnerStehtFest && bZug == false)
            {
                MessageBox.Show("Spieler O hat gewonnen");
                ButtonDisablen();
                iCounter = 0;
                iGewinnerCountO++;
            }
        }

        void Restart()
        {
            bZug = true; //Zurücksetzen der globalen Variablen führt dazu, dass X wieder anfängt

            Button[] bButtonArray = { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            for (int i = 0; i < bButtonArray.Length; i++)
            {
                bButtonArray[i].Enabled = true;
                bButtonArray[i].Text = "";
            }
            iCounter = 0;
        }


        private void neustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hausaufgabe
            Application.Exit();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dieses Event muss noch geschrieben werden
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = (iGewinnerCountX.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = (iGewinnerCountO.ToString());
        }
    }
}
