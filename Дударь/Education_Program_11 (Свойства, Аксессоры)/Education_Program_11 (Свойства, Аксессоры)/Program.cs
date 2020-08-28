using System;

namespace Education_Program_11__Свойства__Аксессоры_
{
    class Program
    {
        class Student
        {
            private string name;
            private int course;
            private bool stipendia;
            private static int count = 0;
            public int Count // Аксессор get для обращения к закрытой переменной
            {
                get //обращение без изменения
                {
                    return count;
                }
                set //обращение для изменения
                {
                    if (value < 1)
                        count = 0;
                    else
                        count = value;
                }
            }
            public Student() //конструктор дефолтный
            {
                name = "Tom";
                course = 3;
                stipendia = true;
                count++;
                Print();
            }
            public Student(string name, int course, bool stipendia) //конструктор с параметрами
            {
                this.name = name;
                this.course = course;
                this.stipendia = stipendia;
                count++;
                Print();
            }
            public void Print() //метод вывода на экран значений
            {
                Console.WriteLine("name: " + name);
                Console.WriteLine("course: " + course);
                Console.WriteLine("stipendia: " + stipendia);
            }
        }

        static void Main(string[] args)
        {

            Student Tom = new Student(); //создание экземпляра класса
            Console.WriteLine();
            Student Mark = new Student("Mark", 2, false); //создание экземпляра класса с параметрами
            Console.WriteLine();
            Console.WriteLine("Количество студентов: " + Mark.Count); //вывод переменной из объекта при помощи аксессора

            Console.ReadKey();

        }
    }
}
