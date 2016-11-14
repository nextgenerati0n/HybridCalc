using System;
using System.Collections.Generic;

namespace HybridCalculator
{
    class WhichFlatTier
    {
        public static void ChestFlatTier(int baseES)
        {
            int flatES = EnterESValue(); //user to input the current Maximum Energy Shield value
            Dictionary<int, int> flatTiers = new Dictionary<int, int>();
            flatTiers.Add(106, 3);
            flatTiers.Add(135, 2);
            flatTiers.Add(145, 1);
            flatTiers.Add(152, 0);

            foreach (var i in flatTiers)
            {
                if (flatES < 73)
                {
                    Console.WriteLine("It's garbage, go get some new armour");
                    Console.ReadKey();
                    return;
                }
                else if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    flatES = i.Key;
                    ThisIsTier.Desc(i.Value);
                    break;
                }

                else if (flatES > 152)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                    ChestFlatTier(baseES);
                }
            }

            HasStunRecovery.HasStun(baseES, flatES);
        }

        public static void HelmetFlatTier(int baseES)
        {
            int flatES = EnterESValue(); //user to input the current Maximum Energy Shield value
            Dictionary<int, int> flatTiers = new Dictionary<int, int>();
            flatTiers.Add(48, 2);
            flatTiers.Add(72, 1);
            flatTiers.Add(78, 0);

            foreach (var i in flatTiers)
            {
                if (flatES < 30)
                {
                    Console.WriteLine("It's garbage, go get a new helmet");
                    Console.ReadKey();
                    return;
                }
                else if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    flatES = i.Key;
                    ThisIsTier.Desc(i.Value);
                    break;
                }

                else if (flatES > 78)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                    HelmetFlatTier(baseES);
                }
            }

            HasStunRecovery.HasStun(baseES, flatES);
        }

        public static void ShieldFlatTier(int baseES)
        {
            int flatES = EnterESValue(); //user to input the current Maximum Energy Shield value
            Dictionary<int, int> flatTiers = new Dictionary<int, int>();
            flatTiers.Add(72, 3);
            flatTiers.Add(106, 2);
            flatTiers.Add(135, 1);
            flatTiers.Add(141, 0);

            foreach (var i in flatTiers)
            {
                if (flatES < 49)
                {
                    Console.WriteLine("It's garbage, go get a new shield");
                    Console.ReadKey();
                    return;
                }
                else if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    flatES = i.Key;
                    ThisIsTier.Desc(i.Value);
                    break;
                }

                else if (flatES > 141)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                    ShieldFlatTier(baseES);
                }
            }

            HasStunRecovery.HasStun(baseES, flatES);
        }

        static int EnterESValue()
        {
            Console.Clear();
            Console.Write("Enter the Increased Flat Energy Shield value: ");
            int flatES = int.Parse(Console.ReadLine());
            return flatES;

        }
    }
}
