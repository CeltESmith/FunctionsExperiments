using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExperiments
{
    public class ArrayManipulation
    {
        public int[] GetMinAndMaxOfArray(int[] array)
        {
            int[] maNMiArray = new int[] { array.Min(), array.Max() };

            return maNMiArray;
        }
    }
}
