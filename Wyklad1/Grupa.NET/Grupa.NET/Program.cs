using System;

namespace Grupa.NET
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello World");

            int i = 1;
           float j = 2.4f;
            Console.Out.WriteLine(i + j);

            string a = "Ala ";
            string b = "ma ";
            string c = "kota";
            Console.Out.WriteLine(a + b + c);
            Console.Out.WriteLine(a);

            var x = 19;
            var y = "tutaj jest string!~";
            var z = Math.Cos(2.4);

            a=string.Concat(a,b);
            Console.Out.WriteLine(a);
            Kot Filemon = new Kot()
            {
                Name = "Filemon"
            };
            Console.Out.WriteLine(Filemon.DoSomething());
            Console.Out.WriteLine(Filemon.ToString());

            Console.ReadKey();
        }
    }
}
