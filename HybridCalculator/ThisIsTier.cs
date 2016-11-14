using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridCalculator
{
    class ThisIsTier
    {
        public static void Desc(int tier)
        {
            Console.WriteLine($"This is tier {tier}");
        }

        public static void HybridDesc(int tier, string name)
        {
            Console.WriteLine($"\nThe hybrid roll is tier  {tier}: {name}");
        }
    }
}
