using System;

namespace HybridCalculator
{
    class MainMenu
    {
        // Armour object to determine the baseES with
        Armour item;

        public void Menu()
        { 
            int itemID = Choices();

            switch(itemID)
            {
                case 1:
                    item = new Regalia();
                    break;
                case 2:
                    item = new Circlet();
                    break;
                case 3:
                    item = new SpiritShield();
                    break;
            }
            //Get the current flat ES value
            int flatES = EnterESValue();
            //Determine what the maximum potential ES value is and return it
            int maxFlatES = item.FlatTiers(flatES);
            //Ask if armour has stun recovery or not
            string stunChoice = EnterStunChoice();
            //If the value is outside of the acceptable range then return to main menu, else  determine stun recovery value
            if (maxFlatES != 0)
            {
                bool hasStun = HasStunRecovery.Decision(item.BaseES, maxFlatES, stunChoice);
            }
            int minHybridRoll = 0;
            int maxHybridRoll = 0;
            bool isHybrid;
            DetermineIncreasedES.Calculate(item.BaseES, flatES, minHybridRoll, maxHybridRoll, isHybrid);
        }

        private int Choices()
        {
            //User to select choice of armour to get a BaseES value that will remain unchanged for the duration of the program

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Vaal Regalia");
            Console.WriteLine("2) Hubris Circlet");
            Console.WriteLine("3) Titanium Spirit Shield");

            // Parse what we read from the console 
            return int.Parse(Console.ReadLine());
        }

        private int EnterESValue()
        {
            Console.Clear();
            Console.Write("Enter the Increased Flat Energy Shield value: ");
            int flatES = int.Parse(Console.ReadLine());
            return flatES;
        }
        private static string EnterStunChoice()
        {
            Console.Write("Does the item have an '% Increased Stun Recovery' value: y/n ");
            string hybridChoice = Console.ReadLine();
            return hybridChoice;
        }
    }
}
