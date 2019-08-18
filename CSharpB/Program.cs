using System;

namespace CSharpB
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMPLICIT CONVERSION
            // ===================

            // an int is 4 bytes, so therefore there is no data loss nor compilation errors.
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // You cannot do the inverse.
            // Because of the size of the type this will lead to data loss.
            int q = 1;
            // byte w = q; // => Error CS0266  Cannot implicitly convert type 'int' to 'byte'.An explicit conversion exists (are you missing a cast?)


            // You will need to do is use...




            // EXPLICIT CONVERSION
            // ===================

            // By using a cast.

            byte w = (byte)i;

            // Since the value of q is less than 255, there will be no data loss and it is possible to store it in a byte.
            Console.WriteLine(b);

            // This is an example of data loss when you convert an int greater than 255 into a byte.

            int e = 1000;
            byte r = (byte)e;
            Console.WriteLine(r); // => 232, not 1000.




            // NON COMPATIBLE TYPES
            //=====================

            var number = "1234";
            //int t = (int)number; // => ERROR: Cannot convert type string to int.

            // This is where you can use the convert class.

            int t = Convert.ToInt32(number);
            Console.WriteLine(t);

            // If we were to convert this string in to a byte. .NET would throw an exception and crash the application.

            //int y = Convert.ToByte(number); => ERROR. Number to big for byte type.

            // To avoid the exception being propogated to the .NET runtime, we can put the code in a try catch block so the
            // the exception is caught before it crashes the app.

            try
            {
                int y = Convert.ToByte(number);

            }
            catch (Exception)
            {
                Console.WriteLine("Number could not be converted to a byte.");
            }

            // We can also use the convert method to convert strings to booleans.
            string u = "true";
            bool p = Convert.ToBoolean(u);
            Console.WriteLine(p);
    }
}
}
