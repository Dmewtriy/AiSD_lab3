using System;
using System.Diagnostics;

public class SortAlgorithms
{
    private readonly int[] _array;

    public SortAlgorithms(int[] array)
    {
        _array = (int[])array.Clone();
    }

    private (int[] SortedArray, long TimeoInMs) Measure(string name, Func<int[], int[]> algorithm)
    {
        int[] copy = (int[])_array.Clone();

        Stopwatch stopwatch = Stopwatch.StartNew();

        int[] result = algorithm(copy);

        stopwatch.Stop();


        Console.WriteLine($"{name}: {stopwatch.ElapsedMilliseconds} мс");

        return (result, stopwatch.ElapsedMilliseconds);
    }


    public (int[] SortedArray, long TimeoInMs) SelectionSort()
        => Measure("Selection Sort", SelectionSort);

    private int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                    min = j;
            }

            (arr[i], arr[min]) = (arr[min], arr[i]);
        }

        return arr;
    }

    public (int[] SortedArray, long TimeoInMs) InsertionSort()
        => Measure("Insertion Sort", InsertionSort);

    private int[] InsertionSort(int[] array)
    {
        int key = 0, j;
        for (int i = 1; i < array.Length; i++)
        {
            key = array[i];
            j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j -= 1;
            }

            array[j + 1] = key;
        }

        return array;
    }

    public (int[] SortedArray, long TimeoInMs) QuickSort()
        => Measure("Quick Sort", QuickSort);


    private int[] QuickSort(int[] arr)
    {
        QuickSortRecursive(arr, 0, arr.Length - 1);
        return arr;
    }

    private void QuickSortRecursive(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int pivot = arr[(left + right) / 2];

        int i = left;
        int j = right;

        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;

            if (i <= j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                i++;
                j--;
            }
        }

        QuickSortRecursive(arr, left, j);
        QuickSortRecursive(arr, i, right);
    }


    public (int[] SortedArray, long TimeoInMs) HeapSort()
        => Measure("Heap Sort", HeapSort);

    private int[] HeapSort(int[] array)
    {
        int n = array.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            Heapify(array, i, 0);
        }

        return array;
    }

    private void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;

            Heapify(array, n, largest);
        }
    }


    public (int[] SortedArray, long TimeoInMs) RadixSort()
        => Measure("Radix Sort", RadixSortInternal);

    private int[] RadixSortInternal(int[] arr)
    {
        if (arr.Length <= 1) return arr;

        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max) max = arr[i];

        int[] temp = new int[arr.Length];

        for (int exp = 1; max / exp > 0; exp *= 10)
        {
            int[] count = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                temp[--count[digit]] = arr[i];
            }

            Array.Copy(temp, arr, arr.Length);
        }

        return arr;
    }

}