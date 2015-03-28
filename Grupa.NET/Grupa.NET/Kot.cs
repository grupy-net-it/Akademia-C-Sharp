using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa.NET
{
    // tutaj zostalo zastosowane dziedziczenie , po dwukropku : podajemy nazwe klasy bazowej ( w tym przypadku Zwierze)
    public class Kot :Zwierze           
    {
               
       // jak stworzyc swoja wlasna metode?
       // na poczatku mozemy podac typ widocznosci oraz dodatkowe atrybuty (np override), nastepnie musimy okreslic co zwraca dana metoda oraz nazwe jej [OBOWIAZKOWO]. Ponadto w nawiasach podajemy zmienne z ktorych bedziemy mogli korzystac w dzialaniu metody.
       // override sluzy do nadpisania danej metody
        public override string DoSomething()    
        { return "meow"; }
        // mozemy zauwazyc, ze gdy nie wskazemy ze chcemy nadpisac metode w klasie bazowej (zwierze) wywola sie metoda klasy dziedziczacej (Kot)
        
        public string ToString()       
        {
            return "Uwaga Kot!";
        }
   }


}


