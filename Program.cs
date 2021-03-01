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
            bool isArraySorted = false;

            // Create a while loop to execute code block while isSorted is false
           while (isArraySorted == false)
           {
               // Assume that Array is Sorted, Change value if code enters If Statement
               isArraySorted = true;
                // Condition set to length -1 because we are evaluating at 2 sequential spots
               for (var i = 0; i < array.Length -1; i++)
                {
                    if (array[i] > array[i +1])
                    {
                        // Conduct the swap using temp variable technique
                        temp = array[i];
                        array[i] = array[i +1];
                        array[i +1] = temp;

                    // Since swapping occurred, isArraySorted = false
                    isArraySorted = false;
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
