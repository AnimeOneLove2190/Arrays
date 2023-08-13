using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TechnicalService
    {
        //Технический блок
        public void FillArray(int[] inputArray)
        {
            Random godOfNumbers = new Random();
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = godOfNumbers.Next(-10, 10);
            }
        }
        public void PrintArrayPerson(Person[] waifyArray)
        {
            if (waifyArray == null || waifyArray.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < waifyArray.Length; i++)
            {
                Console.Write($"{waifyArray[i].name}, ");
            }
            Console.WriteLine();
        }
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
    }
}
