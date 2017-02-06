using System;

namespace HybridCalculator
{
    public class MainMenu
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
            //Get the current flat ES value of the item
            item.FlatEsRoll = EnterFlatEsValue();
            //Determine what the maximum potential Flat ES value is and return it
            item.FlatTiers();
            //Ask if armour has stun recovery or not
            string stunChoice = EnterStunChoice();
            //If the value is outside of the acceptable range then return to main menu, else  determine stun recovery value
            HasStunRecovery(stunChoice);
            //Get the current Increased ES value of the item
            item.IncEsRoll = EnterIncEsValue();
            
            //Determine what the maximum potential Increased ES value is and return it
            item.IncEsTiers();
            item.IncEsFromHybrid();
            MinMaxES.Calculate(item);
            
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

        private int EnterFlatEsValue()
        {
            Console.Clear();
            Console.Write("Enter the Increased Flat Energy Shield value: ");
            int flatES = int.Parse(Console.ReadLine());
            return flatES;
        }
        private string EnterStunChoice()
        {
            Console.Write("Does the item have an '% Increased Stun Recovery' value. y/n: ");
            string hybridChoice = Console.ReadLine();
            return hybridChoice;
        }
        private int EnterIncEsValue()
        {
            Console.Write("What is the maximum increased ES: ");
            int incES = int.Parse(Console.ReadLine());
            return incES;
        }
        private int EnterStunRecoveryValue()
        {
            Console.Write("What is the Roll for % Increased Stun Recovery: ");
            int stunRoll = int.Parse(Console.ReadLine());
            return stunRoll;
        }
        private void HasStunRecovery(string stunChoice)
        {
            if (stunChoice == "y")
            {
                item.IsHybrid = true;
                item.StunRecoveryRoll = EnterStunRecoveryValue();
                item.StunRecoveryTiers();
                //MainMenu.Calculate(item);
                //return true;
            }
            else if (stunChoice == "n")
            {
                item.IsHybrid = false;
                //return false;
            }
            else
            {
                Console.WriteLine("That was a simple choice between 'y' and 'n', try again dummy!");
                //return false;
            }
        }
    }
}
