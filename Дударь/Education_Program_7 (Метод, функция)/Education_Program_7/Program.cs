using System;

namespace Education_Program_7
{
    class Program
    {
        public static void WriteHello(string str) //создание метода вывода приветствия без возврата значения
        {
            Console.WriteLine(str);
        }

        public static int Multiply(int num1, int num_2) //создание метода умножения c возвратом значения
        {
            return num1 * num_2;
        }
        static void Main(string[] args)
        {
            WriteHello ("Hi"); //вызов метода приветствия
            int num = Convert.ToInt32 (Console.ReadLine()); //ввод переменных пользователем
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Multiply(num,num2); //вызов метода умножения
            Console.WriteLine("Result is " + result);
            Console.ReadKey();
        }
    }
}
