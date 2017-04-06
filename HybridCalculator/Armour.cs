using HybridCalculator;
using System;
using System.Collections.Generic;

namespace HybridCalculator
{
    public class Armour
    {
        #region Properties
        public object Name { get; set; }
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
        //Properties to store the alternate Increased ES tier in case it is between 2 possbile tiers
        public int AltIncEsTier { get; set; }
        public int AltMinIncEs { get; set; }
        public int AltMaxIncEs { get; set; }
        //Property that determines if the outcome is between 2 possible tiers or just 1
        public bool AltItem { get; internal set; }
        //Properties to store the Stun Recovery tier and the potential min/max Stun Recovery values of the item
        public int StunRecoveryTier { get; set; }
        public int MinStunRecovery { get; set; }
        public int MaxStunRecovery { get; set; }
        //Properties to store the Hybrid ES tier and the potential min/max Hybrid ES values of the item
        public int HybridEsTier { get; set; }
        public int MinHybridEs { get; set; }
        public int MaxHybridEs { get; set; }
        //Properties to set the range of permitted values
        protected int minFlat { get; set; }
        protected int maxFlat { get; set; }
        // Declares whether the item is hybrid or not
        public bool? IsHybrid { get; set; }
        //Finals ES results
        public int CurrentEsResult { get; set; }
        public int MinEsResult { get; set; }
        public int MaxEsResult { get; set; }
        // Backing field to store the baseES of each different item 
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
            AffixTier.RetrieveFlatEs(this);
        }
        public void IncEsTiers()
        {
            AffixTier.RetrieveIncEs(this);
        }
        public void StunRecoveryTiers()
        {
            AffixTier.RetrieveStunRecovery(this);
        }
        public void IncEsFromHybrid()
        {
            AffixTier.RetrieveIncEsFromHybrid(this);
        }
        public Armour ShallowCopy()
        {
            return (Armour)this.MemberwiseClone();
        }
    }

    public class Regalia : Armour
    {
        public Regalia()
        {
            Name = "Regalia";
            // set the base ES value
            _baseES = 175;
            // if the value < 73, it is shit
            minFlat = 73;
            // if the value > 152, it is non existant technically
            maxFlat = 152;
            // init the dictionary to save the flat tiers in.
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                {152, 146},
                {145, 136},
                {135, 107},
                {106, 73}
            };
        }
    }

    public class Circlet : Armour
    {
        public Circlet()
        {
            // set the base ES value
            _baseES = 100;
            // if the value < 30, it is shit
            minFlat = 20;
            // if the value > 78, it is non existant technically
            maxFlat = 78;
            // init the dictionary to save the flat tiers in.
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                {78, 73},
                {72, 49},
                {48, 30},
                {29, 20}
            };
        }
    }
    public class SpiritShield : Armour
    {
        public SpiritShield()
        {
            // Set the base ES value
            _baseES = 84;
            // if the value < 49, it is shit
            minFlat = 30;
            // if the value > 141, it is non existant technically
            maxFlat = 141;
            // init the flattiers dictionary
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                { 141, 136},
                { 135, 107},
                { 106, 73},
                { 72, 49},
                { 48, 30}
            };
        }
    }

    public class SorcererGloves : Armour
    {
        public SorcererGloves()
        {
            // Set the base ES value
            _baseES = 61;
            // if the value < 49, it is shit
            minFlat = 9;
            // if the value > 141, it is non existant technically
            maxFlat = 48;
            // init the flattiers dictionary
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                { 48, 30},
                { 29, 20},
                { 19, 16},
                { 15, 13},
                { 12, 9}
            };
        }
    }

    public class SorcererBoots : Armour
    {
        public SorcererBoots()
        {
            // Set the base ES value
            _baseES = 64;
            // if the value < 49, it is shit
            minFlat = 9;
            // if the value > 141, it is non existant technically
            maxFlat = 48;
            // init the flattiers dictionary
            flatTiers = new SortedList<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)))
            {
                { 48, 30},
                { 29, 20},
                { 19, 16},
                { 15, 13},
                { 12, 9}
            };
        }
    }

}
