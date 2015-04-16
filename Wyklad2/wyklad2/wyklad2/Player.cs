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
        protected int baseArmor;
        protected int baseDamage;
        public string name { get; set; }
        protected Weapon equippedWeapon;

        public void Attack(Enemy enemy)
        {
            enemy.Defend(baseDamage+equippedWeapon.damage);
        }

        public void Defend(int damageOutput)
        {
            this.health -= (damageOutput - -baseArmor);
        }

        public void EquipWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
        }
    }
}
