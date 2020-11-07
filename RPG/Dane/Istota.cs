using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public interface Istota
    {
        public int Wzrost
        {
            get;
            set;
        }

        public bool Visibility
        {
            get;
            set;
        }

        public void Powitaj(ref Istota istota);
    }
}
