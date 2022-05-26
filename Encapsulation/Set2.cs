using System;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student person1 = new Student();
            person1.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(person1.Grades);
        }
    }
}
