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
            if (array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
            }
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
        //Quest05
        public Person GetMinAgePerson(Person[] waifuArray)
        {
            Person personWithMinAge = waifuArray[0];
            for (int i = 1; i < waifuArray.Length; i++)
            {
                Person personIntermediate = waifuArray[i];
                if (personWithMinAge.age > personIntermediate.age)
                {
                    personWithMinAge = waifuArray[i];
                }
            }
            for (int i = 0; i < waifuArray.Length; i++)
            {
                if (personWithMinAge == waifuArray[i])
                {
                    return waifuArray[i];
                }
            }
            return personWithMinAge;
        }
        //Quest06
        public int GetMaxValue(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        //Quest07
        public int GetMaxIndex(int[] array)
        {
            int maxValue = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        //Quest08
        public int GetMinIndex(int[] array)
        {
            int minValue = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        //Quest09
        public int GetIndex(int[] array, int desiredNumber)
        {
            int desiredIndex = -1;
            for (int i = 1; i < array.Length; i++)
            {
                if (desiredNumber == array[i])
                {
                    desiredIndex = i;
                    return desiredIndex;
                }
            }
            return desiredIndex;
        }
        //Quest10
        public bool IsEqual(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (!(arrayOne[i] == arrayTwo[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        //Quest11
        public int GetEvenCount(int[] array)
        {
            int countOfNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    countOfNumbers++;
                }
            }
            return countOfNumbers;
        }
        //Quest12
        public int[] GetEvenArray(int[] array)
        {
            int countOfNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    countOfNumbers++;
                }
            }
            int[] evenArray = new int[countOfNumbers];
            for (int i = 0, j = 0; j < evenArray.Length && i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenArray[j] = array[i];
                    j++;
                }
            }
            return evenArray;
        }
    }
}
