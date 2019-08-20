using System;
using System.Collections.Generic;
using System.Text;

namespace Section8Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRINGS
            // =======

            var fullName = "Federico Fellini   ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: '{0}'\nLast Name: '{1}'", firstName, lastName);

            var names = fullName.Split(' ');
            Console.WriteLine($"First Name: {names[0]}\nLast Name: {names[1]}");

            var newName = fullName.Replace("Federico", "Fede");
            Console.WriteLine(newName);

            if (string.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");




            // CONVERTING NUMBERS TO STRINGS

            var str = "25";
            // Since no one can be older than 255 years, we can use the toByte instead of the generic toInt32()
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            // Adding the 0 to the argument will round it to 30 dollars.
            Console.WriteLine(price.ToString("C0"));

            var sentence = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?";

            var summary = StringUtils.summarizeText(sentence, 100);

            Console.WriteLine(summary);



            Console.Clear();




            // STRING BUILDER
            // ==============


            // If you need to manipulate strings often, it is best to use the string builder class.

            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .AppendLine();


            // building a random sequence of characters
            builder.Replace('-', '*');
            builder.Remove(0, 10);

            builder.Insert(0, new String('-', 10));

            Console.WriteLine(builder);

        }
    }
}
