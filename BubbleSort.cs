using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class BubbleSort
    {
        public async Task<int[]> Sort(int[] array)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Started Bubble sorting");
            var t = await Task.Run(() =>
            {
                while (true)
                {
                    bool wasSwapped = false;

                    for (int i = array.Length - 1; i > 0; i--)
                    {
                        if (array[i - 1] > array[i])
                        {
                            int lower = array[i];
                            int greater = array[i - 1];
                            array[i - 1] = lower;
                            array[i] = greater;
                            wasSwapped = true;
                        }
                    }

                    if (!wasSwapped)
                        return array;
                }
            });

            sw.Stop();
            Console.WriteLine($"End Bubble sorting in {sw.ElapsedMilliseconds} ms.");
            return t;

        }
    }
}
