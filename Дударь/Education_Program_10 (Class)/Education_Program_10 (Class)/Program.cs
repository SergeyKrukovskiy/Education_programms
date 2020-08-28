using System;

namespace Education_Program_10__Class_
{

    class Animal // создание класса - шаблон на основании которого будут создаваться объекты (экземпляры класса)
    {
        public static int count = 0; //счетчик созданных методов класса. Переменная static будет доступна только для этого класса
        public string name = "Spotty";
        public int age = 7; //доступ паблик, чтобы можно было обращаться к объекту из другого класса,
                            //по умолчанию к объектам в классе применяется private
        public float hapiness = 0.6f; //задание переменных
                                      //модификаторы доступа: public - можно достучаться с любого класса, 
                                      //private - будет принадлежать исключительно тому классу в котором задана,
                                      //protected - можно обращаться из дочернего класса

        public void Print() // создание метода внутри класса
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happines: " + hapiness);
        }

        public Animal () //конструктор
        {

            name = "Spotty";
            age = 7;
            hapiness = 0.7f;
            count++;
            Print();

        }

        public Animal (string name, int age, float happiness) //конструктор 2 с параметрами
        {

            this.name = name;
            this.age = age;
            this.hapiness = happiness; //this - указывает на то, что мы используем переменные этого класса класса
            count++;
            Print();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(); // создание объекта класса
            Console.WriteLine();
            Animal dog = new Animal("Tom",7,0.6f); // создание объекта класса
            Console.WriteLine();
            Console.WriteLine("Количество животных: " + Animal.count);


            Console.ReadKey();
        }
    }
}
