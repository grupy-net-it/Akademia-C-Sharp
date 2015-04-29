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
            return "Moje Zwierze nazywa sie " + Name;
        }
    }
}
