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
        public string name { get; set; }
        //Metody czysto wirtualne w C#
        protected virtual int damageCount() { return 0; }

        public delegate void Action(Enemy enemy);

        public Action action;

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
