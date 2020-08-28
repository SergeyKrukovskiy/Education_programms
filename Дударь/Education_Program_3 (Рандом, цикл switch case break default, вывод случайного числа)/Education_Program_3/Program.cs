using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Program_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random(); //создание переменной класса рандом
            
            int num;
            Console.WriteLine("How old are you?"); //информационное сообщение
            num = randNum.Next (1, 6); //присвоить переменной num рандомное значение от 1 до 6 (по факту до 5)

            switch (num) //оператор проверки переменной
            {
                case 1: //проверочное значение переменной
                    Console.WriteLine("Num is - " + num); //вывод значения переменной
                break;
                case 2://проверочное значение переменной
                    Console.WriteLine("Num is - " + num); //вывод значения переменной
                break;
                default: // если case не сработала
                    Console.WriteLine("Notfing - " + num); //вывод значения переменной
                break;
            }
           
            Console.ReadKey();
        }
    }
}
