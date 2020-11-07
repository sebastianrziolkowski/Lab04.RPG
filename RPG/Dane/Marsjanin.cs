using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    class Marsjanin : Istota
    {
        private int wzrost;
        private bool visibility;
        public void Atakuj(ref Istota istota)
        {
            Console.WriteLine("*Pif paff");
        }


        public int Wzrost { get => wzrost; set => wzrost = value; }
        public bool Visibility { get => visibility; set => visibility = value; }

        public void Powitaj(ref Istota istota)
        {
            Console.WriteLine("Witaj Istoto o wzroscie " + istota.Wzrost);
            if (istota.Visibility)
                Console.WriteLine("Ty jestes widzialny.");
            else Console.WriteLine("Ty jestes niewidzialny");

            Atakuj(ref istota);
        }
    }
}
