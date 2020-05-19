using System;
using System.Diagnostics;

namespace MergeSort.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 1000000;
            var clock = new Stopwatch();
            var randomGen = new Random((int)DateTime.Now.Ticks);

            Console.WriteLine($"> Initiating array with {arraySize} random values...");
            clock.Start();
            
            var input = new int[arraySize];
            for (int i = 0; i < input.Length; i++)
                input[i] = randomGen.Next(input.Length);
            
            clock.Stop();
            //Console.WriteLine("> Input array:");
            //Console.WriteLine(string.Join(',', input));
            Console.WriteLine($"> Elapsed Time: {clock.Elapsed.TotalMilliseconds} milliseconds");

            clock.Reset();
            Console.WriteLine($"> Initiating Merge Sort...");
            clock.Start();

            var outputA = MergeSort.Lib.MergeSortFuncs.MergeSortArray(input);

            clock.Stop();
            //Console.WriteLine("> Sorted Array Values:");
            //Console.WriteLine(string.Join(',', outputA));
            Console.WriteLine($"> Elapsed Time: {clock.Elapsed.TotalMilliseconds} milliseconds");
        }
    }
}
