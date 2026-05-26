using System;
using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3
{
    class Program
    {
        static void Main()
        {
            int[] numbers = ArrayGenerator.GenerateReverseSortedSequence(100_000);

            SortAlgorithms algorithms = new SortAlgorithms(numbers);

            int[] selectionSorted = algorithms.SelectionSort().SortedArray;

            int[] insertSorted = algorithms.InsertionSort().SortedArray;

            int[] quickSorted = algorithms.QuickSort().SortedArray;

            int[] heapSorted = algorithms.HeapSort().SortedArray;

            int[] radixSorted = algorithms.RadixSort().SortedArray;

        }

    }
}