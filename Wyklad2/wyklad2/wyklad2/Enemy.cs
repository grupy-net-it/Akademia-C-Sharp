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

        protected int health;
        protected int armor;
        protected int damage;

        public void Attack(Player player)
        {
            player.Defend(damage);
            player.Attack(this);
        }

        public void Defend(int damageOutput)
        {
            if((damageOutput-armor)>0)
            {
                this.health -=( damageOutput - armor);
            }
        }
    }
}
