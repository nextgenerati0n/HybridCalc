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

            // Input the tier values
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

        public static void RetrieveStunRecovery(Armour armour)
        {
            SortedList<int, int> stunRecoveryTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Input the tier values
            stunRecoveryTiers.Add(17, 16);
            stunRecoveryTiers.Add(15, 14);
            stunRecoveryTiers.Add(13, 12);
            stunRecoveryTiers.Add(11, 10);
            stunRecoveryTiers.Add(9, 8);
            stunRecoveryTiers.Add(6, 7);

            foreach (KeyValuePair<int, int> i in stunRecoveryTiers)
                if (armour.IncEs >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinStunRecoveryRoll = i.Value;
                    armour.MaxStunRecoveryRoll = i.Key;
                    int tier = (stunRecoveryTiers.IndexOfValue(i.Value) + 1);
                    armour.StunRecoveryTier = tier;
                    Helpers.Desc(tier);
                    break;
                }
            RetrieveHybridEs(armour);
        }

        public static void RetrieveHybridEs(Armour armour)
        {
            SortedList<int, int> HybridTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Input the tier values
            HybridTiers.Add(56, 51);
            HybridTiers.Add(50, 42);
            HybridTiers.Add(41, 33);
            HybridTiers.Add(32, 21);
            HybridTiers.Add(23, 15);
            HybridTiers.Add(14, 6);

            foreach (KeyValuePair<int, int> i in HybridTiers)
                if (armour.IncEs >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinHybridEs = i.Value;
                    armour.MaxHybridEs = i.Key;
                    int tier = (HybridTiers.IndexOfValue(i.Value) + 1);
                    armour.HybridEsTier = tier;
                    Helpers.Desc(tier);
                    break;
                }
        }
    }
}
