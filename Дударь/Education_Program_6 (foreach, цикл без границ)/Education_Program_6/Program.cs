using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Program_6
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] numbers = { 1.23f, 23.23f, 23.57f }; //массив дробных чисел
            
            foreach (float el in numbers)  //цикл на перебор значений
            {
                Console.WriteLine(el); // вывод значений
            }

            Console.ReadKey();
        }
    }
}
