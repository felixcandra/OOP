using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class LuasPersegiPanjang : Bangun2D
    {
        private double panjang;
        private double lebar;

        public LuasPersegiPanjang(double p, double l)
        {
            this.panjang = p;
            this.lebar = l;
        }

        public override double HitungLuas()
        {
            return (panjang*lebar);
        }
    }

}
