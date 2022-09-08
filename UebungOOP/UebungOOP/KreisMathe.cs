using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungOOP
{
    class KreisMathe
    {
        internal double dKreisUmfang = 0;
        double dPi = 3.14159265358979323846;
        double dRadius = 0;


        internal KreisMathe(double Radius)
        {
            this.dRadius = Radius;
        }


        internal void UmfangBerechnen()
        {
            dKreisUmfang = Math.Round(2 * dPi * dRadius,1);            
        }
    }
}
