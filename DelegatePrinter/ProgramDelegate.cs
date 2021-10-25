using System;

namespace DelegatePrinter
{
    delegate void MyDelegate(int x);

    class ProgramDelegate
    {
        static MyDelegate printer;

        static void PrintNumber(int x) 
        { 
            Console.WriteLine(x); 
        }

        static void PrintBar(int x)
        {
            Console.WriteLine(new string('#', x));
        }

        static void Main(string[] args)
        {
            printer = PrintNumber;
            printer += PrintBar;

            printer(7);
            printer.Invoke(10);
        }
    }
}
