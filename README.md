# Sorted Algorithms times:

Horizontal line is number of array element to sorted.
Vertical line is time in miliseconds to complete sorting.

![graph](https://github.com/Maflex24/CSharpHub/blob/SortingAlgorithms/AlgorithmGraph.png "Graph of algorithms times")

## Qucik Sort
Fastest algorithm.  
We get (for example) first element of array, like 5.

All values equal to 5 are in pivot array.  
Now we create to arrays  
less - all numbers below pivot  
greater - all numbers above pivot  
  
We returned `Sort(less[]) + pivot[] + Sort(greater[])`  
So it's recursion here.  
   
`If array.Lenght < 2` then we can return this array. We divide array until we get this situation.  

### Simulation:
5 5 6 4 2 1   
4 2 1 | 5 5 | 6  
2 1 | 4 || 55 || 6  
1 | 2 || 4 ||| 5 5 ||| 6   

## Selection Sort
Create two collections: `sorted`, and `toSort`. `toSort` has elements of input array.
Now we loop in `toSort` collection to find smallest value. We move this value and add to `sorted` collection. Repeat while `toSort` isn't empty.

### Simulation
toSort: 5 5 6 4 2 1 | 5 5 6 4 2 | 5 5 6 4 | 5 5 6 | 5 6 | 6 |  
sorted: 1 | 1 2 | 1 2 4 | 1 2 4 5 | 1 2 3 4 5 5 | 1 2 3 4 5 5 6

## Bubble Sort
Loop from end of the array to beginning. Compare elements, if next element (higher index) is smaller, swap them. Repear loop until not swap elements. So it needs bool value to know when it's time to stop looping.

### Simulation
5 5 6 4 2 1 |1 5 5 6 4 2 | 1 2 5 5 6 4 | 1 2 4 5 5 6

## Insertion Sort
It gets firts element from unsorted collection and loop from sorted collection, to find place when previousSortedElement >= checkingElement <= nextElement.

### Simulation
toSort: 5 5 6 4 2 1 | 5 6 4 2 1 | 6 4 2 1 | 4 2 1 | 2 1 | 1 |  
Sorted: | 5 | 5 5 | 5 5 6 | 4 5 5 6 | 2 4 5 5 6 | 1 2 4 5 5 6
