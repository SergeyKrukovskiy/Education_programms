using System;

namespace Education_Program_9__Try_catch_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: "); //информационное сообщение

            try //обработчик трай, попытка выполнить программу
            {
                int num = Convert.ToInt32(Console.ReadLine()); //переменной присваивается введенное значение
                Console.WriteLine("Num is - " + num); //переменная выводится

            }
            catch (IndexOutOfRangeException) //если произошла ошибка выполнить код из блока
            {
                Console.WriteLine("IndexOutOfRangeException"); // вывод ошибки несоответствия
                                                               // формата - FormatException, Exception - любая ошибка, DivideByZeroException - ошибка деления на ноль
                                                               // FileNotFoundException - ошибка файл не найден
                                                               // IndexOutOfRangeException - индекс находится за границами массива
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            } finally //блок который сработает в любом случае, даже если сработает один из catch
            {

            }
                Console.ReadKey();
        }
    }
}
