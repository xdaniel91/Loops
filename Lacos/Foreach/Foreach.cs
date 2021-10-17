using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
            foreach (var num in numbers)
            {
                //if (num == 30)
                //{
                //    continue;
                //}
                //Console.WriteLine(num);

                switch (num)
                {
                    case 30:
                        break;

                    default:
                        Console.WriteLine(num);

                        break;
                }
            }
            Console.ReadLine();
        }

    }
}
