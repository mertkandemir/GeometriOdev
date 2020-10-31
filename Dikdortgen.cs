using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdev
{
    class Dikdortgen : IDortgen
    {
        public double UzunKenar { get; set; }
        public double KisaKenar { get; set; }

        public double AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }

        public double CevreHesapla()
        {
            return (KisaKenar + UzunKenar) * 2;
        }
    }
}
