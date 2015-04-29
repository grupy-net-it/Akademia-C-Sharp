using System;
using wyklad2.PlayerClasses;

namespace wyklad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////At start
            //HelloWorld helloWorld = new HelloWorld();
            //helloWorld.SetSomeValue(5);

            Thief player = new Thief();
            player.Name = "Jon Snow";

            Enemy enemy = new Enemy();
            Weapon weapon = new Weapon(12, 5);

            player.EquipWeapon(weapon);

            player.Died += OnPlayerDied;

            player.ActionOccurred += player.Attack;
            player.ActionOccurred += player.Kick;

            player.ActionOccurred(enemy);
            player.Inventory.Add(weapon);
            Console.ReadKey();
        }

        static void OnPlayerDied(string message)
        {
            Console.WriteLine("Gracz nie żyje");
        }
    }
}
