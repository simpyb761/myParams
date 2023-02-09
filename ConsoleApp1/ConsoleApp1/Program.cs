using System;
using static System.Console;

namespace myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            WriteLine("How many random numbers would you like to generate: ");
            int arraySize = int.Parse(ReadLine());
            WriteLine("Your Random integers are!");
            int[] randomInts = new int[arraySize];
            for (int x = 0; x < arraySize; x++)
            {
                randomInts[x] = randomNumber.Next(1, 10);
            }
            for (int x = 0; x < arraySize; x++)
            {
                Console.WriteLine(randomInts[x]);
            }
            WriteLine($"Your random integers added together equal {Add(randomInts)}");
            WriteLine($"Your random integers multiplied together equal {Multiply(randomInts)}");
        }
        static int Add(params int[] ints)
        {
            int calculatedNumber = 0;
            for (int x = 0; x < ints.Length; x++)
            {
                calculatedNumber += ints[x];
            }
            return calculatedNumber;
        }
        static int Multiply(params int[] ints)
        {
            int calculatedNumber = 1;
            for (int x = 0; x < ints.Length; x++)
            {
                calculatedNumber *= ints[x];
            }
            return calculatedNumber;
        }
    }
}