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
            item.FlatES = EnterESValue();
            //Determine what the maximum potential ES value is and return it
            item.FlatTiers(item.FlatES);
            //Ask if armour has stun recovery or not
            string stunChoice = EnterStunChoice();
            //If the value is outside of the acceptable range then return to main menu, else  determine stun recovery value
            HasStunRecovery(stunChoice);
            
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
        private string EnterStunChoice()
        {
            Console.Write("Does the item have an '% Increased Stun Recovery' value: y/n ");
            string hybridChoice = Console.ReadLine();
            return hybridChoice;
        }
        public bool HasStunRecovery(string stunChoice)
        {
            if (stunChoice == "y")
            {
                CalculateHybrid.Calculate(item.BaseES, item.FlatES);
                return true;
            }
            else if (stunChoice == "n")
            {
                DetermineIncreasedES.Calculate(item.BaseES, item.FlatES);
                return false;
            }
            else
            {
                Console.WriteLine("That was a simple choice between 'y' and 'n', try again dummy!");
                return false;
            }
        }
    }
}
