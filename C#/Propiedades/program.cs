using System;

namespace Propiedades
{
    class program
    {
        public static void Main(string[] args)
        {
            venta venta1 = new venta (200, DateTime.Now);
            myVenta.total=-9999;
            Console.WriteLine (myVenta.total);
            
        }

    }

    class venta
    {
        int total;
        DateTime fecha;

        public int total
        {
            get
            {
                return total;
            }
            set
            {
                if (value<0)
                value=0;
                total = value;
            }

        }

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