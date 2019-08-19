using Section4.Human;
using Section4.Math;
using System;

namespace Section4
{


    class Program
    {
        static void Main(string[] args)
        {
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




            // STRUCTS
            // =======

            // Structs are basically lightweight objects/classes and should be used if you want to create a realtively small object with little data.
            // 99% of the time, you will end up using classes anyway.




            // ARRAYS
            // ======

            // An array is a data structure to store a collection of variables of the same type.
            // Remember that in C#, everything is a class so you need to instantiate an array.

            // Reminder, when you declare new, you are telling the compiler to allocate memory for you new object.

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        }
    }
}
