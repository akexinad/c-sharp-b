﻿using System;

namespace Section4.Human
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"My name is { FirstName } { LastName }");
        }
    }
}
