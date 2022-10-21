using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //i=0;
            for (int i = 0; i < 10; i++)
                // без усл цикл станет бескон-ым
            {
                if (i == 7)
                    // break;
                    // continue;
              
                Console.WriteLine("Квадрат числа {0} равен {1}", i, i * i);
                // Console.WriteLine("Квадрат числа {0} равен {1}", i++, i * i); - но вывод от 1 до 10 (а не с 0)
                //i++;
            }
            Console.ReadKey();
        }
    }
}
