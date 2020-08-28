using System;

namespace Education_Program_12__Наследование_
{
    
    class Animal //базовый класс 
    {
        public string name; //поле базового класса

       public Animal (string name) //конструктор базового класса для определения имени объекта
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
       public Dog(float speed, string name) :base (name) //конструктор с параметрами + параметр name из класса родителя
        {
            this.speed = speed;
            Console.WriteLine("Speed: " + speed);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog tom = new Dog(12.23f,"Tom");//объект класса наследника
            Console.WriteLine(tom.name);

            Console.WriteLine();
            
            Dog Jerry = new Dog(23.2f, "Jerry");//объект класса наследника
            Console.WriteLine(Jerry.name);
            Console.WriteLine();
            Jerry.Print();//вызов метода базового класса из объекта класса наследника

            Console.ReadKey();
        }
    }
}
