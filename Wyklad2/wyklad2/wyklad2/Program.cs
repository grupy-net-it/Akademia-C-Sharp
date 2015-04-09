using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTesting
{
    class Enemy
    {
        public int health = 100;
        public int armor = 10;
        public int damage = 16;
    }

    abstract class Player
    {
        protected int health;
        public string name { get; set; }
        //Metody czysto wirtualne w C#
        protected virtual int damageCount() { return 0; }

        public void attack(Enemy enemy)
        {
            enemy.health -= (damageCount() - enemy.armor);
            this.health -= enemy.damage;
        }
    }

    class Warrior : Player
    {
        protected int rage;
        protected override int damageCount()
        {
            return 20;
        }
    }

    class Wizard : Player
    {
        protected int mana;
        protected override int damageCount()
        {
            return 10;
        }
    }

    class Thief : Player
    {
        protected int energy;
        protected override int damageCount()
        {
            return 15;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Thief player = new Thief();
            Enemy enemy = new Enemy();
            player.attack(enemy);
            System.Console.WriteLine(enemy.health);
            player.name = System.Console.ReadLine();
            System.Console.WriteLine(player.name);

        }
    }
}

