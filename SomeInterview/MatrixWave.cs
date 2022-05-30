using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    // For world like "MATRIX", and 3 rows it can look like:
    // M     I
    //  A  R  X
    //   T
    // Point is to return then string: MIARXT

    public class MatrixWave
    {
        public static string Wave(string input, int rows)
        {
            int currentRow = 0;
            bool IncreasingMode = true;
            List<string> strings = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (strings.Count < rows)
                    strings.Add("");

                strings[currentRow] += input[i];

                if ((currentRow == 0 && !IncreasingMode) || currentRow == rows - 1)
                    IncreasingMode = SwitchMode(IncreasingMode);

                if (IncreasingMode)
                    currentRow++;
                else
                    currentRow--;
            }

            return String.Join("", strings);
        }

        private static bool SwitchMode(bool IncreasingMode) => IncreasingMode ? false : true;
    }
}
