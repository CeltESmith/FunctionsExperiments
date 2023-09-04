using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class IterationCalculator
    {
        public int NumberOfOccurances(string sentince, char letter)
        {
            string lowerSentince = sentince.ToLower();
            char[] sentinceArray = lowerSentince.ToCharArray();
            int occurances = 0;


             foreach (char c in sentinceArray)
            {
                if (c == letter)
                { occurances++; }

            }
             return occurances;
        }
    }
}
