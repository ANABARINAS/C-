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
                default:
                    Console.WriteLine("inválido");
                    break;
            }

        }
    }
}
 