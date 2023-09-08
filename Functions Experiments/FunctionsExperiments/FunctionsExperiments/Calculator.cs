using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class Calculator
    {
        public decimal CalculateMean(decimal[] valueArray)
        {
            decimal sumNum = 0;
            decimal totalValues = 0;

            foreach(var value in valueArray)
            {
                sumNum += value;
                totalValues++;
            }
            return sumNum / totalValues;
        }

    }
}
