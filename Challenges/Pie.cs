using System;

namespace introduction 
{
    class Pie 
    {
        public void Slices(int numberOfSlices, int numberOfPeople, int slicesPerPerson)
        {
            if (numberOfSlices / numberOfPeople >= slicesPerPerson ) 
            {
                Console.WriteLine("it's possible to split a pie fairly");
            }
            else 
            {
                Console.WriteLine("it's not possible to split a pie fairly");
            }
        }
    }
}