using System;

namespace Section6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array represents a fixed number of variables of a particular type.

            // MULTIDIMENSIONAL ARRAYS

            // There are two types of multi-dimensional arrays.
            // - Rectangular
            // - Jagged array : Think of it as an array of arrays.


            // All arrays map to the array class in the sytem namespace.

            var numbers = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine(numbers.Length);


            // The array, starting point and qty of items.
            Array.Clear(numbers, 0, 3);

            Array.IndexOf(numbers, 9); // => 0;


            // Making a copy.
            var another = new int[3];

            Array.Copy(numbers, another, 3);


            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
