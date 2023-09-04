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
            ArrayManipulation firstArray = new ArrayManipulation();

            int[] myMinNMax = firstArray.GetMinAndMaxOfArray(new int[] { 23, 12, 7, 34, 2, 64 });
            Console.WriteLine($"The values entered have a min value of {myMinNMax[0]} and a max of: {myMinNMax[1]}");
        }
    }
}