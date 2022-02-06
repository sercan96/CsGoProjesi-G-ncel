using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGoProjesi
{
    abstract class Atesli
    {

        public string silahIsmi { get; set; }
        public int mermiSayisi { get; set; }
        public double mermiTipi { get; set; }
        public string rengi { get; set; }
        public float agirlik { get; set; }
        public int uzunluk { get; set; }
        public bool durbunluMu { get; set; }


        public Atesli(string silahısmi, int mermisayisi, double mermitipi, string Rengi, float Agirlik, int Uzunluk, bool DurbunluMu)
        {
            this.silahIsmi = silahısmi;
            this.mermiSayisi = mermisayisi;
            this.agirlik = Agirlik;
            this.uzunluk = Uzunluk;
            this.durbunluMu = DurbunluMu;
        }

        public void Ses(string Path) // Bir fonksiyonu parametreli olarak her yerde kullanabiliyoruz.
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Path;
            player.Play();
        }
        public virtual void AtesEt()
        {
            Ses("");
            mermiSayisi--; 

        }
        public virtual void Reload(int mermi)
        {
            Ses("");
            mermiSayisi = mermi;
        }
        public virtual void RastgeleOlme(int deger)
        {
            Random olasilik = new Random();
            int rastgele = olasilik.Next(2, 20);
            if (rastgele < deger)
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
                }
            }

        }
    }
}
