using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class Armour
    {
        // To store the baseES of each different item
        protected int _baseES;
        // BaseES property for different classes
        public int BaseES
        {
            get { return _baseES; }
        }

        public int flatES { get; set; }
        public int maxFlatES { get; set; }
    }

    class Regalia : Armour
    {
        public Regalia()
        {
            baseES = 175;
        }
    }

    class Circlet : Armour
    {
        public Circlet()
        {
            baseES = 100;
        } 
    }

    class SpiritShield : Armour
    {
        public SpiritShield()
        {
            baseES = 84;
        }
    }
}
