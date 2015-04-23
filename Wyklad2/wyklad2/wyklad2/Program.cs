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
            ////At start
            //HelloWorld helloWorld = new HelloWorld();

            //helloWorld.SetSomeValue(5);
            Thief player = new Thief();
            player.name = "Jon Snow";
            Enemy enemy = new Enemy();
            Weapon bron = new Weapon(12, 5);

            player.EquipWeapon(bron);

            player.Death += player_Death;

            player.action += player.Attack;
            player.action += player.Kick;

            player.action(enemy);
            player.inventory.Add(bron);
            Console.ReadKey();
        }

        static void player_Death(string message)
        {
            Console.WriteLine("Gracz nie żyje");
        }
    }
}
