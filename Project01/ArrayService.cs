﻿using System;
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
        public void PrintArrayNumber(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        //Quest03
        public int GetSum(int[] inputArray)
        {
            if (inputArray == null)
            {
                return 0;
            }
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
            if (waifuArray == null)
            {
                return 0;
            }
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
            //Верхняя граница костыля
            if (waifuArray == null || waifuArray.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            //Нижняя граница костыля
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
            //Верхняя граница костыля
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return 0;
            }
            //Нижняя граница костыля
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
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
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
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return -1;
            }
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
            for (int i = 0; i < array.Length; i++)
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
            if (arrayOne == null && arrayTwo == null)
            {
                return true;
            }
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
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return 0;
            }
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
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
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
        //Quest14
        public void PrintArrayText(string[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }
        public string[] GetNameArray(Person[] waifuArray)
        {
            if (waifuArray == null || waifuArray.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            string[] nameArray = new string[waifuArray.Length];
            for (int i = 0; i < waifuArray.Length; i++)
            {
                Person intermediatePerson = waifuArray[i];
                nameArray[i] = intermediatePerson.name;
            }
            return nameArray;
        }
        //Quest15
        public int[] GetArrayWithNewLenght(int[] array, int newLenght)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arrayWithNewLenght = new int[newLenght];
            if (arrayWithNewLenght.Length == array.Length)
            {
                return array;
            }
            if (arrayWithNewLenght.Length < array.Length)
            {
                for (int i = 0; i < arrayWithNewLenght.Length; i++)
                {
                    arrayWithNewLenght[i] = array[i];
                }
            }
            if (arrayWithNewLenght.Length > array.Length)
            {
                for (int i = 0, j = 0; i < arrayWithNewLenght.Length; i++, j++)
                {
                    if (j < array.Length)
                    {
                        arrayWithNewLenght[i] = array[j];
                    }
                    else
                    {
                        arrayWithNewLenght[i] = 0;
                    }
                }
            }
            return arrayWithNewLenght;
        }
        //Quest16
        public void ReverseArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return;
            }
            int[] intermediateArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                intermediateArray[i] = array[i];
            }
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                array[i] = intermediateArray[j];
            }
        }
        //Quest17
        public int[] GetArraySum(int[] arrayOne, int[] arrayTwo)
        {
            if ((arrayOne == null || arrayOne.Length == 0) || ((arrayTwo == null || arrayTwo.Length == 0)))
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arraySum = null;
            if (arrayOne.Length == arrayTwo.Length)
            {
                arraySum = new int[arrayOne.Length];
                for (int i = 0; i < arraySum.Length; i++)
                {
                    arraySum[i] = arrayOne[i] + arrayTwo[i];
                }
                return arraySum;
            }
            if (arrayOne.Length > arrayTwo.Length)
            {
                arraySum = new int[arrayOne.Length];
                for (int i = 0, j = 0; i < arrayOne.Length; i++, j++)
                {
                    if (j < arrayTwo.Length)
                    {
                        arraySum[i] = arrayOne[i] + arrayTwo[i];
                    }
                    else
                    {
                        arraySum[i] = arrayOne[i];
                    }
                }
            }
            if (arrayOne.Length < arrayTwo.Length)
            {
                arraySum = new int[arrayOne.Length];
                for (int i = 0, j = 0; i < arrayOne.Length; i++, j++)
                {
                    if (j < arrayOne.Length)
                    {
                        arraySum[i] = arrayOne[i] + arrayTwo[i];
                    }
                    else
                    {
                        arraySum[i] = arrayTwo[i];
                    }
                }
            }
            return arraySum;
        }
        //Quest18
        public int[] AddElementInArray(int[] array, int addNumber)
        {
            if (array == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arrayWithNewElement = new int[array.Length + 1];
            for (int i = 0; i < arrayWithNewElement.Length; i++)
            {
                if (i < array.Length)
                {
                    arrayWithNewElement[i] = array[i];
                }
                else
                {
                    arrayWithNewElement[i] = addNumber;
                }
            }
            return arrayWithNewElement;
        }
        public Person[] AddElementInArray(Person[] waifuArray, Person person)
        {
            if (waifuArray == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            Person[] arrayWithNewElement = new Person[waifuArray.Length + 1];
            for (int i = 0; i < arrayWithNewElement.Length; i++)
            {
                if (i < waifuArray.Length)
                {
                    arrayWithNewElement[i] = waifuArray[i];
                }
                else
                {
                    arrayWithNewElement[i] = person;
                }
            }
            return arrayWithNewElement;
        }
        //Quest19
        public int[] RemoveFirstElementFromArray(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arrayWithoutElement = new int[array.Length - 1];
            for (int i = 0, j = 1; i < arrayWithoutElement.Length; i++, j++)
            {
                arrayWithoutElement[i] = array[j];
            }
            return arrayWithoutElement;
        }
        public Person[] RemoveFirstElementFromArray(Person[] waifuArray)
        {
            if (waifuArray == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            Person[] arrayWithoutElement = new Person[waifuArray.Length - 1];
            for (int i = 0, j = 1; i < arrayWithoutElement.Length; i++, j++)
            {
                arrayWithoutElement[i] = waifuArray[j];
            }
            return arrayWithoutElement;
        }
        //Quest20
        public int[] RemoveLastElementFromArray(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arrayWithoutElement = new int[array.Length - 1];
            for (int i = 0; i < arrayWithoutElement.Length; i++)
            {
                arrayWithoutElement[i] = array[i];
            }
            return arrayWithoutElement;
        }
        public Person[] RemoveLastElementFromArray(Person[] waifuArray)
        {
            if (waifuArray == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            Person[] arrayWithoutElement = new Person[waifuArray.Length - 1];
            for (int i = 0; i < arrayWithoutElement.Length; i++)
            {
                arrayWithoutElement[i] = waifuArray[i];
            }
            return arrayWithoutElement;
        }
        //Quest21
        public int[] RemoveSelectedElementFromArray(int[] array, int selectedIndex)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arrayWithoutElement = new int[array.Length - 1];
            if (selectedIndex > arrayWithoutElement.Length || selectedIndex < 0)
            {
                return array;
            }
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (selectedIndex == i)
                {
                    continue;
                }
                arrayWithoutElement[j] = array[i];
                j++;
            }
            return arrayWithoutElement;
        }
        public Person[] RemoveSelectedElementFromArray(Person[] waifuArray, int selectedIndex)
        {
            if (waifuArray == null || waifuArray.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            Person[] arrayWithoutElement = new Person[waifuArray.Length - 1];
            if (selectedIndex > arrayWithoutElement.Length || selectedIndex < 0)
            {
                return waifuArray;
            }
            for (int i = 0, j = 0; i < waifuArray.Length; i++)
            {
                if (selectedIndex == i)
                {
                    continue;
                }
                arrayWithoutElement[j] = waifuArray[i];
                j++;
            }
            return arrayWithoutElement;
        }
        //Quest22
        public int[] RemoveSelectedSegmentFromArray(int[] array, int minValueSegment, int maxValueSegment)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            if (maxValueSegment < minValueSegment)
            {
                int temporaryStorage = maxValueSegment;
                maxValueSegment = minValueSegment;
                minValueSegment = temporaryStorage;
            }
            if (minValueSegment < 0)
            {
                return array;
            }
            int[] deletedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < deletedSegment.Length; i++, j++)
            {
                deletedSegment[i] = j;
                if (deletedSegment[i] >= array.Length)
                {
                    return array;
                }
            }
            int[] arrayWithoutSegment = new int[array.Length - deletedSegment.Length];
            for (int i = 0, j = 0, z = 0; i < array.Length; i++)
            {
                if (z >= deletedSegment.Length)
                {
                    arrayWithoutSegment[j] = array[i];
                    j++;
                    continue;
                }
                if (deletedSegment[z] == i)
                {
                    z++;
                    continue;
                }
                arrayWithoutSegment[j] = array[i];
                j++;
            }
            return arrayWithoutSegment;
        }
        public Person[] RemoveSelectedSegmentFromArray(Person[] waifuArray, int minValueSegment, int maxValueSegment)
        {
            if (waifuArray == null || waifuArray.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            if (maxValueSegment < minValueSegment)
            {
                int temporaryStorage = maxValueSegment;
                maxValueSegment = minValueSegment;
                minValueSegment = temporaryStorage;
            }
            if (minValueSegment < 0)
            {
                return waifuArray;
            }
            int[] deletedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < deletedSegment.Length; i++, j++)
            {
                deletedSegment[i] = j;
                if (deletedSegment[i] >= waifuArray.Length)
                {
                    return waifuArray;
                }
            }
            Person[] arrayWithoutSegment = new Person[waifuArray.Length - deletedSegment.Length];
            for (int i = 0, j = 0, z = 0; i < waifuArray.Length; i++)
            {
                if (z >= deletedSegment.Length)
                {
                    arrayWithoutSegment[j] = waifuArray[i];
                    j++;
                    continue;
                }
                if (deletedSegment[z] == i)
                {
                    z++;
                    continue;
                }
                arrayWithoutSegment[j] = waifuArray[i];
                j++;
            }
            return arrayWithoutSegment;
        }
        //Quest23
        public int[] RemoveSelectedValueFromArray(int[] array, int selectedValue)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int countOfNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == selectedValue)
                {
                    countOfNumbers++;
                }
            }
            int[] arrayWithoutValues = new int[array.Length - countOfNumbers];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] == selectedValue)
                {
                    continue;
                }
                arrayWithoutValues[j] = array[i];
                j++;
            }
            return arrayWithoutValues;
        }
        //Quest24
        public int[] AddTwoArrays(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne == null || arrayTwo == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] concatenatedArray = new int[arrayOne.Length + arrayTwo.Length];
            int z = 0;
            for (int i = 0; i < arrayOne.Length; i++, z++)
            {
                concatenatedArray[z] = arrayOne[i];
            }
            for (int i = 0; i < arrayTwo.Length; i++, z++)
            {
                concatenatedArray[z] = arrayTwo[i];
            }
            return concatenatedArray;
        }
        public Person[] AddTwoArrays(Person[] arrayOne, Person[] arrayTwo)
        {
            if (arrayOne == null || arrayTwo == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            Person[] concatenatedArray = new Person[arrayOne.Length + arrayTwo.Length];
            int z = 0;
            for (int i = 0; i < arrayOne.Length; i++, z++)
            {
                concatenatedArray[z] = arrayOne[i];
            }
            for (int i = 0; i < arrayTwo.Length; i++, z++)
            {
                concatenatedArray[z] = arrayTwo[i];
            }
            return concatenatedArray;
        }
        //Quest25
        public int[] PullOutSelectedSegmentFromArray(int[] array, int minValueSegment, int maxValueSegment)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            if (maxValueSegment < minValueSegment)
            {
                int temporaryStorage = maxValueSegment;
                maxValueSegment = minValueSegment;
                minValueSegment = temporaryStorage;
            }
            if (minValueSegment < 0)
            {
                return array;
            }
            int[] selectedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < selectedSegment.Length; i++, j++)
            {
                selectedSegment[i] = j;
                if (selectedSegment[i] >= array.Length)
                {
                    return array;
                }
            }
            int[] pullOutSegment = new int[selectedSegment.Length];
            for (int i = 0, j = 0; i < array.Length && j < selectedSegment.Length; i++)
            {
                if (selectedSegment[j] == i)
                {
                    pullOutSegment[j] = array[i];
                    j++;
                }
            }
            return pullOutSegment;
        }
        public Person[] PullOutSelectedSegmentFromArray(Person[] waifuArray, int minValueSegment, int maxValueSegment)
        {
            if (waifuArray == null || waifuArray.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            if (maxValueSegment < minValueSegment)
            {
                int temporaryStorage = maxValueSegment;
                maxValueSegment = minValueSegment;
                minValueSegment = temporaryStorage;
            }
            if (minValueSegment < 0)
            {
                return waifuArray;
            }
            int[] selectedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < selectedSegment.Length; i++, j++)
            {
                selectedSegment[i] = j;
                if (selectedSegment[i] >= waifuArray.Length)
                {
                    return waifuArray;
                }
            }
            Person[] pullOutSegment = new Person[selectedSegment.Length];
            for (int i = 0, j = 0; i < waifuArray.Length && j < selectedSegment.Length; i++)
            {
                if (selectedSegment[j] == i)
                {
                    pullOutSegment[j] = waifuArray[i];
                    j++;
                }
            }
            return pullOutSegment;
        }
    }
}
