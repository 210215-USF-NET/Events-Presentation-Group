using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Event_Built_in_Delegates
{
    public class Subscriber
    {
        public static void Main(string[] args)
        {
            MultiplyNumbers multiplication = new MultiplyNumbers();

            //Event gets binded with delegates
            multiplication.e_OddNumber += EventMessage;
            multiplication.Multiply();
            Console.Read();
        }

        //Delegates call this method when an event is raised.
        static void EventMessage(object sender, OddNumberEventArgs e)
        {
            Console.WriteLine("Event has been executed: {0} is an Odd Number!", e.product);
        }
    }
}
