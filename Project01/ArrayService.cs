using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class ArrayService
    {
        //Quest01
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
        //Quest02
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        //Quest03
        public int GetSum(int[] inputArray)
        {
            int result = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                result += inputArray[i];
            }
            return result;
        }
        //Quest04
        public double GetAverageAge(Person[] waifuArray)
        {
            int sum = 0;
            for (int i = 0; i < waifuArray.Length; i++)
            {
                Person person = waifuArray[i];
                sum += person.age;
            }
            double averageAge = (double)sum / waifuArray.Length;
            return averageAge;
        }
    }
}
