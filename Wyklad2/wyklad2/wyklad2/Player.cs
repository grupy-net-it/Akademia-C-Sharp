using System;
using System.Collections.Generic;

namespace wyklad2
{
    internal abstract class Player
    {
        protected int health;
        protected int baseArmor;
        protected int baseDamage;
        protected Weapon equippedWeapon;

        public Player()
        {
            this.Inventory = new List<Item>();
        }

        public string Name { get; set; }
        public List<Item> Inventory { get; set; }

        public delegate void DeathEventHandler(string message);

        // Użycie domyślnego delegata EventHandler
        //public event EventHandler Died;

        public event DeathEventHandler Died;

        public delegate void ActionEventHandler(Enemy enemy);
        public ActionEventHandler ActionOccurred;

        public void onDeath()
        {
            if (Died != null)
            {
                //Użycie domyślnego delegata EventHandler
                //Died(this,new Args());

                Died(this.Name + " umar");
            }
        }

        public void Attack(Enemy enemy)
        {
            enemy.Defend(baseDamage + equippedWeapon.Damage);
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
                this.health -= (damageOutput - baseArmor);
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
        }
    }
}
