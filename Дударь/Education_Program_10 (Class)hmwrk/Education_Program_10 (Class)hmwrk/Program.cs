using System;
using System.Threading;

namespace Education_Program_10__Class_hmwrk
{
    class Program
    {
        class Student
        {
            public string name;
            public int course;
            public bool stipendia;
            public static int count = 0;
            public Student()
            {
                name = "Tom";
                course = 3;
                stipendia = true;
                count++;
                Print();
                
            }
            public Student(string name, int course, bool stipendia)
            {
                this.name = name;
                this.course = course;
                this.stipendia = stipendia;
                count++;
                Print();
            }
            public void Print()
            {
                Console.WriteLine("name: " + name);
                Console.WriteLine("course: " + course);
                Console.WriteLine("stipendia: " + stipendia);
            }
        }
        
        static void Main(string[] args)
        {

            Student Tom = new Student ();
            Console.WriteLine();
            Student Mark = new Student ("Mark", 2, false);
            Console.WriteLine();
            Console.WriteLine("Количество студентов: " + Student.count);

            Console.ReadKey();
            
        }
    }
}
