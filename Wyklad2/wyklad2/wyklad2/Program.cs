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
            Enemy enemy = new Enemy();
            player.attack(enemy);
            System.Console.WriteLine(enemy.health);
            player.name = System.Console.ReadLine();
            System.Console.WriteLine(player.name);
        }
    }
}

