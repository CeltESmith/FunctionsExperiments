using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class StringFormatingSystem
    {
        //set up enum, output names to allow for both formatted returns.
        public enum NumFormat{Dashes = 0, Parenthesis = 1 };

        string formatedDashes = "";
        string formatedParenthesis = "";

        //create function for formating phone number
        public string FormatPhoneNumber(NumFormat format, string number)
        {
            //chack for valid number must start with 1 and contain 11 values
            int lengthOfNumber = number.Length;
            string firstNumber = number.Substring(0, 1);
            NumFormat formatType = format;

            if (lengthOfNumber == 11 && firstNumber == "1")
            {
                //See if it is dash format and create the formated string
                if (formatType == NumFormat.Dashes)
                {
                    string firstPosition = number.Substring(0, 1);
                    string secondPosition = number.Substring(1, 3);
                    string thirdPosition = number.Substring(4, 3);
                    string remainder = number.Substring(7);
                    Console.WriteLine($"The Format is {firstPosition}-{secondPosition}-{thirdPosition}-{remainder}");
                }

                //See if it is Parenthesis format and create the formated string
                if (formatType == NumFormat.Parenthesis)
                {
                    string firstPosition = number.Substring(0, 1);
                    string secondPosition = number.Substring(1, 3);
                    string thirdPosition = number.Substring(4, 3);
                    string remainder = number.Substring(7);
                    Console.WriteLine($"The Format is {firstPosition}({secondPosition}){thirdPosition}-{remainder}");
                }
            }
            else
            {
                //put in the right info message
                Console.WriteLine("You have entered an invalid Phone number.");
            }
            //Return the initial phone number provided
            return number;
        }
        
    }
}
