using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    public static class AffixTier
    {
        //Method that takes the user entered input and determines the tier and uppper/lower boundries of the tier for that particular armour item
        public static void RetrieveFlatEs(Armour armour)
        {
            foreach (KeyValuePair<int, int> i in armour.flatTiers)
                if (armour.FlatEsRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the max/min they can achieve
                {
                    armour.MinFlatEs = i.Value;
                    armour.MaxFlatEs = i.Key;
                    int tier = armour.flatTiers.IndexOfKey(i.Key);
                    armour.FlatEsTier = tier;
                    //Helpers.Desc(tier);
                    break;
                }
        }
        //Method that takes the user entered input and determines the tier and uppper/lower boundries of the increased energy shield (these values remain constant throughout all armour types)
        public static void RetrieveIncEs(Armour armour)
        {
            SortedList<int, int> incTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                {132, 121},
                {120, 101},
                {100, 83},
                {82, 65}
            };

            foreach (KeyValuePair<int, int> i in incTiers)
                if (armour.IncEsRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the max/min they can achieve
                {
                    armour.MinIncEs = i.Value;
                    armour.MaxIncEs = i.Key;
                    int tier = (incTiers.IndexOfValue(i.Value) + 1);
                    armour.AltIncEsTier = tier;
                    //Helpers.Desc(tier);
                    break;
                }
        }
        //Method used to determine the increased es value by subtracting the hybrid increased es value from the total combined increased es value
        public static void RetrieveIncEsFromHybrid(Armour armour)
        {
            SortedList<int, int> incTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                {132, 121},
                {120, 101},
                {100, 83},
                {82, 65},
                {64, 47},
                {46, 29},
                {28, 11 }
            };

            int maxIncES = armour.IncEsRoll - armour.MinHybridEs;
            int minIncES = armour.IncEsRoll - armour.MaxHybridEs;

            foreach (KeyValuePair<int, int> i in incTiers)
                if (maxIncES >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MaxIncEs = i.Key;
                    armour.MinIncEs = i.Value;
                    armour.IncEsTier = (incTiers.IndexOfValue(i.Value) + 1);
                    break;
                }
            foreach (KeyValuePair<int, int> i in incTiers)
                if (minIncES >= (i.Value)) //Same function as the one immediately above but used for situations where the armour might fall into 2 different tier combinations
                {
                    armour.AltMaxIncEs = i.Key;
                    armour.AltMinIncEs = i.Value;
                    armour.AltIncEsTier = (incTiers.IndexOfValue(i.Value) + 1);
                    break;
                }
            //Used to set a property indicating that the increased es is made up of 2 definite tiers
            if (armour.IncEsTier == armour.AltIncEsTier)
            {
                armour.AltItem = false;
                armour.AltIncEsTier = armour.IncEsTier;
                Helpers.Desc(armour.IncEsTier);
            }
            //Used to set a property indicating that the increased es could be one of 2 different tier combinations and output that info
            else
            {
                armour.AltItem = true;
                Console.WriteLine($"That could either be Tier: {armour.IncEsTier} or Tier: {armour.AltIncEsTier} Increased ES, divine and try again");
            }
        }
        //Method for determining the hybrid increased es value from the user entered stun roll (only relevant if the stun roll isn't hybrid)
        public static void RetrieveStunRecovery(Armour armour)
        {
            SortedList<int, int> stunRecoveryTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                {17, 16},
                {15, 14},
                {13, 12},
                {11, 10},
                {9, 8},
                {6, 7}
            };

            foreach (KeyValuePair<int, int> i in stunRecoveryTiers)
                if (armour.StunRecoveryRoll >= i.Value) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    armour.MinStunRecovery = i.Value;
                    armour.MaxStunRecovery = i.Key;
                    int tier = (stunRecoveryTiers.IndexOfValue(i.Value) + 1);
                    armour.StunRecoveryTier = tier;
                    //Helpers.Desc(tier);
                    break;
                }

            SortedList<int, int> hybridTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
            {56, 51},
            {50, 42},
            {41, 33},
            {32, 21},
            {23, 15},
            {14, 6}
        };
            armour.MinHybridEs = hybridTiers.Values[armour.StunRecoveryTier - 1];
            armour.MaxHybridEs = hybridTiers.Keys[armour.StunRecoveryTier - 1];
            armour.HybridEsTier = armour.StunRecoveryTier;
        }
        /*
        public static void RetrieveHybridEs(Armour armour)
        {
            SortedList<int, int> HybridTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
            {56, 51},
            {50, 42},
            {41, 33},
            {32, 21},
            {23, 15},
            {14, 6}
            };
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
        */
        //Method to create an alternative armour object to display es ranges if the tier possibilities are different
        public static Armour CreateAltItem(Armour armour)
        {
            Armour altArmour = new Armour();
            altArmour = armour.ShallowCopy();
            altArmour.IncEsTier = armour.AltIncEsTier;
            altArmour.MaxIncEs = armour.AltMaxIncEs;
            altArmour.MinIncEs = armour.AltMinIncEs;
            return altArmour;
        }
    }
}
