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


            //Zur Anschauung für die Klausur
            //Zufallszahlen
            Random rdnZufallsgenerator = new Random();
            int iZahl = rdnZufallsgenerator.Next(1, 50);
            MessageBox.Show(iZahl.ToString());

            //Verarbeiten von Tags
            int iTag = Convert.ToInt32(bButton.Tag);



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

            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text !="")
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


            if (bGewinnerStehtFest && bZug == true)
            {
                MessageBox.Show("Spieler X hat gewonnen");
                ButtonDisablen();
            }
            else if (bGewinnerStehtFest && bZug == false)
            {
                MessageBox.Show("Spieler O hat gewonnen");
                ButtonDisablen();
            }
       
           
        }

        private void neustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hausaufgabe

            //Zurücksetzen der globalen Variablen
            bZug = true; 
         
            Button[] bButtonArray = { A1, A2, A3, B1, B2, B3, C1, C2, C3 };

            for (int i = 0; i < bButtonArray.Length; i++)
            {
                bButtonArray[i].Enabled = true;
                bButtonArray[i].Text = "";
            }
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

    }
}
