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
                if (armour.FlatEsRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
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
                if (armour.IncEsRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinIncEs = i.Value;
                    armour.MaxIncEs = i.Key;
                    int tier = (incTiers.IndexOfValue(i.Value) + 1);
                    armour.IncEsTier = tier;
                    //Helpers.Desc(tier);
                    break;
                }
        }

        public static void RetrieveIncEsFromHybrid(Armour armour)
        {
            SortedList<int, int> incTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Input the tier values
            incTiers.Add(132, 121);
            incTiers.Add(120, 101);
            incTiers.Add(100, 83);
            incTiers.Add(82, 65);

            int maxIncES = armour.IncEsRoll - armour.MinHybridEs;
            int minIncES = armour.IncEsRoll - armour.MaxHybridEs;
            int maxIncEsTier = 0;
            int minIncEsTier = 0;

            foreach (KeyValuePair<int, int> i in incTiers)
                if (maxIncES >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MaxIncEs = i.Key;
                    maxIncEsTier = (incTiers.IndexOfValue(i.Value) + 1);
                    break;
                }
            foreach (KeyValuePair<int, int> i in incTiers)
                if (minIncES >= (i.Value)) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinIncEs = i.Value;
                    minIncEsTier = (incTiers.IndexOfValue(i.Value) + 1);
                    break;
                }
            if (maxIncEsTier == minIncEsTier)
            {
                armour.IncEsTier = maxIncEsTier;
                Helpers.Desc(maxIncEsTier);
            }
            else
            {
                Console.WriteLine($"That could either be Tier: {maxIncEsTier} or Tier: {minIncEsTier} Increased ES, divine and try again");
                Console.ReadKey();
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
                if (armour.StunRecoveryRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinStunRecovery = i.Value;
                    armour.MaxStunRecovery = i.Key;
                    int tier = (stunRecoveryTiers.IndexOfValue(i.Value) + 1);
                    armour.StunRecoveryTier = tier;
                    Helpers.Desc(tier);
                    break;
                }

            SortedList<int, int> hybridTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Input the tier values
            hybridTiers.Add(56, 51);
            hybridTiers.Add(50, 42);
            hybridTiers.Add(41, 33);
            hybridTiers.Add(32, 21);
            hybridTiers.Add(23, 15);
            hybridTiers.Add(14, 6);

            armour.MinHybridEs = hybridTiers.Values[armour.StunRecoveryTier -1];
            armour.MaxHybridEs = hybridTiers.Keys[armour.StunRecoveryTier -1];
            armour.HybridEsTier = armour.StunRecoveryTier;
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
                if (armour.IncEsRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
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
