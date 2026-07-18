using System;
using System.Threading;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[10000];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 1000);
            }


            int max = 0;
            int min = 0;
            double average = 0;


            Thread maxThread = new Thread(() =>
            {
                FindMax(numbers, ref max);
            });

            Thread minThread = new Thread(() =>
            {
                FindMin(numbers, ref min);
            });

            Thread averageThread = new Thread(() =>
            {
                FindAverage(numbers, ref average);
            });



            maxThread.Start();
            minThread.Start();
            averageThread.Start();

            maxThread.Join();
            minThread.Join();
            averageThread.Join();



            Thread fileThread = new Thread(() =>
            {
                WriteToFile(numbers, max, min, average);
            });


            fileThread.Start();
            fileThread.Join();

            Console.WriteLine("Готово!");

        }

        static void FindMax(int[] numbers, ref int max)
        {
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Maximum: {max}");
        }

        static void FindMin(int[] numbers, ref int min)
        {
            min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Minimum: {min}");
        }

        static void FindAverage(int[] numbers, ref double average)
        {
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            average = sum / numbers.Length;
            Console.WriteLine($"Average: {average}");
        }

        static void WriteToFile(int[] numbers, int max, int min, double average)
        {
            using (StreamWriter writer = new StreamWriter("results.txt"))
            {
                writer.WriteLine("МаNumbers array:");

                foreach (int number in numbers)
                {
                    writer.Write(number + " ");
                }

                writer.WriteLine();

                writer.WriteLine($"Maximum: {max}");
                writer.WriteLine($"Minimum: {min}");
                writer.WriteLine($"Average: {average}");

                Console.WriteLine("Results saved to file.");
            }
        }
    }
}


