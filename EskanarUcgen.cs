using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriOdev
{
    class EskanarUcgen : IUcgen
    {
        public double TabanKenar { get; set; }

        public double CevreHesapla()
        {
            return  TabanKenar * 3;
        }

        public double AlanHesapla()
        {
            return (TabanKenar * TabanKenar) * Math.Sqrt(3) / 4;
        }
    }
}
