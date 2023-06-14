using System;

namespace ClasesYObjetos
{
    class program
    {
        public static void Main(string[] args)
        {
            venta venta1 = new venta (200, DateTime.Now);
            Console.WriteLine(venta1.GetInfo());
        }

    }

    class venta
    {
        int total;
        DateTime fecha;

        public venta (int total, DateTime fecha)
        {
            this.total = total;
            this.fecha = fecha;

        }

        public string GetInfo()
        {
            return total + " " + fecha.ToLongDateString();

        }
        

        public void Show()
        {
            Console.WriteLine("probando clase venta");
        }
    }
}