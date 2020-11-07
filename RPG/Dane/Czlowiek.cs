using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    abstract class Czlowiek : Istota
    {
        public string Imie;
        private int wzrost;
        private bool visibility;
        public abstract void PrzedstawSie();

        public int Wzrost { get => wzrost; set => wzrost = value; }
        public bool Visibility { get => visibility; set => visibility = value; }
        

        public void Powitaj(ref Istota istota)
        {
            Console.Write("Witaj istoto o wzroscie " + istota.Wzrost + ", ktora jestes ");
            if (istota.Visibility)
                Console.Write("widzialna.");
            else Console.Write("niewidzialna");
        }
    }
}
