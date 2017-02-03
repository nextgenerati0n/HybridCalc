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
            item.FlatEs = EnterFlatEsValue();
            //Determine what the maximum potential ES value is and return it
            item.FlatTiers(item.FlatEs);
            //Ask if armour has stun recovery or not
            string stunChoice = EnterStunChoice();
            item.IncEs = EnterIncEsValue();
            //If the value is outside of the acceptable range then return to main menu, else  determine stun recovery value
            HasStunRecovery(stunChoice);
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
            Console.Write("Does the item have an '% Increased Stun Recovery' value: y/n ");
            string hybridChoice = Console.ReadLine();
            return hybridChoice;
        }
        private int EnterIncEsValue()
        {
            Console.Write("What is the maximum increased ES: ");
            int incES = int.Parse(Console.ReadLine());
            return incES;
        }
        public void HasStunRecovery(string stunChoice)
        {
            if (stunChoice == "y")
            {
                item.Hybrid = true;
                Calculate(item.BaseES, item.FlatEs);
                //return true;
            }
            else if (stunChoice == "n")
            {
                item.Hybrid = false;
                ArmourRepository.RetrieveIncEs(item);
                //return false;
            }
            else
            {
                Console.WriteLine("That was a simple choice between 'y' and 'n', try again dummy!");
                //return false;
            }
        }

        public static void Calculate(int baseES, int flatES)
        {
            //Ask the user to input their current Increased Energy Shield value
            Console.Write("What is the maximum increased ES: ");
            int incES = int.Parse(Console.ReadLine());
            int maxIncES = 0;
            int minIncES = 0;

            if (incES < 65)
            {
                Console.WriteLine("It's garbage, go get some new armour");
                Console.ReadKey();
                return;
            }
            else if (incES <= 82)
            {
                minIncES = 65;
                maxIncES = 82;
                Helpers.Desc(4);
            }
            else if (incES <= 100)
            {
                minIncES = 83;
                maxIncES = 100;
                Helpers.Desc(3);
            }
            else if (incES <= 120)
            {
                minIncES = 101;
                maxIncES = 120;
                Helpers.Desc(2);
            }
            else if (incES <= 132)
            {
                minIncES = 121;
                maxIncES = 132;
                Helpers.Desc(1);
            }
            else
            {
                Console.WriteLine("It is not possible to get higher than 132% on a non-hybrid item, try again");
                Console.WriteLine("\nPress 1 to try again or any other key to return to the main menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    Calculate(baseES, flatES);
                else
                    return;

                Console.ReadKey();
            }
            //MinMaxES.Calculate(minIncES, maxIncES, baseES, flatES);
        }

        public static void Calculate(int baseES, int flatES, int minHybridRoll, int maxHybridRoll)
        {
            //Ask the user to input their current Increased Energy Shield value
            Console.Write("What is the maximum increased ES: ");
            int incES = int.Parse(Console.ReadLine());
            int maxIncES = incES - minHybridRoll;
            int minIncES = incES - maxHybridRoll;

            if (maxIncES < 65 || minIncES < 65)
            {
                Console.WriteLine("It's garbage, go get some new armour");
                Console.ReadKey();
                return;
            }
            else if (maxIncES <= 82 && minIncES > 65)
            {
                minIncES = 65;
                maxIncES = 82;
                Helpers.Desc(4);
            }
            else if (maxIncES <= 100 && minIncES > 82)
            {
                minIncES = 83;
                maxIncES = 100;
                Helpers.Desc(3);
            }
            else if (maxIncES <= 120 && minIncES > 100)
            {
                minIncES = 101;
                maxIncES = 120;
                Helpers.Desc(2);
            }
            else if (maxIncES <= 132 && minIncES > 120)
            {
                minIncES = 121;
                maxIncES = 132;
                Helpers.Desc(1);
            }
            else
            {
                Console.WriteLine("That could be one of 2 different Increased Maximum ES tiers, divine and try again");
                Console.WriteLine("\nPress 1 to try again or any other key to return to the main menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    Calculate(baseES, flatES, minHybridRoll, maxHybridRoll);
                else
                    return;

                Console.ReadKey();
            }
            MinMaxES.Calculate(minIncES, maxIncES, baseES, flatES, minHybridRoll, maxHybridRoll);
        }
    }
}
