using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGoProjesi
{
    class KF1500 : Atesli
    {
        public KF1500() : base("KF1500", 1, 9.45, "Kahverengi", 65.8f, 150, false) {}
       
        public override void AtesEt()
        {
            Ses(@"..\..\..\Sesler\TopAtis.wav");
            RastgeleOlme(6);
        }
        public void KF_Reload(int mermi)
        {
            Ses(@"..\..\..\Sesler\Taramali2.wav");
            mermiSayisi = mermi;
        }
    }

    
}
