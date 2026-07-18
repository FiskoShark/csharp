using System;
using System.Threading;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of threads: ");
            int threadCount = int.Parse(Console.ReadLine());


            Thread[] threads = new Thread[threadCount];

            int range = end - start + 1;
            int part = range / threadCount;


            for (int i = 0; i < threadCount; i++)
            {
                int threadStart = start + i * part;
                int threadEnd;

                if (i == threadCount - 1) {
                    threadEnd = end;
                }

                else {
                    threadEnd = threadStart + part - 1;
                }

                threads[i] = new Thread(() => {
                    DoWork1(threadStart, threadEnd);
                });

                threads[i].Start();
            }


            for (int i = 0; i < threadCount; i++) { 
                threads[i].Join();
            }


            Console.WriteLine("All threads have completed their work.");
        }


        static void DoWork1(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(50);
            }
        }
    }
}