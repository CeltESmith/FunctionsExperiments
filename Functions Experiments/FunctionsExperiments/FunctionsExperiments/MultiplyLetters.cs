using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class MultiplyLetters
    {
        public string LetterMultiple(string word, char character, int multitude)
        {
            string finalString = "";
            char[] chars= word.ToCharArray();
            int step = 0;

            foreach (char c in chars)
            {
                if (c == character)
                {
                    while (step <= (multitude-2))
                    {
                        finalString += $"{c}";
                        step++;
                        continue;
                    }
                }
                finalString += $"{c}";
                step = 0;
            }
            return finalString;
        }
    }
}
