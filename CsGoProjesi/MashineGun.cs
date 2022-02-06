using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGoProjesi
{
    class MashineGun : Atesli
    {
        public string AteslemeTuru { get; set;} //seri  

        public MashineGun(string AteslemeTurum) : base("Mashine Gun",5,7.62,"Sarı",2.265f,74,true)
        {
            this.AteslemeTuru = AteslemeTurum;
        }
        public override void AtesEt()
        {
            Ses(@"..\..\..\Sesler\Taramali.wav");
            RastgeleOlme(5);
        }
        public override void Reload(int mermi)
        {
            Ses(@"..\..\..\Sesler\Taramali2.wav");
            mermiSayisi = mermi;

        }
    }
}
 
