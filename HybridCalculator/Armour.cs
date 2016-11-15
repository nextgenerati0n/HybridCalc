using System;
using System.Collections.Generic;

namespace HybridCalculator
{
    abstract class Armour
    {
        // To store tier information
        protected Dictionary<int, int> flatTiers;
        // To store the baseES of each different item
        protected int _baseES;

        // method to calculate flat tiers.
       // abstract public int FlatTiers(int flatES);

        // BaseES property for different classes
        public int BaseES
        { get { return _baseES; } }
        // flatES property
        public int FlatES { get; set; }
        // minFlat property
        public int minFlat { get; set; }
        // maxFlat property
        public int maxFlat { get; set; }

        public int FlatTiers(int flatES)
        {
            // bool and while loop to loop over it again in case of a value > 152
            bool c = true;
            while (c)
            {
                // First, check if the flat ES is within the limits of 73 and 152
                if (flatES < minFlat)
                {
                    Console.WriteLine("It's garbage, go get some new armour");
                    Console.ReadKey();
                    c = false;
                    return 0;
                }
                else if (flatES > maxFlat)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                }

                // If it is, and it is worth looping over the tier dictionary, do so
                foreach (KeyValuePair<int, int> i in flatTiers)
                    if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                    {
                        FlatES = i.Key;
                        ThisIsTier.Desc(i.Value);
                        c = false;
                        break;
                    }
            }
            return FlatES;
        }

        public void AddGrade(int es, int tier)
        {
            flatTiers.Add(es, tier);
        }
    }

    class Regalia : Armour
    {
        public Regalia()
        {
            // set the base ES value
            _baseES = 175;
            // if the value < 49, it is shit
            minFlat = 73;
            // if the value > 78, it is non existant technically
            maxFlat = 152;
            // init the dictionary to save the flat tiers in.
            flatTiers = new Dictionary<int, int>();

            // Add the flat tier values into our dictionary.
            flatTiers.Add(106, 3);
            flatTiers.Add(135, 2);
            flatTiers.Add(145, 1);
            flatTiers.Add(152, 0);
        }
    }

    class Circlet : Armour
    {
        public Circlet()
        {
            // set the base ES value
            _baseES = 100;
            // if the value < 49, it is shit
            minFlat = 30;
            // if the value > 78, it is non existant technically
            maxFlat = 78;
            // init the dictionary to save the flat tiers in.
            flatTiers = new Dictionary<int, int>();

            // Input the flat tier values
            flatTiers.Add(48, 2);
            flatTiers.Add(72, 1);
            flatTiers.Add(78, 0);
        }
    }

    class SpiritShield : Armour
    {
        public SpiritShield()
        {
            // Set the base ES value
            _baseES = 84;
            // if the value < 49, it is shit
            minFlat = 49;
            // if the value > 141, it is non existant technically
            maxFlat = 141;
            // init the flattiers dictionary
            flatTiers = new Dictionary<int, int>();

            // Add the flat tier values
            flatTiers.Add(72, 3);
            flatTiers.Add(106, 2);
            flatTiers.Add(135, 1);
            flatTiers.Add(141, 0);
        }
    }
}
