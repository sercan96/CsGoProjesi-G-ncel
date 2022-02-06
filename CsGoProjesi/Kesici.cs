using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CsGoProjesi
{
    abstract class Kesici
    {
        public string ismi { get; set; }
        public string model { get; set; }
        public int fiyat { get; set; }
        public double uzunluk { get; set; }
        public int agirlik { get; set; }
        public string sekli { get; set; }
        public int garantiSuresi { get; set; }


        public Kesici(string Ismi,string Model,int Fiyat,double Uzunluk,int Agirlik,int GarantiSuresi)
        {
            this.ismi = Ismi;
            this.model = Model;
            this.fiyat = Fiyat;
            this.uzunluk = Uzunluk;
            this.agirlik = Agirlik;
            this.garantiSuresi = GarantiSuresi;
        }
        public void Ses(string Path) 
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Path;
            player.Play();
        }



    }
}
