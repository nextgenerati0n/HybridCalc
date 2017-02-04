using System;

namespace HybridCalculator
{
    class MinMaxES
    {
        public static void Calculate(Armour armour)
        {
            if (armour.IsHybrid == false)
            {
                float minES = (int)Math.Round((armour.BaseES + armour.MinFlatEs) * ((armour.MinIncEs + 20f) / 100)) + (armour.BaseES + armour.MinFlatEs);
                float maxES = (int)Math.Round((armour.BaseES + armour.MaxFlatEs) * ((armour.MaxIncEs + 20f) / 100)) + (armour.BaseES + armour.MaxFlatEs);
                MinMaxDesc("min", minES);
                MinMaxDesc("max", maxES);
                StartAgain();
                return;
            }
            else if (armour.IsHybrid == true)
            {
                float totalMinHybrid = armour.MinIncEs + armour.MinHybridEs;
                float totalMaxHybrid = armour.MaxIncEs + armour.MaxHybridEs;
                float minES = (int)Math.Round((armour.BaseES + armour.MinFlatEs) * ((totalMinHybrid + 20) / 100)) + (armour.BaseES + armour.MinFlatEs);
                float maxES = (int)Math.Round((armour.BaseES + armour.MaxFlatEs) * ((totalMaxHybrid + 20) / 100)) + (armour.BaseES + armour.MaxFlatEs);
                MinMaxHybridDesc("min", armour.MinHybridEs);
                MinMaxHybridDesc("max", armour.MaxHybridEs);
                MinMaxDesc("min", minES);
                MinMaxDesc("max", maxES);
                StartAgain();
                return;
            }

        }
        //public static void Calculate(int minIncES, int maxIncES, int baseES, int flatES, int minHybridRoll, int maxHybridRoll)
        //{
        //    float totalMinHybrid = minIncES + minHybridRoll;
        //    float totalMaxHybrid = maxIncES + maxHybridRoll;
        //    float minES = (int)Math.Round((baseES + flatES) * ((totalMinHybrid + 20) / 100)) + (baseES + flatES);
        //    float maxES = (int)Math.Round((baseES + flatES) * ((totalMaxHybrid + 20) / 100)) + (baseES + flatES);
        //    MinMaxHybridDesc("min", minHybridRoll);
        //    MinMaxHybridDesc("max", maxHybridRoll);
        //    MinMaxDesc("min", minES);
        //    MinMaxDesc("max", maxES);
        //    StartAgain();
        //    return;

        //}
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
