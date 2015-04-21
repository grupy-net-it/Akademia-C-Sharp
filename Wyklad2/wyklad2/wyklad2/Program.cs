using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wyklad2.types;

namespace wyklad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thief player = new Thief();
            Enemy mountain = new Enemy();

            // player.action(mountain) += player.punch;

            player.action += player.punch;
            player.action += player.kick;
            player.action += player.attack;
            player.action += player.kick;

            player.action -= player.kick;

            player.action(mountain);

            Console.WriteLine(mountain.health);
            player.name = Console.ReadLine();
            Console.WriteLine(player.name);
            Thief player = new Thief("Janusz");
            Enemy enemy = new Enemy();
            Weapon bron = new Weapon(12, 5);

            player.EquipWeapon(bron);
            player.Attack(enemy);
            enemy.Attack(player);
        }
    }
}

