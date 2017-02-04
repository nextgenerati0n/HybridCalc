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
                Calculate();
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
/*
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
*/
        public void Calculate()
        {
            //Ask the user to input their current Increased Energy Shield value
            Console.Write("What is the maximum increased ES: ");
            item.IncEsRoll = int.Parse(Console.ReadLine());
            int maxIncES = item.IncEsRoll - item.MinHybridEs;
            int minIncES = item.IncEsRoll - item.MaxHybridEs;

            if (maxIncES < 65 || minIncES < 65)
            {
                Console.WriteLine("It's garbage, go get some new armour");
                Console.ReadKey();
                return;
            }
            else if (maxIncES <= 82 && minIncES > 65)
            {
                item.MinIncEs = 65;
                item.MaxIncEs = 82;
                Helpers.Desc(4);
            }
            else if (maxIncES <= 100 && minIncES > 82)
            {
                item.MinIncEs = 83;
                item.MaxIncEs = 100;
                Helpers.Desc(3);
            }
            else if (maxIncES <= 120 && minIncES > 100)
            {
                item.MinIncEs = 101;
                item.MaxIncEs = 120;
                Helpers.Desc(2);
            }
            else if (maxIncES <= 132 && minIncES > 120)
            {
                item.MinIncEs = 121;
                item.MaxIncEs = 132;
                Helpers.Desc(1);
            }
            else
            {
                Console.WriteLine("That could be one of 2 different Increased Maximum ES tiers, divine and try again");
                Console.WriteLine("\nPress 1 to try again or any other key to return to the main menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                    Calculate();
                else
                    return;

                Console.ReadKey();
            }
            MinMaxES.Calculate(item);
        }
    }
}
