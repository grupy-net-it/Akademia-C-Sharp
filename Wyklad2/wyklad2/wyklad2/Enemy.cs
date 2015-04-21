using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2
{
    class Enemy
    {
        public Enemy()
        {
            this.health = 100;
            this.armor = 10;
            this.damage = 40;
        }

        public int health { get; public set; }
        public int armor { get; public set; }
        public int damage { get; public set; }

        public void attack(Player player)
        {
            player.defend(damage);
        }

        public void defend(int damageOutput)
        {
            this.health -=( damageOutput - armor);
        }
    }
}
