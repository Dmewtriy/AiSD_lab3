using System;

namespace lab3
{
    public class ArrayGenerator
    {
        private static readonly Random _random = new Random();

        public static int[] GenerateRandomSequence(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = _random.Next(1000, 10000);
            }
            return array;
        }

        public static int[] GenerateSortedSequence(int size)
        {
            int[] array = GenerateRandomSequence(size);
            Array.Sort(array);
            return array;
        }

        public static int[] GenerateReverseSortedSequence(int size)
        {
            int[] array = GenerateRandomSequence(size);
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}
