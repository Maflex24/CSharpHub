using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class WaitingInfo
    {
        public static async Task WaitDots(int seconds, string waitingFor = "")
        {
            Console.Write(waitingFor == "" ? "Waiting..." : $"Waiting for {waitingFor}");

            for (int i = seconds; i > 0; i--)
            {
                await Task.Delay(1000);
                Console.Write(".");
            }

            Console.WriteLine();
        }

        public static async Task WaitNumbers(int seconds, string waitingFor = "", string symbol = "")
        {
            Console.WriteLine(waitingFor == "" ? "Waiting..." : $"Waiting for {waitingFor}");

            for (int i = seconds; i > 0; i--)
            {
                await Task.Delay(1000);
                Console.Write($"{i}{symbol} ");
            }

            Console.WriteLine();
        }
    }
}
