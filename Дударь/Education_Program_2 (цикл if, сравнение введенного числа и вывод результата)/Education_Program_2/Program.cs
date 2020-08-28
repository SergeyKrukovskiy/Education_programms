using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            double num;
            string name;
            Console.WriteLine("How old are you?"); //информационное сообщение
            num = Convert.ToDouble (Console.ReadLine()); //присвоить переменной num введенное значение
            
            if (num >18.23d) //проверка введенного числа
                Console.WriteLine("You are older than 18.23"); //вывод результата
            else if (num < 18.23d)//проверка введенного числа
                Console.WriteLine("You are younger than 18.23"); //вывод результата
            else //проверка на ошибку
                Console.WriteLine("Else"); //вывод результата

            name = num == 15 ? "First" : "Second"; // другая форма записи if и присвание результата в переменную
            Console.WriteLine(name); //вывод результата
            Console.ReadKey ();
        }
    }
}
