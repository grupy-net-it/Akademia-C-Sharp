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
  
        public void Attack(Enemy enemy)
        {
            enemy.Defend(baseDamage + equippedWeapon.damage);
            Console.WriteLine("Trafiono normalnie");
            enemy.Attack(this);
        }
        public void Kick(Enemy enemy)
        {
            enemy.Defend(5);
            Console.WriteLine("Kołowrotek");
        }

        public void Punch(Enemy enemy)
        {
            enemy.Defend(10);
            Console.WriteLine("Luj ogłuszacz");
        }

        public void Defend(int damageOutput)
        {
            if ((damageOutput - baseArmor) > 0)
            {
                this.health -= (damageOutput -baseArmor);
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
        }

        public delegate void Action(Enemy enemy);
        public Action action;

     
       
    }
}
