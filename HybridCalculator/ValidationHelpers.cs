using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class ValidationHelpers
    {
        public static int ValidateFlatES(int input, int lowValue, int highValue)
        {
            if (input < lowValue)
            {
                throw new ArgumentOutOfRangeException("It's garbage, go get some new armour");
            }
            else if (input > highValue)
            {
                throw new ArgumentOutOfRangeException("That's not an acceptable answer, are you drunk?");
            }
            return input;
        }
    }
}
