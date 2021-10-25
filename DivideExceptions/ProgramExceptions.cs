using System;

namespace DivideExceptions
{
    class ProgramExceptions
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int m = a * b;
            int d = a / b;

            Console.WriteLine($"{a} * {b} = {m}");
            Console.WriteLine($"{a} / {b} = {d}");

            Console.ReadKey();
        }
    }
}
