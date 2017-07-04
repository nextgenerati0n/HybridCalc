using System;

namespace HybridCalculator
{
    public class MinMaxES
    {
        public static void Calculate(Armour item)
        {
            if (item.IsHybrid == false)
            {
                item.CurrentEsResult = (int)Math.Round((item.BaseES + item.FlatEsRoll) * ((item.IncEsRoll + 20f) / 100)) + (item.BaseES + item.FlatEsRoll);
                item.MinEsResult = (int)Math.Round((item.BaseES + item.MinFlatEs) * ((item.MinIncEs + 20f) / 100)) + (item.BaseES + item.MinFlatEs);
                item.MaxEsResult = (int)Math.Round((item.BaseES + item.MaxFlatEs) * ((item.MaxIncEs + 20f) / 100)) + (item.BaseES + item.MaxFlatEs);
                MinMaxDesc("min", item.MinEsResult);
                MinMaxDesc("max", item.MaxEsResult);
                return;
            }
            else if (item.IsHybrid == true)
            {
                float totalMinHybrid = item.MinIncEs + item.MinHybridEs;
                float totalMaxHybrid = item.MaxIncEs + item.MaxHybridEs;
                item.CurrentEsResult = (int)Math.Round((item.BaseES + item.FlatEsRoll) * ((item.IncEsRoll + 20f) / 100)) + (item.BaseES + item.FlatEsRoll);
                item.MinEsResult = (int)Math.Round((item.BaseES + item.MinFlatEs) * ((totalMinHybrid + 20) / 100)) + (item.BaseES + item.MinFlatEs);
                item.MaxEsResult = (int)Math.Round((item.BaseES + item.MaxFlatEs) * ((totalMaxHybrid + 20) / 100)) + (item.BaseES + item.MaxFlatEs);
                MinMaxHybridDesc("min", item.MinHybridEs);
                MinMaxHybridDesc("max", item.MaxHybridEs);
                MinMaxDesc("min", item.MinEsResult);
                MinMaxDesc("max", item.MaxEsResult);
                return;
            }

        }

        static void MinMaxHybridDesc(string minMax, int hybridRoll) //Prints out the min/max total inc hybrid values
        {
            Console.WriteLine($"The {minMax} % Hybrid Energy Shield that can roll on this item is: {hybridRoll}");
        }

        static void MinMaxDesc(string minMax, float esRoll) //Prints out the min/max total
        {
            Console.WriteLine($"The {minMax} % Energy Shield that can roll on this item is: {esRoll}");
        }
        public static void StartAgain()
        {
            Console.WriteLine("Press any key to start again");
            Console.ReadKey();
        }
    }
}
