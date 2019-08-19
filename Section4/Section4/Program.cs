using Section4.Human;
using Section4.Math;
using System;

namespace Section4
{

    public enum ShippingMethod
    {
        AusPost = 1,
        DHL = 2,
        FedEx = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            // ===========
            // 27. CLASSES
            // ===========

            // Note that the word CLASS and OBJECT is often used interchangably.
            // When you build a class, you can create various instances of that class,
            // and it is those objects that you've instantiated that communicate with each other.

            // THE PARTS TO A CLASS

            // 1. The word 'public' is a kind of...
            // Access modifier: It determines whether a class is visible to classes or not.


            // Declaring new is is the moment when you are allocating a spot in memory for the class/object.




            // THE STATIC MODIFIER

            // The static modifier allows you to access methods from a given class without having to instantiate it.
            // Ex. the calculator class above has a static method.

            var result = Calculator.Add(2, 2);
            // The WriteLine method in the console class is static.
            Console.WriteLine(result);

            // The use of this is so you do not have to instantiate the class to have access to this method.
            // So instead of taking up numerous points in memory, you only occupy one point in memory that is the memory itself.

            // WE USE THE STATIC MODIFIER TO REPRESENT A CONCEPT WHERE ONLY A SINGLE INSTANCE OF THAT SHOULD EXIST IN MEMORY.

            Person person = new Person();
            person.FirstName = "federico";
            person.LastName = "fellini";
            person.Introduce();




            // =======
            // STRUCTS
            // =======

            // Structs are basically lightweight objects/classes and should be used if you want to create a realtively small object with little data.
            // 99% of the time, you will end up using classes anyway.
            // ALL PRIMITIVE TYPES ARE STRUCTURES.



            // ======
            // ARRAYS
            // ======

            // An array is a data structure to store a collection of variables of the same type.
            // Remember that in C#, everything is a class so you need to instantiate an array.

            // Reminder, when you declare new, you are telling the compiler to allocate memory for you new object.

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            // An array of booleans are initially flagged to false.

            var flags = new bool[3];
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            var names = new string[3] { "fellini", "benigni", "pasolini" };




            // =======
            // STRINGS
            // =======

            // Strings in C# are immutable.

            var joinedNames = string.Join(", ", names);

            Console.WriteLine(joinedNames);




            // =====
            // ENUMS
            // =====

            // Is a set of name/value pairs (constants)
            // Like a JS object or a ruby hash.
            // Enums are defined at the namespace level.


            // See the enum at the very top of the file.
            var firstOption = ShippingMethod.AusPost;
            Console.WriteLine(firstOption);

            // If you want the numeric value of the enum, you can cast the variable.
            Console.WriteLine((int)firstOption);

            // For example, if you only recieved the shipping id and need to find out the method,
            // You can use the enum to cast the method id...
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // Converting or PARSING a string into an enum name/value.
            var methodName = "FedEx";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);


            Console.Clear();


            // ===============================
            // REFERENCE TYPES AND VALUE TYPES
            // ===============================


            // STRUCTURES = VALUE TYPES

            // Structures are allocated memory on the stack.
            // When the structure is not in scope, it is immediately removed by the runtime/CLR.

            // CLASSES = REFERENCE TYPES

            // Memory allocation is done manually when you use `new` operator.
            // It is allocated to the part of memory called the HEAP.
            // When a class is out of scope,  it continues to live in the HEAP for a little while.
            // Then runtime/CLR uses a process called Garbage Collection to remove these classes from the HEAP.

            var integer = 10;

            var integerCopy = integer;

            integerCopy++;

            // The value of integer remains 10. Why?
            // So as we saw, all primitive types are STRUCTURES,
            // which means that they are automatically given a place in memory by the CLR.
            // So when you make a copy of a primitive type, the run time creates another
            // spot in memory for the copy.

            Console.WriteLine(string.Format("Original Integer: {0}, Copy of the integer: {1}", integer, integerCopy));

            // THIS IS WHY THEY ARE CALLED VALUE, BECAUSE THEIR VALUES ARE COPIED, NOT THE ACTUAL OBJECT.


            // Now lets look at REFERENCE TYPES

            var arrayOne = new int[3] { 1, 2, 3 };
            var arrayTwo = arrayOne;

            arrayTwo[0] = 0;

            // arrayOne[0] will also be 0.

            // When you instantiate the array class, it is allocated memory in the HEAP and it is given an address.
            // The arrayOne variable refers to this address for the array values.
            // So therefore arrayOne POINTS TO or REFERENCES to the object in the HEAP.
            // And the same goes for arrayTwo. So when you make changes from arrayTwo, you see the changes in arrayOne.

            Console.WriteLine(string.Format("arrayOne[0] = {0}, arrayTwo[0] = {1}", arrayOne[0], arrayTwo[0]));


        }
    }
}
