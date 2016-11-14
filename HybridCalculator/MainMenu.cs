using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    WhichFlatTier.ChestFlatTier(item.BaseES);
                    break;
                case 2:
                    item = new Circlet();
                    WhichFlatTier.HelmetFlatTier(item.BaseES);
                    break;
                case 3:
                    item = new SpiritShield();
                    WhichFlatTier.ShieldFlatTier(item.BaseES);
                    break;
            }
        }

        private int Choices()
        {
            //User to select choice of armour to get a BaseES value that will remain unchanged for the duration of the program

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Vaal Regalia");
            Console.WriteLine("2) Hubris Circlet");
            Console.WriteLine("3) Titanium Spirit Shield");
            //Console.WriteLine("4) Exit");

            // Parse what we read from the console 
            return int.Parse(Console.ReadLine());
        }
    }
}
