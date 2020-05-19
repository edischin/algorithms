using System;

namespace MergeSort.Lib {
    public class MergeSortFuncs {
        /// <summary>
        /// Splits given integer array in half resulting in two integer arrays
        /// </summary>
        /// <param name="input">Integer array be splitted</param>
        /// <returns>Array with two integer arrays</returns>
        public static int[][] SplitArray(int[] input) {
            if (input == null)
                return new int[][] { new int[] {}, new int[] {} };
            
            // Returned unchanged input if it cannot be splitted
            if (input.Length < 2)
                return new int[][] { input, new int[] {} };

            // Calculate half size of the input rounded down
            var sizeC = (int)Math.Floor((decimal)input.Length / 2);
            // Calculate the other half size with odd sized array compensation
            var sizeB = sizeC + (input.Length % 2);

            var outputB = new int[sizeB];
            var outputC = new int[sizeC];

            // Iterate through input array to fill its new halves
            for (int i = 0; i < input.Length; i++)
            {
                if (i < sizeB) outputB[i] = input[i];
                else outputC[i - sizeB] = input[i];
            }

            return new int[][] { outputB, outputC };
        }

        /// <summary>
        /// Merges two integer arrays into one while sorting their values in ascending order
        /// </summary>
        /// <param name="inputA">First integer array to be merged</param>
        /// <param name="inputB">Second integer array to be merged</param>
        /// <returns>Sorted integer array in ascending order</returns>
        public static int[] MergeArrays(int[] inputA, int[] inputB) {
            var outputC = new int[inputA.Length + inputB.Length];
            var indexA = 0;
            var indexB = 0;
            var indexC = 0;

            if (inputA == null)
                inputA = new int[] {};

            if (inputB == null)
                inputB = new int[] {};            

            // Loop through inputs A and B until all their values are used
            while (indexA < inputA.Length || indexB < inputB.Length)
            {
                // When all values from input A are already used, use value from input B
                if (indexA >= inputA.Length)
                    outputC[indexC++] = inputB[indexB++];
                // If values from input B are already used, use value from input A, 
                // otherwise choose the smallest one to be used
                else
                    outputC[indexC++] = ((indexB >= inputB.Length || inputA[indexA] <= inputB[indexB])
                        ? inputA[indexA++] : inputB[indexB++]);
            }

            return outputC;
        }

        /// <summary>
        /// Sorts given integer array values in ascending order using MergeSort algorithm
        /// </summary>
        /// <param name="input">Integer array to be sorted</param>
        /// <returns>Sorted integer array in ascending order</returns>
        public static int[] MergeSortArray(int[] input) {
            // Split given array in two halves
            var splits = SplitArray(input);

            // If first half has 2 or more values, split and order it
            if (splits[0].Length > 1)
                splits[0] = MergeSortArray(splits[0]);

            // If second half has 2 or more values, split and order it
            if (splits[1].Length > 1)
                splits[1] = MergeSortArray(splits[1]);
            
            // Merge two halves into one sorted array
            return MergeArrays(splits[0], splits[1]);;
        }
    }
}