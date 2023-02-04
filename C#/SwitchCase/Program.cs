using System;

namespace SwitchCase
{
    class Program
    {
        private static void Main(string[] args)
        {
            int num = 3;

            switch (num)
            {
                case 1:
                    Console.WriteLine("Eligió 1");
                    break;
                case 2:
                    Console.WriteLine("Eligió 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("eligió 3 o 4");
                    break;
                case < 0:
                case > 100:
                    Console.WriteLine("fuera de rango");
                    break;
                case > 5 and < 9:
                    Console.WriteLine("eligió entre 5 y 9");
                    break;
                default:
                    Console.WriteLine("inválido");
                    break;
            }

        }
    }
}
 