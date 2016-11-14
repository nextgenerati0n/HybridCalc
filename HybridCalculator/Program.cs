using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //This is where you'll start, duh
            MainMenu main = new MainMenu();

            while (true)
                main.Menu();
        }
    }
}
