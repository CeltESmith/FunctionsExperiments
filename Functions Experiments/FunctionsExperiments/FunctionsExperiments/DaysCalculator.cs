using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class DaysCalculator
    {
        public decimal ConvertYearsToDays(decimal year)
        {
            return year * 365.25m;
        }
    }
}
