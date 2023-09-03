using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class StringManipulations
    {
        public string ReverseWord(string word)
        {
            char[] reverseChars = word.Reverse().ToArray();
            string reversedString = "";

            foreach (char c in reverseChars)
            {
                reversedString += c;
            }
            return reversedString;
        }
    }
}
