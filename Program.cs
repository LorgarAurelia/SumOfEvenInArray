using System;
namespace SumOfEvenInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] arrayOfNumbers =  new uint[4] {1, 2, 3, 4};

            uint sum = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                sum = (arrayOfNumbers[i] % 2 == 0) ? sum + arrayOfNumbers[i] : sum;
            }

            Console.WriteLine("Сумма четных чисел в массиве равна " + sum);
            _ = Console.ReadLine();
        }
    }
}
