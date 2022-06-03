﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class InsertionSort
    {
        public async Task<int[]> Sort(int[] array)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Started Insertion sorting");
            List<int> unSorted = array.ToList();
            List<int> sorted = new List<int>();

            await Task.Run(() =>
            {

                while (unSorted.Count > 0)
                {
                    int checkingNumber = unSorted[0];

                    if (sorted.Count == 0)
                    {
                        sorted.Add(checkingNumber);
                        unSorted.Remove(checkingNumber);
                        continue;
                    }

                    for (int i = 0; i < sorted.Count; i++)
                    {
                        if (checkingNumber >= sorted[i] && i < sorted.Count - 1) // can compare next value
                        {
                            if (checkingNumber <= sorted[i + 1])
                            {
                                sorted.Insert(i + 1, checkingNumber);
                                unSorted.Remove(checkingNumber);
                                break;
                            }
                        }

                        if (checkingNumber >= sorted[i] && i == sorted.Count - 1) // it's last i of sorted list
                        {
                            sorted.Add(checkingNumber);
                            unSorted.Remove(checkingNumber);
                            break;
                        }

                        if (i == sorted.Count - 1) // if all sorted values was bigger than checking number
                        {
                            sorted.Insert(0, checkingNumber);
                            unSorted.Remove(checkingNumber);
                        }

                    }
                }
            });

            sw.Stop();
            Console.WriteLine($"End Insertion sorting in {sw.ElapsedMilliseconds} ms.");
            return sorted.ToArray();
        }
    }
}