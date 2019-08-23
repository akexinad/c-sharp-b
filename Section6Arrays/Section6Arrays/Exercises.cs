using System;
using System.Collections.Generic;

namespace Section6Arrays
{
    public class Exercises
    {

        public static void ExerciseOne()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Type a name (or hit ENTER or ESC to quit): ");

                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others liked your post", names[0], names[1], names.Count - 2);

        }

        public static void ExerciseTwo()
        {
            var name = new List<string>();

            Console.WriteLine("Enter your name: ");
            var input = Console.ReadLine();

            foreach (var letter in input)
            {
                name.Add(letter.ToString());
            }

            name.Reverse();

            var nameReversed = String.Join("", name);

            Console.WriteLine(nameReversed);
            
        }

        public static void ExerciseThree()
        {
            var numbers = new List<int>();

            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(input);

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter another number: ");
                var nextInput = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);

            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        public static void ExerciseFour()
        {
            /*
            * Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            * The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            */
             
            var numbers = new List<int>();
            var uniques = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type QUIT to exit: ");
                var input = Console.ReadLine();

                if (input == "quit" || input == "QUIT")
                    break;

                var number = Convert.ToInt32(input);

                numbers.Add(number);
            }

            

            for (var i = 0; i < numbers.Count; i++)
            {
                var numToCompare = numbers[i];

                //numbers.Remove(numToCompare);

                if (!uniques.Contains(numToCompare))
                    uniques.Add(numToCompare);
            }

            foreach (var num in uniques)
            {
                Console.WriteLine(num);
            }
        }
    }
}
