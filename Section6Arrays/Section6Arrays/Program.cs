using System;
using System.Collections.Generic;

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




            // LISTS
            // =====

            // YES, there is a difference between arrays and lists.
            // You can use lists when you do not know the length of the
            // data structure to begin with.


            var numberList = new List<int>() { 6, 1, 2, 3, 4, 5, 6, 7 };

            // The list has an add method.
            numberList.Add(45);

            numberList.AddRange(new int[3] { 78, 101, 98 });

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(numberList.IndexOf(6));

            // If you want to start your search from the end of the list.
            Console.WriteLine(numberList.LastIndexOf(6));

            Console.WriteLine(numberList.Count);


            // NOTE: In C# you are not allowed to modify a collection inside a foreach block.
            // You need to use a for loop

            /*

            THIS CANNOT BE DONE.
              
            foreach (var item in numberList)
            {
                if (item == 6)
                    numberList.Remove(item);
            }
            */
            Console.Clear();

            for (var i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == 6)
                {
                    numberList.Remove(numberList[i]);
                }
            }

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }


            // Remove all elements from the list
            numberList.Clear();

        }
    }
}
