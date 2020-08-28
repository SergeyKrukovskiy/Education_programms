using System;

namespace Education_Program_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string str2 = "Hello2";
            string str3 = "Hello2, world, arsenal";
            string[] clubs = str3.Split(","); //разделение строки на подстроки по заданному параметру
            char[] sym = str.ToCharArray(); //преобразование строки в массив символов
            Console.WriteLine(str[1]); //вывод втрого элемента строкового массива
            Console.WriteLine(str.Length); //вывод длинны строкового массива
            Console.WriteLine(string.IsNullOrEmpty(str)); // вывод результата проверки строки на заполненность
            Console.WriteLine(string.IsNullOrWhiteSpace(str)); // вывод результата проверки строки на заполненность не учитывая пробелы
            Console.WriteLine(string.Compare("a", "b")); // проверка строк относительно алфавита, возврат 1 если первая больше 0 если равны -1 если вторая больше
            Console.WriteLine(str2.ToLower()); // перевод на нижний регистр
            Console.WriteLine(str2.ToUpper()); // перевод на верхний регистр
            Console.WriteLine(str2.Contains("llo")); //содержит ли строка заданную подстроку
            Console.WriteLine(str2.StartsWith("llo")); //начинается ли строка с указанной подстроки
            Console.WriteLine(str2.EndsWith("llo")); //заканчивается ли строка с указанной подстроки
            Console.WriteLine(str2.Insert(5,"llo")); //вставка подстроки в строку начиная с указанного индекса
            Console.WriteLine(str2.Remove(5)); //удаление подстроки, начиная с заданного индекса элемента
            Console.WriteLine(str2.Replace("llo","1234")); //замена одной подстроки другой
            Console.WriteLine(str2.StartsWith("llo")); //начинается ли строка с указанной подстроки
            Console.WriteLine(clubs[2]); // вывод элемента массива из разделенных подстрок
            Console.ReadKey();
        }
    }
}
