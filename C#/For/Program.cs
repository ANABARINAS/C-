using System;

namespace For
{
    class program
    {
        public static void Main(string[] args)
        {
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

            for (int i=0; i<amigos.Length; i++)
            {
                Console.WriteLine(amigos[i]);
            }
        }
    }
}
