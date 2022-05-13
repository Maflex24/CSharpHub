using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class QuickSort
    {
        public int[] Sort(int[] array)
        {
            if (array.Length < 2)
                return array;

            int pivot = array[0];
            int[] pivotArray = array.Where(v => v == pivot).ToArray();

            var less = array.Where(v => v < pivot).ToArray();
            var greater = array.Where(v => v > pivot).ToArray();


            return new List<int>()
                .Concat(Sort(less))
                .Concat(pivotArray)
                .Concat(Sort(greater))
                .ToArray();
        }
    }
}
