using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class CalculateHybrid
    {
        public static void Calculate(int baseES, int flatES)
        {
            Console.Write("What is the Roll for % Increased Stun Recovery? "); //Asks for user to input a stun roll to determine the min/max Increased Energy Shield
            int stunRoll = int.Parse(Console.ReadLine());
            bool isHybrid = false;
            int minHybridRoll = 0;
            int maxHybridRoll = 0;


            //Commented section below will replace the else if list eventually

            //int[,,] stunTiers = new int[,,] { { 
            //        { 7, 6, 14 },
            //        { 9, 15, 23 },
            //        { 11, 24, 32 },
            //        { 13, 33, 41 },
            //        { 15, 42, 50 },
            //        { 15, 51, 56 } } };


            //foreach (int i in stunTiers)
            //{
            //    if (stunRoll < 6)
            //    {
            //        Console.WriteLine("It is not possible to have a value lower than 6, try again");
            //        Console.WriteLine("Press any key to continue ...");
            //        Console.ReadLine();
            //        Console.Clear();
            //        isHybrid = false;
            //        Calculate(baseES, flatES);
            //    }
            //    else if (stunRoll <= stunTiers[0,i,0])
            //    {
            //        stunRoll = stunTiers[0, i, 0];
            //        //ThisIsTier.Desc(i.Value);
            //        break;
            //    }

            //    else if (stunRoll <= 28)
            //    {
            //        Console.WriteLine("That is a suffix and not a hybrid roll");
            //        Console.WriteLine("Press any key to continue ...");
            //        Console.ReadKey();
            //        return;
            //    }
            //}

            if (stunRoll < 6)
            {
                Console.WriteLine("It is not possible to have a value lower than 6, try again");
                Console.WriteLine("Press any key to continue ...");
                Console.ReadLine();
                Console.Clear();
                isHybrid = false;
                Calculate(baseES, flatES);
            }
            else if (stunRoll <= 7)
            {
                isHybrid = true;
                minHybridRoll = 6;
                maxHybridRoll = 14;
                ThisIsTier.HybridDesc(6, "Pixie's");
            }
            else if (stunRoll <= 9)
            {
                isHybrid = true;
                minHybridRoll = 15;
                maxHybridRoll = 23;
                ThisIsTier.HybridDesc(5, "Gremlin's");
            }
            else if (stunRoll <= 11)
            {
                isHybrid = true;
                minHybridRoll = 24;
                maxHybridRoll = 32;
                ThisIsTier.HybridDesc(4, "Boggart's");
            }
            else if (stunRoll <= 13)
            {
                isHybrid = true;
                minHybridRoll = 33;
                maxHybridRoll = 41;
                ThisIsTier.HybridDesc(3, "Naga's");
            }
            else if (stunRoll <= 15)
            {
                isHybrid = true;
                minHybridRoll = 42;
                maxHybridRoll = 50;
                ThisIsTier.HybridDesc(2, "Djinn's");
            }
            else if (stunRoll <= 17)
            {
                isHybrid = true;
                minHybridRoll = 51;
                maxHybridRoll = 56;
                ThisIsTier.HybridDesc(1, "Seraphim's");
            }
            else if (stunRoll <= 28)
            {
                Console.WriteLine("That is a suffix and not a hybrid roll");
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Are you sure you can even read?");
                Calculate(baseES, flatES);
            }
            //Takes the values forward to determine Increased Enegry Shield value
            DetermineIncreasedES.Calculate(baseES, flatES, minHybridRoll, maxHybridRoll);
        }
    }
}
