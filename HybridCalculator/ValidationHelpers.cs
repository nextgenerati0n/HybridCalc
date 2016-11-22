using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class Helpers
    {
        //Validation message if intered properties are outside of desired range
        internal static string ValidationMessage { get; set; }

        public static bool ValidateFlatES(int input, int lowValue, int highValue)
        {
            if (input < lowValue)
            {
                ValidationMessage = "It's garbage, go get some new armour";
                //throw new ArgumentOutOfRangeException("It's garbage, go get some new armour");
                return false;
            }
            else if (input > highValue)
            {
                ValidationMessage = "That's not an acceptable answer, are you drunk?";
                //throw new ArgumentOutOfRangeException("That's not an acceptable answer, are you drunk?");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Desc(int tier)
        {
            Console.WriteLine($"This is tier {tier}");
        }

        public static void HybridDesc(int tier, string name)
        {
            Console.WriteLine($"\nThe hybrid roll is tier  {tier}: {name}");
        }

    }
}
