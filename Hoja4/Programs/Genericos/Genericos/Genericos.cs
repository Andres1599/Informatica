namespace Genericos
{
    public class Genericos
    {
        public Genericos() { }


        //retorno del primer elemento de la lista
        public static T Head<T>(T[] lista)
        {
            return lista[0];
        }

        //retorno del mismo arreglo a excepcion del primer elemto
        public static T[] Tail<T>(T[] lista)
        {
            T[] nuevaLista = new T[lista.Length - 1];
            int comodin = 0;
            for (int i = 1; i < lista.Length; i++)
            {
                nuevaLista[comodin] = lista[i];
                comodin += 1;
            }
            return nuevaLista;
        }

        //retorno de una nueva tupla
        public static T[] Zip<T1, T2, T>(T1[] listaA, T2[] listaB)
        {
            T[] arreglo;
            if (listaA.Length < listaB.Length)
            {
                arreglo = new T[listaA.Length];
            }
            else if (listaA.Length > listaB.Length)
            {
                arreglo = new T[listaB.Length];
            }
            else
            {
                arreglo = new T[listaA.Length];
            }

            //agregando valores al arreglo
            for (int i = 0; i < arreglo.Length; i++)
            {
                
            }
            return arreglo;
        }
    }
}