using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub.SomeInterview
{
    public class SeparateOddNumbers
    {
        public static string Separate(string numbers)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if ((int)numbers[i] % 2 != 0 && (int)numbers[i + 1] % 2 != 0)
                {
                    output.Append(numbers[i] + "-");
                    continue;
                }

                output.Append(numbers[i]);
            }

            output.Append(numbers[numbers.Length - 1]);

            return output.ToString();
        }
    }
}
