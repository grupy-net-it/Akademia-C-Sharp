using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2
{
    abstract class Player
    {
        protected int health;
        public string name { get; set; }
        //Metody czysto wirtualne w C#
        protected virtual int damageCount() { return 0; }

        public void attack(Enemy enemy)
        {
            enemy.health -= (damageCount() - enemy.armor);
            this.health -= enemy.damage;
        }
    }
}
