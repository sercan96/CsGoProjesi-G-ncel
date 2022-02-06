using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGoProjesi
{
    class ShotGun : Atesli
    {
        public ShotGun() : base("Shot Gun", 10, 6.40, "Siyah", 2.265f, 42, false) { }

        public void AtesEt()
        {
            Random olasilik = new Random();
            int rastgele = olasilik.Next(2, 20);
            if (rastgele < 2)
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
        public void S_Reload(int mermi)
        {
            Ses(@"..\..\..\Sesler\PompaliSarjor.wav");
            mermiSayisi = mermi;
        }

    }
}
