using HybridCalculator;
using System;
using System.Collections.Generic;

namespace HybridCalculator
{
    public class Armour
    {
        #region Properties
        // To store tier information
        public int[] minFlatTierArray { get; private set; }
        public int[] maxFlatTierArray;
        public SortedList<int, int> flatTiers;
        public int FlatEsTier { get; set; }
        public int MinFlatEs { get; set; }
        public int MaxFlatEs { get; set; }
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
                if (Helpers.ValidateFlatES(value, minFlat, maxFlat))
                    _flatES = value;
                else
                    Console.WriteLine(Helpers.ValidationMessage);
            }
        }
        #endregion

        public void FlatTiers(int flatES)
        {
            ArmourRepository.RetrieveFlatEs(this);
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
            int[] minFlatTierArray = { 136, 107, 73, 49, 30 };
            int[] maxFlatTierArray = { 145, 135, 106, 72, 48 };
            flatTiers = new SortedList<int, int>();

            // Add the flat tier values into our dictionary.
            flatTiers.Add(152, 146);
            flatTiers.Add(145, 136);
            flatTiers.Add(135, 107);
            flatTiers.Add(106, 73);
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
            flatTiers = new SortedList<int, int>();

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
            flatTiers = new SortedList<int, int>();

            // Add the flat tier values
            flatTiers.Add(72, 3);
            flatTiers.Add(106, 2);
            flatTiers.Add(135, 1);
            flatTiers.Add(141, 0);
        }
    }
}
