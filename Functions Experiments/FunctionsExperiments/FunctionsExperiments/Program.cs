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
            StringManipulations world= new StringManipulations();
            StringManipulations dev = new StringManipulations();

            string revWorld=world.ReverseWord("Hello World!");
            string revDev=dev.ReverseWord("Developer");

            Console.WriteLine($"This is Hello World! back wards:    {revWorld}");
            Console.WriteLine($"This is Developer back words:      {revDev}");
        }
    }
}