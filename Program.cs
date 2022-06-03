using System.Diagnostics;
using CSharpHub;

Random random = new Random();
//List<int> elementsQty = new List<int>() { 1000, 2000, 4000, 8000, 16000, 32000, 64000, 128000, 256000, 512000, 1024000000 };
List<int> elementsQty = new List<int>() { 1000, 2000, 4000, 8000, 16000, 32000, };


foreach (var elementsValue in elementsQty)
{
    List<int> listOfNumbers = new List<int>();

    //just fill many numbers
    for (int i = elementsValue; i > 0; i--)
    {
        listOfNumbers.Add(random.Next(1, elementsValue));
    }

    int[] numbers = listOfNumbers.ToArray();
    Console.WriteLine($"Testing sorting algorithms for {numbers.Length} elements");

    Stopwatch quickWatch = Stopwatch.StartNew();
    QuickSort quickSort = new QuickSort();
    Console.WriteLine("Started Quick sorting");
    var quickSorted = quickSort.Sort(numbers);
    Console.WriteLine($"End Quick sorting in {quickWatch.ElapsedMilliseconds} ms.");


    SelectionSort selectionSort = new SelectionSort();
    BubbleSort bubbleSort = new BubbleSort();
    InsertionSort insertionSort = new InsertionSort();
    var selection = selectionSort.Sort(numbers);
    var bubble = bubbleSort.Sort(numbers);
    var insertion = insertionSort.Sort(numbers);


    var selectionSorted = await selection;
    var bubbleSorted = await bubble;
    var insertionSorted = await insertion;


    if (selectionSorted.Length != numbers.Length)
        throw new Exception();

    if (quickSorted.Length != numbers.Length)
        throw new Exception();

    if (bubbleSorted.Length != numbers.Length)
        throw new Exception();

    if (insertionSorted.Length != numbers.Length)
        throw new Exception();

    Console.WriteLine();

    Console.WriteLine("Check is sorted correct:");
    quickSorted.ConsolePrintFirst(5);
    quickSorted.ConsolePrintLast(5);
    selectionSorted.ConsolePrintFirst(5);
    selectionSorted.ConsolePrintLast(5);
    bubbleSorted.ConsolePrintFirst(5);
    bubbleSorted.ConsolePrintLast(5);
    insertionSorted.ConsolePrintFirst(5);
    insertionSorted.ConsolePrintLast(5);

    Console.WriteLine();



}


