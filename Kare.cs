using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdev
{
    class Kare : IDortgen
    {
        public double UzunKenar { get; set; }

        public double AlanHesapla()
        {
            return UzunKenar * UzunKenar;
        }

        public double CevreHesapla()
        {
            return (UzunKenar + UzunKenar) * 2;
        }
    }
}
