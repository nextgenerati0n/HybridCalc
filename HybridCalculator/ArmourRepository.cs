using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    public static class ArmourRepository
    {
        public static void RetrieveFlatEs(Armour armour)
        {
            foreach (KeyValuePair<int, int> i in armour.flatTiers)
                if (armour.FlatEs >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinFlatEs = i.Value;
                    armour.MaxFlatEs = i.Key;
                    int tier = armour.flatTiers.IndexOfKey(i.Key);
                    armour.FlatEsTier = tier;
                    Helpers.Desc(tier);
                    break;
                }
        }

        public static void RetrieveIncEs(Armour armour)
        {
            SortedList<int, int> incTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Input the flat tier values
            incTiers.Add(132, 121);
            incTiers.Add(120, 101);
            incTiers.Add(100, 83);
            incTiers.Add(82, 65);

            foreach (KeyValuePair<int, int> i in incTiers)
                if (armour.IncEs >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinIncEs = i.Value;
                    armour.MaxIncEs = i.Key;
                    int tier = (incTiers.IndexOfValue(i.Value) + 1);
                    armour.IncEsTier = tier;
                    Helpers.Desc(tier);
                    break;
                }
        }
    }
}
