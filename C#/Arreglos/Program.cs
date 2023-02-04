using System;

namespace Arreglos
{
    class program
    {
        static void Main(string[] args)
        {
            string[] amigos = new string[5]
            {
                "Yeisson",
                "Andrés",
                "Ana",
                "Héctor",
                null
            };

            Console.WriteLine(amigos[0]);
            Console.WriteLine(amigos[1]);
            Console.WriteLine(amigos[2]);
            Console.WriteLine(amigos[3]);
            Console.WriteLine(amigos[4]);

        }
    }
}
