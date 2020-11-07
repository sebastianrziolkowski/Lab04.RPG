using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Dane;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Ziemianin ziemianin = new Ziemianin();
            ziemianin.Imie = "Nathan";
            ziemianin.Nazwisko = "Drake";
            ziemianin.Wzrost = 182;
            ziemianin.Visibility = true;
            ziemianin.Zawod = "Poszukiwacz skarbow";

            Istota istota = new Marsjanin();
            istota.Visibility = false;
            istota.Wzrost = 250;


            ziemianin.PrzedstawSie();
            ziemianin.Powitaj(ref istota);

            //istota.Powitaj(ref ziemianin);               --- Problem z referencja 

            Console.Read();
        }
    }
}
