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
        public async Task<int[]> Sort(int[] array)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Started Selection sorting");
            List<int> sorted = new List<int>();
            List<int> toSort = array.ToList();

            await Task.Run(() =>
            {
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
            });

            sw.Stop();
            Console.WriteLine($"End Selection sorting in {sw.ElapsedMilliseconds} ms.");
            return sorted.ToArray();
        }
    }
}
