using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2.types
{
    class Warrior : Player
    {
        public Warrior()
        {
            this.health = 100;
            this.baseArmor = 20;
            this.rage = 0;
            this.baseDamage = 20;
        }

        protected int rage;

    }
}
