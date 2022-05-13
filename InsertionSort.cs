using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class InsertionSort
    {
        public int[] Sort(int[] array)
        {
            List<int> toSort = array.ToList();
            List<int> sorted = new List<int>();

            for (int ToSortI = 0; ToSortI < array.Length; ToSortI++)
            {
                for (int sortedI = 0; sortedI < sorted.Count; sortedI++)
                {

                }
            }


            //while (toSort.Count > 0)
            //{
            //    int sortingValue = toSort[0];

            //    for (int i = 0; i < sorted.Count; i++)
            //    {
            //        if (sortingValue >= sorted[i])
            //        {
            //            sorted.Insert(i, sortingValue);
            //            toSort.Remove(sortingValue);
            //            break;
            //        }
            //    }
            //}

            return sorted.ToArray();
        }
    }
}
