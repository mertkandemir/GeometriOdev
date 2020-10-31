using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdev
{
    class DikUcgen : IUcgen
    {
        private IUcgen _ucgenImplementation;
        public double Yukseklik { get; set; }
        public double TabanKenar { get; set; }

        public double CevreHesapla()
        {
            double Hipotenus = Math.Sqrt(Math.Pow(TabanKenar, 2) + Math.Pow(Yukseklik, 2));
            return Hipotenus + Yukseklik + TabanKenar;
        }

        public double AlanHesapla()
        {
            return (TabanKenar * Yukseklik) / 2;
        }
    }
}
