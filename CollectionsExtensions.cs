using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public static class CollectionsExtensions
    {
        public static void ConsolePrint<T>(this IEnumerable<T> collection) => Console.WriteLine(String.Join(", ", collection));
        public static void ConsolePrintFirst<T>(this IEnumerable<T> collection, int howMany)
        {
            if (howMany > collection.Count())
                howMany = collection.Count();

            List<T> checkingList = collection.ToList();
            List<T> outputList = new List<T>();

            for (int i = 0; i < howMany; i++)
            {
                outputList.Add(checkingList[i]);
            }

            Console.WriteLine(String.Join(", ", outputList));
        }

        public static void ConsolePrintLast<T>(this IEnumerable<T> collection, int howMany)
        {
            if (howMany > collection.Count())
                howMany = collection.Count();

            List<T> checkingList = collection.ToList();
            List<T> outputList = new List<T>();

            for (int i = checkingList.Count - howMany; i < checkingList.Count; i++)
            {
                outputList.Add(checkingList[i]);
            }

            Console.WriteLine(String.Join(", ", outputList));
        }
    }
}
