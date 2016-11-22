using System;
using System.Collections.Generic;

namespace HybridCalculator
{
    abstract class Armour
    {
        #region Properties
        // To store tier information
        protected Dictionary<int, int> flatTiers;

        // minFlat property
        protected int minFlat { get; set; }
        // maxFlat property
        protected int maxFlat { get; set; }
        // Declares whether the item is hybrid or not ** not used in logic at the time **
        public bool Hybrid { get; set; }
        // To store the maximum Increased ES of an item ** not used in logic at the time **
        public int MaxIncES { get; set; }
        // To store the baseES of each different item 
        protected int _baseES;
        // BaseES property for different classes
        public int BaseES
        { get { return _baseES; } }
        // FlatES backing field
        protected int _flatES;
        // flatES property
        public int FlatES
        {
            get { return _flatES; }
            //Validation to make sure FlatES is within desired range
            set
            {
                if (ValidationHelpers.ValidateFlatES(value, minFlat, maxFlat))
                    _flatES = value;
                else
                    Console.WriteLine(ValidationHelpers.ValidationMessage);
                Console.ReadKey();
            }
        }
        #endregion

        public int FlatTiers(int flatES)
        {
            // If FlatES is within desired range and it is worth looping over the tier dictionary, do so
            foreach (KeyValuePair<int, int> i in flatTiers)
                if (flatES <= i.Key) //Cycles through and compares their value with the list of tiers to determine the maximum they can achieve
                {
                    FlatES = i.Key;
                    ThisIsTier.Desc(i.Value);
                    break;
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
            // if the value < 73, it is shit
            minFlat = 73;
            // if the value > 152, it is non existant technically
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
            // if the value < 30, it is shit
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
