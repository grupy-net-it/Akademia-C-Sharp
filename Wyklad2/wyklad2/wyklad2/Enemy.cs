using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2
{
    class Enemy
    {
        public int health = 100;
        public int armor = 10;
        public int damage = 16;

        public void attackBack(Player player)
        {
            player.health -= 10;
        }
    }
}
