using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos
{
    class While
    {
        static void Main(string[] args)
        {


            int i = 100;

            while (i >= 1)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

                i -= 1;
              }
           
            Console.ReadLine();

        }
    }
}
