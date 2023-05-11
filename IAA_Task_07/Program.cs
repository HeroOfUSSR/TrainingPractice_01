using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IAA_Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите размер массива: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[arrayLenght];
            FillArray(arrayNumbers);

            Console.WriteLine("Исходный массив чисел: ");
            OutputArray(arrayNumbers);

            Console.WriteLine("\nПеремешанный массив чисел: ");
            Shuffle(arrayNumbers);

            Console.WriteLine();
        }

        static void FillArray(int[] arrayNumber)
        { 
            Random random = new Random();
            int minRandomNumber = 0;
            int maxRandomNumber = 10;

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = random.Next(minRandomNumber, maxRandomNumber);
            }
        }

        static void OutputArray(int[] arrayNumberOutput)
        {
            for (int i = 0; i < arrayNumberOutput.Length; i++)
            {
                Console.Write(arrayNumberOutput[i] + " ");
            }
        }

        static void Shuffle(int[] arrayNumberShuffle)
        {
            Random random = new Random();
            int randomIndex;
            int shuffledElement;

            for (int i = arrayNumberShuffle.Length - 1; i >= 0; i--)       
            {
                randomIndex  = random.Next(i);
                shuffledElement  = arrayNumberShuffle[randomIndex];
                arrayNumberShuffle[randomIndex]  = arrayNumberShuffle[i];
                arrayNumberShuffle[i] = shuffledElement;

                Console.Write(shuffledElement + " ");
            }
        }
    }
}