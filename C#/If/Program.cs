using System;

namespace If
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool hungry = true;
            bool money = true;

            if(hungry && money && Restaurante("Doña Maria",21))
            {
                Console.WriteLine("come");
            }
            else
            {
                Console.WriteLine("No comes");
            }
        }
        static bool Restaurante (String name, int hour =0)
        {
            if (name == "Doña Maria" && hour > 8 && hour < 22)
            {
                return true;
            }
            else if (name == "Oxxo")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
