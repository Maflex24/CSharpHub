using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            List<int> sorted = new List<int>();
            List<int> toSort = array.ToList();

            while (toSort.Count > 0)
            {
                int smallestValue = toSort[0];
                int smallesValueIndex = 0;

                for (int i = 0; i < toSort.Count; i++)
                {
                    if (toSort[i] < smallestValue)
                    {
                        smallestValue = toSort[i];
                        smallesValueIndex = i;
                    }
                }

                sorted.Add(toSort[smallesValueIndex]);
                toSort.Remove(toSort[smallesValueIndex]);
            }

            return sorted.ToArray();
        }
    }
}
