/*
Given an unsorted array, Use the Bubble Sort Algo to sort the given array. 

Note: Bubble Sort swaps in place
*/

using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 1
            int[] testArray = {10, 1,9,2,8,3,5};

           IterativeBubbleSort(testArray);
        }
        // Iterative Approach
        public static void IterativeBubbleSort(int[] array)
        {
            // Baseline - Print unsorted array
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+", ");
            }
            // Declare and initialize tempValue to be used for swap
            int temp = 0;

            // Create a nested for loop to evaluate the array at two separate indices
            for (var i = 0; i <= array.Length -1; i++)
            {
                for (var j = i +1 ; j <= array.Length -2 ; j++)
                {
                    if (array[i] > array[j])
                    {
                        // Conduct the swap
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nHere is your sorted array: ");
            foreach (var number in array)
            {
                Console.Write(number+ ", ");
            }
        }
    }
}
