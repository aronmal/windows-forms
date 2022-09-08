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
    class KreisAnzeige
    {
       

        int iMitteX = 0;
        int iMitteY = 0;
        int iRadius = 0;
        int iVektorX = 0;
        int iVektorY = 0;
        string sUmfang = " ";

        PictureBox pbBox;
        Graphics gPlot;

        internal KreisAnzeige(PictureBox Box, double dRadius, double dUmfang)
        {
            this.pbBox = Box;
            gPlot= pbBox.CreateGraphics();
            iRadius = (int)dRadius;
            sUmfang = dUmfang.ToString();
           
        }


        void MittenBerechnen()
        {
            iMitteX =(int)(pbBox.Width / 2);
            iMitteY = (int)(pbBox.Height / 2);

        }


        internal void KreisZeichnen()
        {
            MittenBerechnen();
            Pen pStift = new Pen(Color.Black);
            
            gPlot.DrawEllipse(pStift, iMitteX, iMitteY, iRadius, iRadius);

        }

        internal void KreisZufaelligZeichnen()
        {
            MittenBerechnen();
            Pen pStift = new Pen(Color.Black);
            Random rZufaellig = new Random();
            iVektorX = rZufaellig.Next(-pbBox.Width/2, pbBox.Width / 2);
            iVektorY = rZufaellig.Next(-pbBox.Height / 2, pbBox.Height / 2);
            
            gPlot.DrawEllipse(pStift, iMitteX+ iVektorX, iMitteY+ iVektorY, iRadius, iRadius);
            System.Threading.Thread.Sleep(500);

          
        }


        internal void UmfangSchreiben()
        {
            Font drawFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            MittenBerechnen();
            gPlot.DrawString(sUmfang, drawFont, drawBrush, iMitteX+ iVektorX, iMitteY+ iVektorY);

        }
        

            







    }
}
