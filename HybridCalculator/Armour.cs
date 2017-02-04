using HybridCalculator;
using System;
using System.Collections.Generic;

namespace HybridCalculator
{
    public class Armour
    {
        #region Properties
        // To store tier information
        public SortedList<int, int> flatTiers;
        //Properties to store the Flat ES tier and the potential min/max Flat ES values of the item
        public int FlatEsTier { get; set; }
        public int MinFlatEs { get; set; }
        public int MaxFlatEs { get; set; }
        //Properties to store the Increased ES tier and the potential min/max Increased ES values of the item
        public int IncEsTier { get; set; }
        public int MinIncEs { get; set; }
        public int MaxIncEs { get; set; }
        //Properties to store the Stun Recovery tier and the potential min/max Stun Recovery values of the item
        public int StunRecoveryTier { get; set; }
        public int MinStunRecovery { get; set; }
        public int MaxStunRecovery { get; set; }
        //Properties to store the Hybrid ES tier and the potential min/max Hybrid ES values of the item
        public int HybridEsTier { get; set; }
        public int MinHybridEs { get; set; }
        public int MaxHybridEs { get; set; }
        // minFlat property to set the lowest allowable value on an item
        protected int minFlat { get; set; }
        // maxFlat property to set the highest allowable value on an item
        protected int maxFlat { get; set; }
        // Declares whether the item is hybrid or not ** not used in logic at the time **
        public bool IsHybrid { get; set; }
        // To store the baseES of each different item 
        protected int _baseES;
        // BaseES property for different classes
        public int BaseES
        { get { return _baseES; } }
        // Backing fields for user enterable values
        protected int _flatEsRoll;
        protected int _incEsRoll;
        protected int _stunRecoveryRoll;
        protected int _hybridRoll;


        // Properties for user enterable values
        public int FlatEsRoll
        {
            get { return _flatEsRoll; }
            //Validation to make sure FlatES is within desired range
            set
            {
                if (Helpers.ValidateES(value, minFlat, maxFlat))
                    _flatEsRoll = value;
                else
                    Console.WriteLine(Helpers.ValidationMessage);
            }
        }
        public int IncEsRoll
        {
            get { return _incEsRoll; }
            //Validation to make sure FlatES is within desired range
            set
            {
                if (Helpers.ValidateES(value, 65, 189))
                    _incEsRoll = value;
                else
                    Console.WriteLine(Helpers.ValidationMessage);
            }
        }
        public int StunRecoveryRoll
        {
            get { return _stunRecoveryRoll; }
            //Validation to make sure FlatES is within desired range
            set
            {
                if (Helpers.ValidateES(value, 6, 17))
                    _stunRecoveryRoll = value;
                else
                    Console.WriteLine(Helpers.ValidationMessage);
            }
        }
        #endregion

        //Funcrions to determine the min/max values based on the what the user entered
        public void FlatTiers()
        {
            ArmourRepository.RetrieveFlatEs(this);
        }
        public void IncEsTiers()
        {
            ArmourRepository.RetrieveIncEs(this);
        }
        public void StunRecoveryTiers()
        {
            ArmourRepository.RetrieveStunRecovery(this);
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
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

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
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

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
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            // Add the flat tier values
            flatTiers.Add(72, 3);
            flatTiers.Add(106, 2);
            flatTiers.Add(135, 1);
            flatTiers.Add(141, 0);
        }
    }
}
