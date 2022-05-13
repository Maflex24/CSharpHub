using System.Diagnostics;
using CSharpHub;

Random random = new Random();

List<int> listOfNumbers = new List<int>();

//just fill many numbers
for (int i = 0; i < 10000; i++)
{
    int randomNumber = random.Next(1, 50000);
    listOfNumbers.Add(randomNumber);
}

int[] numbers = listOfNumbers.ToArray();

Stopwatch selectionWatch = Stopwatch.StartNew();
SelectionSort selectionSort = new SelectionSort();
var selectionSorted = selectionSort.Sort(numbers);
selectionWatch.Stop();

Stopwatch quickWatch = Stopwatch.StartNew();
QuickSort quickSort = new QuickSort();
var quickSorted = quickSort.Sort(numbers);
quickWatch.Stop();

Stopwatch bubbleWatch = Stopwatch.StartNew();
BubbleSort bubbleSort = new BubbleSort();
var bubbleSorted = bubbleSort.Sort(numbers);
bubbleWatch.Stop();

Stopwatch insertionWatch = Stopwatch.StartNew();
InsertionSort insertionSort = new InsertionSort();
var insertionSorted = insertionSort.Sort(numbers);
insertionWatch.Stop();


if (selectionSorted.Length != numbers.Length)
    throw new Exception();

if (quickSorted.Length != numbers.Length)
    throw new Exception();

if (bubbleSorted.Length != numbers.Length)
    throw new Exception();

if (insertionSorted.Length != numbers.Length)
    throw new Exception();

//Console.WriteLine(string.Join(", ", selectionSorted));
//Console.WriteLine(string.Join(", ", quickSorted));
//Console.WriteLine(string.Join(", ", bubbleSorted));

Console.WriteLine($"Selection watch: {selectionWatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Quick watch: {quickWatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Bubble watch: {bubbleWatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Insertion watch: {insertionWatch.ElapsedMilliseconds} ms");