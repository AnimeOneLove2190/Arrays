using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService numberService = new MathService();
            ArrayService arrayService = new ArrayService();
            Random godOfNumbers = new Random();
            //Quest01
            int arraySize = int.Parse(Console.ReadLine());
            int minValue = int.Parse(Console.ReadLine());
            int maxValue = int.Parse(Console.ReadLine());
            int[] givenArray = arrayService.GetRandomArray(arraySize, minValue, maxValue);
            arrayService.PrintArray(givenArray);
            //Quest02
            int[] outputArray = new int[10];
            numberService.CreateArray(outputArray);
            arrayService.PrintArray(outputArray);
            //Quest03
            int[] justArray = new int[10];
            numberService.CreateArray(justArray);
            int sum = arrayService.GetSum(justArray);
            Console.WriteLine(sum);
            //Quest04
            Person personOne = new Person();
            personOne.name = "Misato Katsuragi";
            personOne.age = 29;
            Person personTwo = new Person();
            personTwo.name = "Yuuki Asuna";
            personTwo.age = 19;
            Person personThree = new Person();
            personThree.name = "Rafutaria";
            personThree.age = 10;
            Person personFour = new Person();
            personFour.name = "Hanji Zoe";
            personFour.age = 31;
            Person personFive = new Person();
            personFive.name = "Violet Evergarden";
            personFive.age = 14;
            Person[] personArray = new Person[5];
            personArray[0] = personOne;
            personArray[1] = personTwo;
            personArray[2] = personThree;
            personArray[3] = personFour;
            personArray[4] = personFive;
            double averageAge = arrayService.GetAverageAge(personArray);
            Console.WriteLine(averageAge);
        }
    }
}
