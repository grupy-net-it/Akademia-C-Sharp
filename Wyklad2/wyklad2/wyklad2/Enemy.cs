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

        protected int health { get; set; }
        protected int armor { get; set; }
        protected int damage { get; set; }

        public void Attack(Player player)
        {
            player.Defend(damage);
        }

        public void Defend(int damageOutput)
        {
            this.health -=( damageOutput - armor);
        }
    }
}
