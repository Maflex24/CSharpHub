using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class SurfaceCheckAlgorithm
    {
        public int MaxSurface(int[] array)
        {
            List<int> surfaces = new List<int>();
            int currentSurface = 0;

            for (int i = array.Min(); i <= array.Max(); i++)
            {
                foreach (var element in array)
                {
                    if (element >= i)
                    {
                        currentSurface += i;
                        continue;
                    }

                    surfaces.Add(currentSurface);
                    currentSurface = 0;
                }

                surfaces.Add(currentSurface);
                currentSurface = 0;
            }

            return surfaces.Max();
        }
    }
}
