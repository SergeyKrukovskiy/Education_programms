using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num_1;
            const float score = 2.35f; //константа

            Console.WriteLine("Enter first num: "); //Выводит информационное сообщение
            num = Convert.ToInt32 (Console.ReadLine()); //Присваивает введенное пользователем значение переменной num
            Console.WriteLine("\nEnter second num: "); //Выводит информационное сообщение
            num_1 = Convert.ToInt32(Console.ReadLine()); //Присваивает введенное пользователем значение переменной num
            Console.WriteLine("The result is: " + (num + num_1).ToString());
            Console.WriteLine("Hello"); //изменения для ветки Brach-II чтобы сделать pull recuest
            Console.ReadKey ();
        }
    }
}
