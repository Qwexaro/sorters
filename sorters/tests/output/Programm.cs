using ru.topacademy.sorters.bubble_sort;
using ru.topacademy.sorters.heap_sort;
using ru.topacademy.sorters.insertion_sort;
using ru.topacademy.sorters.shell_sort;
using System.Numerics;

namespace sorters.tests.output
{
    internal class Programm
    {
        public static void Main() 
        {
            Console.WriteLine("bubble sort:");
            
            int[] arr = { 8, 12, 0, 74, -3 };

            BubbleSort.Bubble_Sort(arr);

            foreach (int i in arr) { Console.Write($"{i} "); }

            Console.WriteLine("\nHeap sort:");
 
            int[] numbers = { 12, 11, 13, 5, 6, 7 };

            HeapSort.heapSort(numbers);

            foreach(int i in numbers) { Console.Write($"{i} "); }

            Console.WriteLine("\nInsertion sort");

            int[] sortedArray = InsertionSort.Insertion_Sort([64, 34, 25, 12, 22, 11, 90]);
            
            foreach (int i in sortedArray) { Console.Write($"{i} "); }

            Console.WriteLine("\nShell sort");

            int[] sortedArray2 = ShellSort.Shell_Sort([64, 14, 15, 12, 22, 11, 90]);

            foreach (int i in sortedArray2) { Console.Write($"{i} "); }
        }
    }
}
