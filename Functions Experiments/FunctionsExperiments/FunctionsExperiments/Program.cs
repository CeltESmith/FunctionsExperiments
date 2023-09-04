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
            MultiplyLetters myWord = new MultiplyLetters();

            string eManip = myWord.LetterMultiple("hello world!", 'e', 5);
            Console.WriteLine($"hello world with manipulated multiple of e is : {eManip}");

            string oManip = myWord.LetterMultiple("hello world!", 'o', 3);
            Console.WriteLine($"hello world with manipulated multiple of o is: {oManip}");
        }
    }
}