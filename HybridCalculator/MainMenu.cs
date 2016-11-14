using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class MainMenu
    {
        public static bool Choices()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Vaal Regalia");
            Console.WriteLine("2) Hubris Circlet");
            Console.WriteLine("3) Titanium Spirit Shield");
            Console.WriteLine("4) Exit");
            string choice = Console.ReadLine();

            if (choice == "1") //Chest
            {
                Regalia vaal = new Regalia();
                WhichFlatTier.ChestFlatTier(vaal.baseES);
                return true;
            }
            if (choice == "2") //Helmet
            {
                Circlet hubris = new Circlet();
                WhichFlatTier.HelmetFlatTier(hubris.baseES);
                return true;
            }
            if (choice == "3") //Shield
            {
                SpiritShield titanium = new SpiritShield();
                WhichFlatTier.ShieldFlatTier(titanium.baseES);
                return true;
            }
            if (choice == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
