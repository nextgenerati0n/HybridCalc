﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class DetermineIncreasedES
    {
        public static void Calculate(int baseES, int flatES)
        {
            //Ask the user to input their current Increased Energy Shield value
            Console.Write("What is the maximum increased ES: ");
            int incES = int.Parse(Console.ReadLine());
            int maxIncES = 0;
            int minIncES = 0;

            if (incES < 65)
            {
                Console.WriteLine("It's garbage, go get some new armour");
                Console.ReadKey();
                return;
            }
            else if (incES <= 82)
            {
                minIncES = 65;
                maxIncES = 82;
                ThisIsTier.Desc(4);
            }
            else if (incES <= 100)
            {
                minIncES = 83;
                maxIncES = 100;
                ThisIsTier.Desc(3);
            }
            else if (incES <= 120)
            {
                minIncES = 101;
                maxIncES = 120;
                ThisIsTier.Desc(2);
            }
            else if (incES <= 132)
            {
                minIncES = 121;
                maxIncES = 132;
                ThisIsTier.Desc(1);
            }
            else
            {
                Console.WriteLine("It is not possible to get higher than 132% on a non-hybrid item, try again");
                Console.WriteLine("\nPress 1 to try again or any other key to return to the main menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    Calculate(baseES, flatES);
                else
                    return;

                Console.ReadKey();
            }
            MinMaxES.Calculate(minIncES, maxIncES, baseES, flatES);
        }

        public static void Calculate(int baseES, int flatES, int minHybridRoll, int maxHybridRoll)
        {
            //Ask the user to input their current Increased Energy Shield value
            Console.Write("What is the maximum increased ES: ");
            int incES = int.Parse(Console.ReadLine());
            int maxIncES = incES - minHybridRoll;
            int minIncES = incES - maxHybridRoll;

            if (maxIncES < 65 || minIncES < 65)
            {
                Console.WriteLine("It's garbage, go get some new armour");
                Console.ReadKey();
                return;
            }
            else if (maxIncES <= 82 && minIncES > 65)
            {
                minIncES = 65;
                maxIncES = 82;
                ThisIsTier.Desc(4);
            }
            else if (maxIncES <= 100 && minIncES > 82)
            {
                minIncES = 83;
                maxIncES = 100;
                ThisIsTier.Desc(3);
            }
            else if (maxIncES <= 120 && minIncES > 100)
            {
                minIncES = 101;
                maxIncES = 120;
                ThisIsTier.Desc(2);
            }
            else if (maxIncES <= 132 && minIncES > 120)
            {
                minIncES = 121;
                maxIncES = 132;
                ThisIsTier.Desc(1);
            }
            else
            {
                Console.WriteLine("That could be one of 2 different Increased Maximum ES tiers, divine and try again");
                Console.WriteLine("\nPress 1 to try again or any other key to return to the main menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    Calculate(baseES, flatES, minHybridRoll, maxHybridRoll);
                else
                    return;                

                Console.ReadKey();
            }
            MinMaxES.Calculate(minIncES, maxIncES, baseES, flatES, minHybridRoll, maxHybridRoll);
        }
    }
}
