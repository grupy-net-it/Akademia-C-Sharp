﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2.types
{
    class Thief : Player
    {
        public Thief()
        {
            this.health = 90;
            this.baseArmor = 15;
            this.energy = 100;
            this.baseDamage = 25;
        
        }

        protected int energy;

    }
}





