using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class HasStunRecovery
    {
        public static bool Decision(int baseES, int flatES, string stunChoice)
        {
            //string hybridChoice = EnterStunChoice();
            int minHybridRoll = 0;
            int maxHybridRoll = 0;

            if (stunChoice == "y")
            {
                CalculateHybrid.Calculate(baseES, flatES, maxHybridRoll);
                return true;
            }
            else if (stunChoice == "n")
            {
                bool isHybrid = false;
                return false;
            }
            else
            {
                Console.WriteLine("That was a simple choice between 'y' and 'n', try again dummy!");
                return false;
            }
        }


    }
}
