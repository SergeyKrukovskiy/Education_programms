using System;
using System.Collections.Generic;

namespace Education_Program_13__Массив_указателей__операторы_is_и_as_
{

    class Animal //базовый класс 
    {
        public string name; //поле базового класса

        public Animal(string name) //конструктор базового класса для определения имени объекта
        {
            this.name = name;
        }

        public void Print() //метод вывода имени на экран
        {
            Console.WriteLine(name);
        }
    }
    class Dog : Animal // класс наследник
    {
        float speed; //поле класса
        public Dog(float speed, string name) : base(name) //конструктор с параметрами + параметр name из класса родителя
        {
            this.speed = speed;
        }
    }

    class Cat : Animal // класс наследник
    {
        float speed; //поле класса
        public Cat(float speed, string name) : base(name) //конструктор с параметрами + параметр name из класса родителя
        {
            this.speed = speed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>(); //создание массива лист типа класс
            animals.Add(new Dog(12.23f, "Alex")); //создание элемента массива объектов которые указывают на базовый класс
            animals.Add(new Dog(12.23f, "Tom"));
            animals.Add(new Cat(12.23f, "Meow"));

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.name);
            }
            //           Dog tom = new Dog(12.23f, "Tom");//объект класса наследника
            //            Console.WriteLine(tom.name);

            //            Console.WriteLine();

            //           Dog Jerry = new Dog(23.2f, "Jerry");//объект класса наследника
            //           Console.WriteLine(Jerry.name);
            //           Console.WriteLine();
            //           Jerry.Print();//вызов метода базового класса из объекта класса наследника
            foreach (Animal animal in animals)
            {
                if (animal is Cat)
                Console.WriteLine(animal.name); // принадлежит ли объект классу. Если использовать as, то вывеведет null, если is то выйдет в исключение в случае невозможности преобразования
            }
            

            Console.ReadKey();
        }
    }
}