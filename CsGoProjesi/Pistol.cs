using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGoProjesi
{
    class Pistol : Atesli
    {
        private string Marka;
        public Pistol(string Marka) : base("Pistol", 4, 7.2,"kırmızı",1.1f,25,false)
        {
            this.Marka = Marka;
        }

        public void AtesEt()
        {
            Random olasilik = new Random();
            int rastgele = olasilik.Next(2, 20);
            if (rastgele < 4)
            {
                Ses(@"..\..\..\Sesler\scream.wav");
                MessageBox.Show("Öldünüz");
            }
            else
            {
                if (mermiSayisi == 0)
                {
                    MessageBox.Show("Merminiz yok");
                }
                else
                {
                    mermiSayisi--;
                    Ses(@"..\..\..\Sesler\Tabanca.wav");
                }
            }
        }
        public void P_Reload(int mermi)
        {
            Ses(@"..\..\..\Sesler\Silah2.wav");
            mermiSayisi = mermi;
        }
    }
}
