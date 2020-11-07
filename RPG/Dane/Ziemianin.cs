using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    class Ziemianin : Czlowiek
    {
        public string Nazwisko;
        public string Zawod;


        public override void PrzedstawSie()
        {
            Console.Write("Nazywam sie " + Imie + " " + Nazwisko);
            Console.Write(". Jestem " + Zawod + ".");
            Console.Write("Mam wzrost " + Wzrost + " i jestem ");

            if (Visibility)
                Console.WriteLine("widzialny.");
            else Console.WriteLine("niewidzialny.");
        }
    }
}
