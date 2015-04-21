using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyklad2
{
    abstract class Player
    {
        public int health;
        public int baseArmor;
        public int baseDamage;
        public string name { get; set; }
        public Weapon equippedWeapon;

        public void attack(Enemy enemy)
        {
            enemy.defend(baseDamage+equippedWeapon.damage);
        }

        public void defend(int damageOutput)
        {
            this.health -= (damageOutput - -baseArmor);
        }

        public delegate void Action(Enemy enemy);

        public Action action;

        public void equipWeapon(Weapon weapon)
        {
           equippedWeapon = weapon;
        }
        public void attack(Enemy enemy)
        {
            enemy.health -= (damageCount() - enemy.armor);
            Console.WriteLine("Trafiono normalnie");
            enemy.attack(this);
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
