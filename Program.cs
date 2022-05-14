using System.Diagnostics;
using CSharpHub;

int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] namesArr = new string[] { "Adam", "Eve", "Lucia", "Diana", "Bianca", "Cecila", "Bob", "John" };
List<string> namesList = new List<string>() { "Adam", "Eve", "Lucia", "Diana", "Bianca", "Cecila", "Bob", "John" };

numbers.ConsolePrint();
numbers.ConsolePrintFirst(5);
numbers.ConsolePrintLast(5);

Console.WriteLine();

namesArr.ConsolePrint();
namesArr.ConsolePrintFirst(5);
namesArr.ConsolePrintLast(5);

Console.WriteLine();

namesList.ConsolePrint();
namesList.ConsolePrintFirst(5);
namesList.ConsolePrintLast(5);

