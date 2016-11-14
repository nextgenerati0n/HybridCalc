using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class Armour
    {
        //private int _flatES;

        //public int FlatES
        //{
        //    get { return _flatES; }
        //    set { _flatES = value; }
        //}
        public int flatES { get; set; }
        public int baseES { get; set; }
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
