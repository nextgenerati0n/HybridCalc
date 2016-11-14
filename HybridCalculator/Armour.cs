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
        abstract public int FlatTiers(int flatES);

        // BaseES property for different classes
        public int BaseES
        { get { return _baseES; } }
        // flatES property
        public int flatES { get; set; }
        // maxFlatES property
        public int maxFlatES { get; set; }
    }

    class Regalia : Armour
    {
        public Regalia()
        {
            _baseES = 175;
            flatTiers = new Dictionary<int, int>();

            // Add the flat tier values into our dictionary.
            flatTiers.Add(106, 3);
            flatTiers.Add(135, 2);
            flatTiers.Add(145, 1);
            flatTiers.Add(152, 0);
        }

        public override int FlatTiers(int flatES)
        {
            // bool and while loop to loop over it again in case of a value > 152
            bool c = true;
            while (c)
            {
                // First, check if the flat ES is within the limits of 73 and 152
                if (flatES < 73)
                {
                    Console.WriteLine("It's garbage, go get some new armour");
                    Console.ReadKey();
                    c = false;
                    return 0;
                }
                else if (flatES > 152)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                }

                // If it is, and it is worth looping over the tier dictionary, do so
                foreach (KeyValuePair<int, int> i in flatTiers)
                    if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                    {
                        flatES = i.Key;
                        ThisIsTier.Desc(i.Value);
                        c = false;
                        break;
                    }
            }
            return flatES;
        }
    }

    class Circlet : Armour
    {
        public Circlet()
        {
            // set the base ES value
            _baseES = 100;
            // init the dictionary to save the flat tiers in.
            flatTiers = new Dictionary<int, int>();

            // Input the flat tier values
            flatTiers.Add(48, 2);
            flatTiers.Add(72, 1);
            flatTiers.Add(78, 0);
        }

        public override int FlatTiers(int flatES)
        {
            // Bool and while loop to loop over the code again in case of a value > 78
            bool c = true;
            while (c)
            {
                // If the value is < 30, its not worth much
                if (flatES < 30)
                {
                    Console.WriteLine("It's garbage, go get a new helmet");
                    Console.ReadKey();
                    c = false;
                    return 0;
                }
                // If it is larger than 78, it is madness / nonexistant
                else if (flatES > 78)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                }

                // If it is neither of the above cases, loop through the dictionary
                foreach (var i in flatTiers)
                    if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                    {
                        flatES = i.Key;
                        ThisIsTier.Desc(i.Value);
                        c = false;
                        break;
                    }
            }
            return flatES;
        }
    }

    class SpiritShield : Armour
    {
        public SpiritShield()
        {
            // Set the base ES value
            _baseES = 84;

            // init the flattiers dictionary
            flatTiers = new Dictionary<int, int>();

            // Add the flat tier values
            flatTiers.Add(72, 3);
            flatTiers.Add(106, 2);
            flatTiers.Add(135, 1);
            flatTiers.Add(141, 0);
        }

        public override int FlatTiers(int flatES)
        {
            // Bool and while loop to loop through again if the value > 141
            bool c = true;
            while (c)
            {
                // if the value < 49, it is shit
                if (flatES < 49)
                {
                    Console.WriteLine("It's garbage, go get a new shield");
                    Console.ReadKey();
                    c = false;
                    break;
                }
                // if the value > 141, it is non existant technically
                else if (flatES > 141)
                {
                    Console.WriteLine("That's not an acceptable answer, are you drunk?");
                    Console.ReadKey();
                }

                // If it is neither of the above, loop through the dictionary looking for the flat tier of the value.
                foreach (var i in flatTiers)
                    if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                    {
                        flatES = i.Key;
                        ThisIsTier.Desc(i.Value);
                        c = false;
                        break;
                    }  
            }
            return flatES;
        }
    }
}
