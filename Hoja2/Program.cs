using System;

namespace Hoja2
{
    class Program
    {
        static void Main(string[] args)
        {
            QueHacer var = new QueHacer();
            var.CodigoQueHacer_ = 1;
            var.Descripcion_ = "Limpiar los vidrios";
            var.setEstado(Estados.Terminda,2);
            Console.WriteLine(var.Estado_);
        }
    }
}
