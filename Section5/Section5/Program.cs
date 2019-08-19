using System;
using System.Collections.Generic;

namespace Section5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // 43. EXERCISES
            // =============


            // EXERCISE 1

            var number = 11;

            if (number == 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }


            // EXERCISE 2

            var num1 = 5;
            var num2 = 4;

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }


            // EXERCISE 3

            var dim1 = 4;
            var dim2 = 5;

            if (dim1 > dim2)
            {
                Console.WriteLine("portrait");
            }
            else
            {
                Console.WriteLine("landscape");
            }


            // EXERCISE 4

            //Console.Write("Your Speed: ");
            //var speed = Convert.ToInt32(Console.ReadLine());

            ////Console.Write("The Speed Limit: ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());

            //if (speed < speedLimit)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    var kmPerDemeritPoint = 5;
            //    var demeritPoints = (speed - speedLimit) / kmPerDemeritPoint;
            //    if (demeritPoints >= 12)
            //    {
            //        Console.WriteLine("SUSPENDED");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You have lost { demeritPoints } demerit points.");
            //    }
            //}

            Console.Clear();



            // THE RANDOM CLASS
            // ================

            var random = new Random();

            const int passwordLength = 10;

            char[] buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);




            // 43. EXERCISES
            // =============


            // EXERCISE 1
            // ==========

            var count = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);




            // EXERCISE 2
            // ==========

            /*
            var sum = 0;

            Console.Write("Enter a number");
            var input = Console.ReadLine();

            while (input != "ok")
            {
                var numInput = Convert.ToInt32(input);
                sum += numInput;
                Console.Write("Enter Another Number");
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
            */




            // EXERCISE 3
            // ==========

            /*
            Console.Write("Enter a number: ");
            var input3 = Console.ReadLine();
            var num = Convert.ToInt32(input3);
            var result = 1;
            while (num >= 1)
            {
                result *= num;
                num--;
            }


            Console.WriteLine($"Factorial is { result }");
            */



            // EXERCISE 4
            // ==========


            /*
            // NOTE that the random class has already been instantiated.
            var randomInt = random.Next(1, 10);

            Console.Write("Guess a number between 1 and 10: ");
            var guess = Convert.ToInt32(Console.ReadLine());

            var guesses = 4;

            while (guesses > 1)
            {
                if (guess == randomInt)
                {
                    Console.WriteLine("YOU GOT IT!!");
                    return;
                } else
                {
                    Console.Write("Guess again...");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                guesses--;
            }

            Console.WriteLine($"The number was { randomInt }, dickhead");
            */




            // EXERCISE 5
            // ==========

            /*
            Console.Write("Enter some series of numbers, I will return the biggest number: ");
            var numbers = Console.ReadLine();

            var result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var num = Int32.Parse(numbers[i].ToString());
                if (num > result)
                {
                    result = num;
                }
            }

            Console.WriteLine(result);
            */
        }
    }
}
