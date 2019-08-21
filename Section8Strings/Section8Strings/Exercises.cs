using System;
using System.Collections.Generic;
using System.Text;

namespace Section8Strings
{
    public class Exercises
    {
        public static void One()
        {
            Console.WriteLine("Enter some numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            var numberList = new List<int>();

            var inputSplit = input.Split('-');

            foreach (var item in inputSplit)
            {
                numberList.Add(Convert.ToInt32(item));
            }

            numberList.Sort();

            var isConsecutive = true;

            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] != Convert.ToInt32(inputSplit[i]))
                    isConsecutive = false;
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";

            Console.WriteLine(message);
        }

        public static void Two()
        {

        }
    }
}
