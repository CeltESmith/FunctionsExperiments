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
            PalindromeChecker cat = new PalindromeChecker();
            PalindromeChecker abba = new PalindromeChecker();
            PalindromeChecker racecar = new PalindromeChecker();

            bool resultCat = cat.IsPalindrome("Cat");
            Console.WriteLine(resultCat);

            bool resultAbba = abba.IsPalindrome("abba");
            Console.WriteLine(resultAbba);

            bool resultRaceCar = racecar.IsPalindrome("RaceCar");
            Console.WriteLine(resultRaceCar);
        }
    }
}