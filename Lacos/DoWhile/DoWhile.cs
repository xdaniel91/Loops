using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class DoWhile
    {
        static void Main(string[] args)
        {

            // do/while

            string texto;
            do
            {
                Console.WriteLine("digite sair para parar o loop");
                texto = Console.ReadLine();
            } while (!texto.Equals("sair"));

            Console.WriteLine("Fim do loop!");
            Console.ReadLine();


            // multiplos de 3 com do/while

            //int b = 3;
            //do
            //{
            //    Console.WriteLine("o valor de b é: " + b);
            //    b += 3;

            //} while (b <= 100);
            //{
            //    Console.WriteLine("b é maior 100, fim do loop");
            //}

            //Console.ReadLine();

        }
    }
}
