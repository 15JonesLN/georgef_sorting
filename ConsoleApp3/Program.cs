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

            Console.ReadKey();
        }

        /* A void function is a procedure- it does not return a value */
        private static void bubbleSort()
        {
            int i, j;
            int temp = 0;

            unsortedList.CopyTo(sortedList, 10);
            foreach (int num in sortedList)
                Console.WriteLine(num);

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j <= 19; i++)
                {
                    if (sortedList[j] > sortedList[j + 1])
                    {
                        sortedList[j + 1] = temp;
                        sortedList[j] = sortedList[j + 1];
                        temp = sortedList[j];
                    }
                }
            }

            /* I cannot get this to work and James and I are not sure why*/

            /* Copy unsortedList into sortedList
             * no, you can't just do sortedList=unsortedList!
             * https://www.telerik.com/blogs/copying-and-cloning-arrays-in-c
             */

            /* Iterate over the list, you'll need a couple of counting variables.
             * Above, i and j are declared for you.
             * You should know how to do a bubble sort by now, right? :)
             */
        }

    }
}
