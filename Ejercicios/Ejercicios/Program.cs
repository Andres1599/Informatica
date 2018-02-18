using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.Write("Escoge una opción:\n"
                            + "Invertir una cadena (1)\n"
                            + "Juntar un Array (2)\n"
                            + "Remover los caracteres que se repitan (3)\n"
                            + "Ingresa una opción :");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        string cadena;
                        Console.Write("Ingresa una cadena:");
                        cadena = Console.ReadLine();
                        Console.WriteLine(InvertirString(cadena));
                        break;
                    case 2:
                        /* Notar que en la sección fuera del método principal se encuentran funciones extras para poder realizar esta opción */
                        Console.WriteLine("Sumando Arreglos");
                        int[] ArrayA = { 0, 1, 2, 3, 4 };
                        int[] ArrayB = { 5, 6, 7, 8 };
                        int[] ArrayAB = new int[(ArrayA.Length + ArrayB.Length)];
                        JuntarArreglo(ArrayA, ArrayB, ArrayAB);
                        break;
                    case 3:
                        String CadenaRepetida;
                        Console.Write("Ingresa una cadena:");
                        CadenaRepetida = Console.ReadLine();
                        Console.WriteLine(BorrarRepetidos(CadenaRepetida));
                        break;
                }
            } while (opc == 4);
        }

        private static string BorrarRepetidos(string cadenaRepetida)
        {
            string cadenaNueva = "";
            int comodin = 0;
            int[] cont = new int[cadenaRepetida.Length - 1];
            /* varificar el caso 1 si no tiene elementos repetidos */
            for (int i = 0; i < cadenaRepetida.Length - 1; i++)
            {
                
                for (int j = 0; j <= cadenaRepetida.Length - 1; j++)
                {
                    if (cadenaRepetida[i] == cadenaRepetida[j])
                    {
                        cont[i] += 1;
                        comodin += 1;
                        continue;
                    }
                    else
                    {
                        comodin += 1;
                        continue;
                    }
                    
                }
            }

            for (int i = 0; i <= cont.Length - 1; i++)
            {
                if(cont[i] != cont[comodin]){
                    
                }
            }


            return cadenaNueva;
        }


        /* Invierte una cade de caracteres (Ejercicio #1) */
        public static string InvertirString(string cadena)
        {
            string resultado = "";
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                resultado = resultado + cadena[i].ToString();
            }
            return resultado;
        }

        /* Dado dos arreglos, ordenados, luego juntar los arreglos y ordenarlos */
        public static void JuntarArreglo(int[] ArrayA, int[] ArrayB, int[] ArrayAB)
        {
            /* llenando el ArrayAB con los datos de los dos Array's */
            int comodin = ArrayA.Length - 1;
            try
            {
                for (int i = 0; i <= ArrayA.Length - 1; i++)
                {
                    ArrayAB[i] = ArrayA[i];
                }


                for (int i = 0; i <= ArrayB.Length - 1; i++)
                {
                    comodin += 1;
                    ArrayAB[comodin] = ArrayB[i];
                    Console.WriteLine(ArrayAB[comodin]);
                    Console.ReadKey();
                }
            }
            catch (System.Exception)
            {
                throw;
            }


            Array.Sort(ArrayAB);
            /* mostrar el arreglo ya ordenado */
            for (int i = 0; i <= ArrayAB.Length - 1; i++)
            {
                Console.WriteLine("El ArrayAB tiene como resultado en la posición {0}: " + ArrayAB[i], i);

            }
        }

        public static int[] OrdenarArreglo(int[] array)
        {
            Array.Sort(array);
            return array;
        }

    }
}
