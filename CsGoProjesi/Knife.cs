using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoProjesi
{
    class Knife :Kesici
    {
        public string sekli { get; set; }
        public Knife(string Sekli):base("Şef Bıçağı", "VG-10",750,11.5,100,12)
        {
            this.sekli = Sekli;
        }

    }
}
