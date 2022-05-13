using System.Diagnostics;
using CSharpHub;

Random random = new Random();
List<int> elementsQty = new List<int>() { 1000, 2000, 4000, 8000, 16000, 32000, 64000, 128000 };


foreach (var elementsValue in elementsQty)
{
    List<int> listOfNumbers = new List<int>();

    //just fill many numbers
    for (int i = elementsValue; i > 0; i--)
    {
        listOfNumbers.Add(random.Next(1, elementsValue / 10));
    }

    int[] numbers = listOfNumbers.ToArray();
    Console.WriteLine($"Testing sorting algorithms for {numbers.Length} elements");

    Stopwatch quickWatch = Stopwatch.StartNew();
    QuickSort quickSort = new QuickSort();
    var quickSorted = quickSort.Sort(numbers);
    quickWatch.Stop();
    Console.WriteLine($"QuickSort takes: {quickWatch.ElapsedMilliseconds} ms");


    Stopwatch selectionWatch = Stopwatch.StartNew();
    SelectionSort selectionSort = new SelectionSort();
    var selectionSorted = selectionSort.Sort(numbers);
    selectionWatch.Stop();
    Console.WriteLine($"SelectionSort takes: {selectionWatch.ElapsedMilliseconds} ms");


    Stopwatch bubbleWatch = Stopwatch.StartNew();
    BubbleSort bubbleSort = new BubbleSort();
    var bubbleSorted = bubbleSort.Sort(numbers);
    bubbleWatch.Stop();
    Console.WriteLine($"BubbleSort takes: {bubbleWatch.ElapsedMilliseconds} ms");


    Stopwatch insertionWatch = Stopwatch.StartNew();
    InsertionSort insertionSort = new InsertionSort();
    var insertionSorted = insertionSort.Sort(numbers);
    insertionWatch.Stop();
    Console.WriteLine($"InsertionSort takes: {insertionWatch.ElapsedMilliseconds} ms");

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
    //Console.WriteLine(string.Join(", ", insertionSorted));
    Console.WriteLine();

}


