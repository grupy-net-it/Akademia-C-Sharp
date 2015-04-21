using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2.types
{
    class Wizard : Player
    {
        public Wizard()
        {
            this.health = 80;
            this.baseArmor = 10;
            this.mana = 100;
            this.baseDamage = 30;
        }

        protected int mana;

    }
}
