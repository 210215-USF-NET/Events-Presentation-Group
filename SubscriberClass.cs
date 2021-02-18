using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    class SubscriberClass
    {
        public static void Main(string[] args)
        {
            MultiplyNumbers multiplication = new MultiplyNumbers();
           
            //Event gets binded with delegates
            multiplication.e_OddNumber += new MultiplyNumbers.d_OddNumber(EventMessage);
            multiplication.Multiply();
            Console.Read();
        }

        //Delegates call this method when an event is raised.
        static void EventMessage()
        {
            Console.WriteLine("Event has been executed: This is an Odd Number!");
        }
    }
}
