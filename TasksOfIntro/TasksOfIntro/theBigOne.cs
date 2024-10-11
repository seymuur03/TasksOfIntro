using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOfIntro
{
    internal class theBigOne
    {
        public void BigOne(int x,int y,int z)
        {
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine(x);
                }
            }
            else if (y > z)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }
        }
    }
}
