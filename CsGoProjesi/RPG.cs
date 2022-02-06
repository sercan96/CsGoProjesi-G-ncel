using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGoProjesi
{
    class RPG : Atesli
    {
        public string muhimmati { get; set; }


        public RPG(string Muhimmat) : base("RPG", 2, 8.12, "Mavi", 45.8f, 120, false)
        {
            this.muhimmati = Muhimmat;
        }
        public void AtesEt()
        {
            Random olasilik = new Random();
            int rastgele = olasilik.Next(2, 20);
            if (rastgele < 3)
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
                    Ses(@"..\..\..\Sesler\Pompali.wav");
                }
            }
        }
        public void RPG_Reload(int mermi)
        {
            Ses(@"..\..\..\Sesler\PompaliSarjor.wav");
            mermiSayisi = mermi;
        }

    }
}
