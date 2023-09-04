using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            string lowerWord = word.ToLower();
            char[] chars= lowerWord.ToCharArray();
            char[] reverse = Enumerable.Reverse(chars).ToArray();
            string reverseWord = "";

        foreach (char c in reverse)
            {
                reverseWord += c;
            }

            if (reverseWord == lowerWord)
            {
                return true;
            }
            return false;
        }
    }
}
