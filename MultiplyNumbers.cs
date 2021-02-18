using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class MultiplyNumbers
    {
        public delegate void d_OddNumber(); //Decalred Delegate
        public event d_OddNumber e_OddNumber; //Declared Event

        public void Multiply()
        {
            Console.WriteLine("Please enter two numbers to multiply: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int answer = n1 * n2;
            Console.WriteLine(answer.ToString());

            //Check if answer is an odd number, then raise event
            if((answer % 2 != 0) && (e_OddNumber != null))
            {
                e_OddNumber(); //Raised Event
            }
        }
    }
}
