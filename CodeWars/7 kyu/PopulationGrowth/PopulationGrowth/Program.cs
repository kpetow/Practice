using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowth
{
    class Program
    {
        static void Main(string[] args)
        {
            int p0 = 1500000;
            double percent = 0.25;
            int aug = 1000;
            int p = 2000000;

            int year = 0;

            double pop = Convert.ToDouble(p0);
            double mover = Convert.ToDouble(aug);
            double final = Convert.ToDouble(p);

            while (pop < final)
            {
                pop = Math.Floor((1 + percent / 100) * pop + mover);
                year++;
            }
            Console.WriteLine("Years to hit target population: " + year);
        }
    }
}
