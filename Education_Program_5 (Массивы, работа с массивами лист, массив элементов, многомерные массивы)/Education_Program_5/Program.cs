using System;
using System.Collections.Generic;
using System.Globalization;

namespace Education_Program_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //            List<int> numbers = new List<int>(); //создание массива лист без границ

            //            numbers.Add(23); //добавление элемента
            //            numbers.Add(56); 

            //            numbers.Remove(56); //удаление из листа отдельного элемента заданного значения

            //            Console.WriteLine(numbers[1]);

            //            string[] names = new string[3] { 
            //                "Tom", "Jonh", "George" 
            //           }; //создание массива строковых значений

            //           int[] array = new int[5]; //создание массива целых чисел длинной в 10
            //           array [0] = 24; //задание значений
            //            array [1] = 4;
            //            array [2] = 2;
            //            array [3] = 7;
            //            array [4] = 56;

            int dlinnamas; //присвоить длинну массива
            Console.WriteLine("ГРАНИЦА МАССИВА: "); //информационное сообщение
            dlinnamas = Convert.ToInt32(Console.ReadLine()); //присвоить переменной dlinnamas введенное значение
            int[,] numbers = new int[dlinnamas, dlinnamas]; //создание многомерного массива
            numbers[0, 0] = 23;
            numbers[0, 1] = 24;
            numbers[0, 2] = 25;
            numbers[1, 0] = 26;
            numbers[1, 1] = 27;
            numbers[1, 2] = 28;

            for (int i = 0; i < dlinnamas; i++)
                for (int j = 0; j < dlinnamas; j++)
                    Console.Write(numbers[i, j]+ " "); //вывод массива

            //           for (int i = 0; i < numbers.Count; i++) //цикл на вывод значений массива
            //           Console.WriteLine(numbers[1,2] + ", "); // вывод значений

            Console.ReadKey ();
        }
    }
}
