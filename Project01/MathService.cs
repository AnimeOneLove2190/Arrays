using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class MathService
    {
        public void CreateArray(int[] inputArray)
        {
            Random godOfNumbers = new Random();
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = godOfNumbers.Next(int.MinValue, int.MaxValue);
            }
        }
    }
}
