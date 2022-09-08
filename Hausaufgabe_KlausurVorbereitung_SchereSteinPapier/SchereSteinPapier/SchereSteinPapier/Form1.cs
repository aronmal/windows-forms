using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchereSteinPapier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SpielAusfuehren(object sender, EventArgs e)
        {
            Button bButton = new Button();
            bButton = (Button)sender;
            bool bGewinner = false;
            int iNutzerWahl =Convert.ToInt32(bButton.Tag);

            NutzerZug(iNutzerWahl);

            //ComputerZug();
            bGewinner=GewinnerErmitteln(ComputerZug(), iNutzerWahl);
           
            if (bGewinner) 
            {
                ButtonDeaktivieren();

            }
        }

        private void NutzerZug(int NutzerWahl) 
        {
            
            if (NutzerWahl ==1)
            {
                textBoxNutzerwahl.Text = "Deine Auswahl: Schere";
            }
            else if (NutzerWahl == 2)
            {
                textBoxNutzerwahl.Text = "Deine Auswahl: Stein";
            }
            else
            {
                textBoxNutzerwahl.Text = "Deine Auswahl: Papier";
            }

        }

        private int ComputerZug() 
        {
            Random rZufallszahlenGenerator = new Random();
            int iZahl = rZufallszahlenGenerator.Next(1, 4);


            if (iZahl == 1)
            {
                textBoxComputer.Text = "PC-Wahl: Schere";
            }
            else if (iZahl == 2)
            {
                textBoxComputer.Text = "PC-Wahl: Stein";
            }
            else
            {
                textBoxComputer.Text = "PC-Wahl: Papier";
            }


            return iZahl;
        }

        bool GewinnerErmitteln(int Computer, int Nutzer) 
        {
            bool bGewinner = false;
            if (Computer ==1 && Nutzer == 2)
            {
                textBoxGewinner.Text = "Du hast gewonnen!";
                bGewinner = true;
            }
            // HIER MÜSSEN DIE ANDEREN FÄLLE ERGÄNZT WERDEN

            return bGewinner;
        
        }

        void ButtonDeaktivieren() 
        {
            Button[] bButtons = { buttonSchere, buttonStein, button1 };

            for (int i = 0; i < bButtons.Length; i++)
            {
                bButtons[i].Enabled = false;
            }
        
        
        }

    }
}
