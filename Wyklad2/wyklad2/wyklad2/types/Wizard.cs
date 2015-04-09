using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2.types
{
    class Wizard : Player
    {
        protected int mana;
        protected override int damageCount()
        {
            return 10;
        }
    }
}
