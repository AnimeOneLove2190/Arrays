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
            int maxValueQuest01 = int.Parse(Console.ReadLine());
            int[] givenArray = arrayService.GetRandomArray(arraySize, minValue, maxValueQuest01);
            arrayService.PrintArray(givenArray);
            //Quest02
            int[] randomArray = new int[10];
            numberService.FillArray(randomArray);
            arrayService.PrintArray(randomArray);
            //Quest03
            int[] justArray = new int[10];
            numberService.FillArray(justArray);
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
            //Quest05
            Person personWithMinAge = arrayService.GetMinAgePerson(personArray);
            Console.WriteLine(personWithMinAge.name);
            Console.WriteLine(personWithMinAge.age);
            //Quest06
            int maxValueQuest06 = arrayService.GetMaxValue(randomArray);
            Console.WriteLine(maxValueQuest06);
            //Quest07
            int maxIndex = arrayService.GetMaxIndex(randomArray);
            Console.WriteLine(maxIndex);
            //Quest08
            int minIndex = arrayService.GetMinIndex(randomArray);
            Console.WriteLine(minIndex);
            //Quest09
            int desiredNumber = 384;
            int desiredIndex = arrayService.GetIndex(randomArray, desiredNumber);
            Console.WriteLine(desiredIndex);
            //Quest10
            int[] randomArrayPlus = new int[10];
            numberService.FillArray(randomArrayPlus);
            bool conclusion = arrayService.IsEqual(randomArray, randomArrayPlus);
            Console.WriteLine(conclusion);
            //Quest11
            int countOfEvenNumbers = arrayService.GetEvenCount(randomArray);
            Console.WriteLine(countOfEvenNumbers);
            //Quest12
            int[] evenArray = arrayService.GetEvenArray(randomArray);
            arrayService.PrintArray(evenArray);
        }
    }
}
