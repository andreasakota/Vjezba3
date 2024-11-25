using System;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };

            
            Console.WriteLine("Original array:");
            DisplayArray(array);

            
            Selection.Sort(array, 0);

            
            Console.WriteLine("Sorted array:");
            DisplayArray(array);
        }

        static void DisplayArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
