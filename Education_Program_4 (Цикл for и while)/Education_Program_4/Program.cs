using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num <= 5; num++) //цикл for вывода num
                Console.WriteLine(num + "\n"); // вывод num

            int num2 = 0;
            while (num2<=6) //цикл while вывода num2
            {
               Console.WriteLine(num2 + "\n"); // вывод num
                num2++;
            }

            Console.ReadKey();
        }


    }
    
}
