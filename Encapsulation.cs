using System;

namespace introduction 
{
    class Encapsulation
    {
        /*
        private - limiting access from same class
        public - free for all... any object can access that data
        protected - limiting access to the same class OR descendants
        internal - C# only for OOP... limiting access to a namespace (assembly)

        Why hide data (private)?
        1. human error
        2. allowing access to a 'floor' but not saying how we got there...
        keeping the logic intact, keeping the logic a secret... just letting them access data.
        3. keeping it clean... efficient... easier to understand

        Why not to hide data?
        1. human error
        2. very easy to misunderstand or get wrong

        Example:

        Order details: 

        * User submits their delivery and billing address
        * An issue may arise with accessing the details

        */

        private string name;

        private string lastName;

        private int age;

        private double salary;

        public void Information()
        {
            name = "Mongo";
            lastName = "Bongo";
            age = 89;
            salary = 100000;
            Console.WriteLine($"my name is {name} {lastName}");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"my salary is £{salary}");
        }
    }
}