using System;

namespace SIrigala_Array_Deliverable
{
    class Program
    {
        static int[] array;

        static void Main(string[] args)

        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                                20, 21, 22, 23, 24, 25 }; //define array
            foreach (int i in numbers)
            {
                Console.WriteLine("Element Value: " + i + ".");
            }//foreach complete
            Console.ReadKey(true);
        } 
        
    }
}
