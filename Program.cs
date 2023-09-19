

using Algorithms_BinarySearch;

int[] intArray = new int[] { 11, 51, 33, 47, 8, 24, 19, 64, 43, 70, 55, 29, 62, 39, 12, 30, 85, 36, 65, 80 };

var Indexofthenumber= ArrayCustomWrapper.binarySearch(ArrayCustomWrapper.ArraySort(intArray), 80);

Console.WriteLine(Indexofthenumber);

//Console.WriteLine("The sorted Array is :");

//foreach (var item in ArrayCustomWrapper.ArraySort(intArray))
//{
//    Console.WriteLine(item);
//}










        