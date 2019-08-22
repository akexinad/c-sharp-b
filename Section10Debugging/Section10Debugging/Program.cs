using System;
using System.Collections.Generic;

namespace Section10Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //    DEBUGGING SHORTCUTS
            //    ===================

            //    - F5  = Run debugger or jump to the next break-point.
            //    - Shift + F5 = Stop the debugger.
            //    - F9  = Add a break point. Add them wherever you want the code to stop.
            //    - F10 = Step over to the next line.
            //    - F11 = Step Into a method where the debugger has stopped.
            //    - Shift + F11 = Step out of a method.

            //    - See the yellow arrow on the left under your break point?
	           //     - You can drag that yellow arrow where
	           //           you would like the debugger to start and stop.


            //    THE WATCH WINDOW

            //    - Go to debug>window>watch>watch1
            //    - You can put the variables you want to watch throughout the debugging process
            //    - Just add the name of the variable you want to watch.

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("Count", "Count cannot be greater than the number of elements in the list.");

            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
