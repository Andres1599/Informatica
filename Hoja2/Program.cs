using System;

namespace Hoja2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de tareas");

            QueHacer qh1 = new QueHacer();
            qh1.CodigoQueHacer = 1;
            qh1.Descripcion = "Salir a comprar la comida";
            
            QueHacer qh2 = new QueHacer();
            qh2.CodigoQueHacer = 2;
            qh2.Descripcion = "Hacer las tareas de progra a tiempo";

            Persona Andres = new Persona();
            Andres.nombre = "Andres";
            Andres.apellido = "Higueros";

            Persona Diego = new Persona();
            Diego.nombre = "Diego";
            Diego.apellido = "Vega";
            
            Andres.AgregarTarea(qh1);
            Andres.AgregarTarea(qh2);
            Diego.AgregarTarea(qh1);
            Diego.AgregarTarea(qh2);

            Andres.CompletarQueHacer();
            Diego.CompletarQueHacer();

            Console.WriteLine("Esta disponible" + Diego.nombre + " {0}", Diego.EstaDisponible());
            Console.WriteLine("Esta disponible" + Andres.nombre + " {0}", Andres.EstaDisponible());
        }
    }
}
