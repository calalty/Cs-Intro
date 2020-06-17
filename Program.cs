using System;
// a libary that will be essential for the majority of first week
// without it = lengthy paths

namespace introduction
{

/*
int = stores whole numbers from -2, 147, 483, 648 to 2, 147, 483, 647
long = stores whole numbers from -9, 223, 372, 036, 854, 775, 808 to 9, 223, 372, 036, 854, 775, 807
float = shorter decimal range
*/

    class Program
    {
        static void Main(string[] args)
        {
            Logic.Mathematics maths = new Logic.Mathematics();
            double subtract = maths.Substraction(5.2,7.4);
            double add = maths.Addition(20.2, 3.8);
            float division = maths.Division(50.6f, 9.3f);
            decimal multiply = maths.Multiply(7.5m, 9.25m);
            Console.WriteLine(subtract);
            Console.WriteLine(add);
            Console.WriteLine(division);
            Console.WriteLine(multiply);

            Console.WriteLine("-------");
            Console.WriteLine("-------");

            AgeCalculator checkAge = new AgeCalculator();
            Console.Write("Please enter age: ");
            string userInput = Console.ReadLine();
            checkAge.Calculator(Convert.ToInt32(userInput));
            Console.WriteLine($"as this person is {userInput} years of age");

            Console.WriteLine("-------");
            Console.WriteLine("-------");

            OddorEven oddOrEven = new OddorEven();
            oddOrEven.isOddorEven(2);

            Console.WriteLine("-------");
            Console.WriteLine("-------");

            Pie slices = new Pie();
            slices.Slices(12, 6, 3);

            Console.WriteLine("-------");
            Console.WriteLine("-------");
            
        /*
          create multiple variables about yourself declared as private
          then create a public method to access the variables in a structured way
          Console.WriteLine about yourself
          Display that method inside of Program.cs
        */

            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Information();
           
            /*
            float = 10.5f
            * double = 10.5
            decimal = 10.5m
            */
        }
    }
}