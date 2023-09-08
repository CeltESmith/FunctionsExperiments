using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace FunctionsExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysCalculator age= new DaysCalculator();

            decimal myAge = age.ConvertYearsToDays(33.5m);
            Console.WriteLine($"My age in days is: {myAge}.");
        }
    }
}