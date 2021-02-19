using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Event_Built_in_Delegates
{
    public class OddNumberEventArgs : EventArgs
    {
        public OddNumberEventArgs(int answer)
        {
            product = answer;
        }
        public int product { get; set; }
    }
}
