using System;

namespace introduction
{
    class AgeCalculator
    {
        public void Calculator(int age)
        {

            if (age < 18)
            {
                Console.WriteLine("Under Age, 18 year olds only");
            }
            else if (age < 40)
            {
                Console.WriteLine("Too Old");
            }
            else if (age > 100)
            {
                Console.WriteLine("You're not of this Earth!");
            }

        }
    }
}