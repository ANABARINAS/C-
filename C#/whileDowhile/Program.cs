using System;

namespace WhileDoWhile
{
    class program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;

            while (j < 100)
            {
                if (j > 10)
                break;

                Console.WriteLine(j);
                j++;
            }

            string[] amigos = new string[7]
            {
                "Pepe",
                "Luisa",
                "Mia",
                "Lucía",
                "Lucas",
                "Martín",
                "Rosa",
            };

            int index = 0;

            while(index < amigos.Length)
            {
                Console.WriteLine(amigos[index]);
                index++;
            }

            bool run = false;
            do
            {
                show();
            }while( run );
        }

        static void show()
        {
            Console.WriteLine("Entra una vez");
        }
    }
}