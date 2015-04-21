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

        public delegate void Action(Enemy enemy);

        public Action action;

        public void EquipWeapon(Weapon weapon)
        {
           equippedWeapon = weapon;
        }
        public void attack(Enemy enemy)
        {
            enemy.health -= (damageCount() - enemy.armor);
            Console.WriteLine("Trafiono normalnie");
            enemy.attackBack(this);
        }

        public void kick(Enemy enemy)
        {
            enemy.health -= 5;
            Console.WriteLine("Trafiono z buta w twarz");
        }

        public void punch(Enemy enemy)
        {
            enemy.health -= 10;
            Console.WriteLine("Trafiono pięścią");
        }
    }
}
