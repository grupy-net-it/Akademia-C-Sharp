using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa.NET
{
    public class Zwierze
    {
        // wlasciwosci, dzieki ktorej bedziemy mogli przypisac imie do naszego kota
        public string Name { get; set; } 

        // virtual wskazuje ze dana metode mozemy nadpisac ( zostanie wykonana metoda z klasy dziedziczacej)
        public virtual string DoSomething() 
        {
            return "hoah";
        }
        public string ToString()
        {
            return "moje Zwierze nazywa sie"+Name;
        }
    }
}
