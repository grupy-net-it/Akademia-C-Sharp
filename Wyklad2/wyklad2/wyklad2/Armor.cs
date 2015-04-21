using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2
{
    class Armor: Item
    {
        public Armor(int protection,int weight)
        {
            this.name = "Pancerz";
            this.weight = weight;
            this.protection = protection;
        }
        public int protection { get; private set; }
    }
}
