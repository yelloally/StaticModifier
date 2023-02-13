using System;

namespace StaticModifierExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The result of the static method is: " + Utility.Square(5));
            Console.ReadLine();
        }
    }

    static class Utility
    {
        public static int Square(int number)
        {
            return number * number;
        }
    }
}
