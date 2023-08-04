using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService service = new ArrayService();
            Random godOfNumbers = new Random();
            int arraySize = int.Parse(Console.ReadLine());
            int minValue = int.Parse(Console.ReadLine());
            int maxValue = int.Parse(Console.ReadLine());
            int[] givenArray = service.GetRandomArray(arraySize, minValue, maxValue);
            service.WriteArray(givenArray);
        }
    }
}
