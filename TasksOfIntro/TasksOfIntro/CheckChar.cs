using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TasksOfIntro
{
    internal class Pow
    {
        public void DoubleMultiple(int x) 
        {
            if (x != 0 && x> 0 && x % 2 == 0)
            {
                Console.WriteLine(x*x); 
            }
            else
            {
                Console.WriteLine("duzgun daxil et...");
            }
        }
    }
}
