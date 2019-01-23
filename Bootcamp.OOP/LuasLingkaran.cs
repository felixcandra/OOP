using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class LuasLingkaran : Bangun2D
    {
        private double jarijari;

        public LuasLingkaran(double j)
        {
            this.jarijari = j;
        }

        public override double HitungLuas()
        {
            return (3.14 * jarijari * jarijari);
        }
    }
}
