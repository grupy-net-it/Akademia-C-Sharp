using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2.types
{
    class Warrior : Player
    {
        protected int rage;
        protected override int damageCount()
        {
            return 20;
        }
    }
}
