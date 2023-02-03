using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            show();

            suma(6, 8);
            suma(7, 9);

            int N = Mul(5, 6);
            Console.WriteLine(N);
        }

        static int Mul (int num1, int num2)
        {
            return num1 * num2;
        }

        static void suma(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        static void show()
        {
            Console.WriteLine("texto desde función");
        }
    }
}
