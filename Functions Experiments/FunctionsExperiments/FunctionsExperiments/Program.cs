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
            StringFormatingSystem test1 = new StringFormatingSystem();
            StringFormatingSystem test2 = new StringFormatingSystem();

            string value=test1.FormatPhoneNumber(StringFormatingSystem.NumFormat.Dashes, "17164329870");
            Console.WriteLine($"The returned value is {value}");
            Console.WriteLine();

            string falseValue = test1.FormatPhoneNumber(StringFormatingSystem.NumFormat.Dashes, "27164329870");
            Console.WriteLine($"The returned value is {falseValue}");
            Console.WriteLine();

            string falseValue2 = test1.FormatPhoneNumber(StringFormatingSystem.NumFormat.Dashes, "171649870");
            Console.WriteLine($"The returned value is {falseValue2}");
            Console.WriteLine();

            string value2 = test2.FormatPhoneNumber(StringFormatingSystem.NumFormat.Parenthesis, "17164329870");            
            Console.WriteLine($"The returned value is {value2}");
            Console.WriteLine();
        }
    }
}