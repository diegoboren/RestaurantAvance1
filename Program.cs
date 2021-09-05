using System;

namespace Proyecto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mesa mesa1 = new Mesa();

            mesa1.CantidadOcupantes = 10;

            Console.WriteLine(mesa1);
        }
    }
}
