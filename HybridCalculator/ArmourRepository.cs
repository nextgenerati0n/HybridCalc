using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    public static class ArmourRepository
    {
        public static void RetrieveFlatEs(this Armour armour)
        {
            foreach (KeyValuePair<int, int> i in armour.flatTiers)
                if (armour.FlatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinFlatEs = i.Key;
                    armour.MaxFlatEs = i.Value;
                    int tier = armour.flatTiers.IndexOfKey(i.Key -1);
                    armour.FlatEsTier = tier;
                    Helpers.Desc(tier);
                    break;
                }
        }
    }
}
