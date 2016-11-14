using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class HasStunRecovery
    {
        public static void HasStun(int baseES, int flatES)
        {
            Console.Write("Does the item have an '% Increased Stun Recovery' value: y/n ");
            string hybridChoice = Console.ReadLine();
            int minHybridRoll = 0;
            int maxHybridRoll = 0;

            if (hybridChoice == "y")
            {
                CalculateHybrid.Calculate(baseES, flatES, maxHybridRoll);
            }
            else if (hybridChoice == "n")
            {
                bool isHybrid = false;
                DetermineIncreasedES.Calculate(baseES, flatES, minHybridRoll, maxHybridRoll, isHybrid);
            }
            else
            {
                Console.WriteLine("That was a simple choice between 'y' and 'n', try again dummy!");
            }
        }
    }
}
