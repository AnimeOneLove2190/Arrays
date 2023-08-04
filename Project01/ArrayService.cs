using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class ArrayService
    {
        public int[] GetRandomArray(int arraySize, int minValue, int maxValue)
        {
            int[] randomArray = new int[arraySize];
            Random godOfNumbers = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = godOfNumbers.Next(minValue, maxValue);
            }
            return randomArray;
        }
        public void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
