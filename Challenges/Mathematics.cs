using System;
// a libary that will be essential for the majority of first week
// without it = lengthy paths

namespace Logic
// any class inside of namespace will be available
{
    class Mathematics 
    {
        public double Addition(double numberOne, double numberTwo)
        // public or private - encapsulation
        {
            return numberOne + numberTwo;
        }
        public double Substraction(double numberOne, double numberTwo)
        // public or private - encapsulation
        {
            return numberOne - numberTwo;
        }
         public float Division(float numberOne, float numberTwo)
        // public or private - encapsulation
        {
            return numberOne / numberTwo;
        }
         public decimal Multiply(decimal numberOne, decimal numberTwo)
        // public or private - encapsulation
        {
            return numberOne / numberTwo;
        }
    }
}