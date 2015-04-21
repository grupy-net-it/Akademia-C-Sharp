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
       protected Weapon equippedWeapon;
       public string name { get; set; }
  
        public void attack(Enemy enemy)
        {
            enemy.defend(baseDamage + equippedWeapon.damage);
            Console.WriteLine("Trafiono normalnie");
            enemy.attack(this);
        }
        public void kick(Enemy enemy)
        {
            enemy.defend(5);
            Console.WriteLine("Trafiono z buta w twarz");
        }

        public void punch(Enemy enemy)
        {
            enemy.defend(10);
            Console.WriteLine("Trafiono pięścią");
        }

        public void defend(int damageOutput)
        {
            if ((damageOutput - baseArmor) > 0)
            {
                this.health -= (damageOutput -baseArmor);
            }
        }

        public void equipWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
        }

        public delegate void Action(Enemy enemy);
        public Action action;

     
       
    }
}
