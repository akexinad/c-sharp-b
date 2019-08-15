using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 255;
            //int count = 10;
            //float totalPrice = 20.95f; // This number is a double, but we want it to behave like a float. We can do this by attaching an f at the end of the number.
            //char character = 'A';
            //string firstName = "fellini"; // STRINGS have to be enclosed in double characters.
            //bool isWorking = false;

            // OR YOU CAN REPLACE THE TYPES WITH var AND THE COMPILER WILL WORK IT OUT FOR YOU.

            var number = 255;
            var count = 10;
            var totalPrice = 20.95f; 
            var character = 'A';
            var firstName = "fellini";
            var isWorking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}
