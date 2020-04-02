using System;

namespace SamplePrograms
{
    class Program
    {
        /* We'll use instance variables as 'global' variables to avoid having to
         * mess around with passing arrays between functions
         */

        private static int[] unsortedList, sortedList;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            int i;
            unsortedList = new int[10];
            sortedList = new int[10];

            for (i = 0; i < unsortedList.Length; i++)
                unsortedList[i] = random.Next(50);

            /* You can also do Python-style for loops */
            foreach (int num in unsortedList)
                Console.WriteLine(num);

            bubbleSort();
            foreach (int num in unsortedList)
                Console.WriteLine(num);

            Console.ReadKey();
        }

        /* A void function is a procedure- it does not return a value */
        private static void bubbleSort()
        {
            while (true) // Looping the bubble sort.
            {
                bool swapped = false; // 
                for (int i = 0; i < unsortedList.Length - 1; i++) // Getting the length of the list for the sort. I is the current position in the list (0-9, not 1-10)
                {
                    if (unsortedList[i] > unsortedList[i + 1]) // Comparing the adjacent values.
                    {
                        swapped = true; // If one or more values in the list have been swapped around, this will be true and the loop will not be broken.
                        var tempvar = unsortedList[i]; // Moves the larger number into a temporary variable to be swapped around.
                        unsortedList[i] = unsortedList[i + 1]; // The smaller variable is overwritten by the larger one.
                        unsortedList[i + 1] = tempvar; // The larger variable is overwritten by the smaller variable.
                    }
                }
                if (!swapped) // NOT gate, if swapped is false
                {
                    break; // Breaks the loop, ending the bubble sort.
                }

            }
        }
    }
}
