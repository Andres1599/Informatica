using System;

namespace RecuperacionParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ejemplo de un fallo del polimorfismo en el que falla
            int[] arreglo = new int[] { };
            object poliFail = arreglo;

        }
    }
}
