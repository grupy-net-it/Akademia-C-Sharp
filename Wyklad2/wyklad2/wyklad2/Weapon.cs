using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2
{
    class Weapon: Item
    {
        public Weapon (int damage,int weight)
        {
            this.name = "Broń";
            this.weight = weight;
            this.damage = damage;
        }
        public int damage;
    }
}
