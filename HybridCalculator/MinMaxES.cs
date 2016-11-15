using System;

namespace HybridCalculator
{
    class MinMaxES
    {
        public static void Calculate(int minIncES, int maxIncES, int baseES, int flatES)
        {
            float minES = (int)Math.Round((baseES + flatES) * ((minIncES + 20f) / 100)) + (baseES + flatES);
            float maxES = (int)Math.Round((baseES + flatES) * ((maxIncES + 20f) / 100)) + (baseES + flatES);
            MinMaxDesc("min", minES);
            MinMaxDesc("max", maxES);
            StartAgain();
            return;

        }
        public static void Calculate(int minIncES, int maxIncES, int baseES, int flatES, int minHybridRoll, int maxHybridRoll)
        {
            float totalMinHybrid = minIncES + minHybridRoll;
            float totalMaxHybrid = maxIncES + maxHybridRoll;
            float minES = (int)Math.Round((baseES + flatES) * ((totalMinHybrid + 20) / 100)) + (baseES + flatES);
            float maxES = (int)Math.Round((baseES + flatES) * ((totalMaxHybrid + 20) / 100)) + (baseES + flatES);
            MinMaxHybridDesc("min", minHybridRoll);
            MinMaxHybridDesc("max", maxHybridRoll);
            MinMaxDesc("min", minES);
            MinMaxDesc("max", maxES);
            StartAgain();
            return;

        }
        static void MinMaxHybridDesc(string minMax, int hybridRoll) //Prints out the min/max total inc hybrid values
        {
            Console.WriteLine($"The {minMax} % Hybrid Energy Shield that can roll on this item is: {hybridRoll}");
        }

        static void MinMaxDesc(string minMax, float esRoll) //Prints out the min/max total
        {
            Console.WriteLine($"The {minMax} % Energy Shield that can roll on this item is: {esRoll}");
        }
        static void StartAgain()
        {
            Console.WriteLine("Press any key to start again");
            Console.ReadKey();
        }
    }
}
