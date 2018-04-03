using System;
using System.Collections.Generic;
using System.Text;

namespace RecuperacionParcial
{
    public abstract class LineaAbstracta<T> : ILinea<T>
    {
        public abstract T[] Punto { get; }

        public double Longitud() {
            double longitud = 0;
            // si no hay ningun punto en el arreglo
            if (Punto.Length == 0 || Punto.Length == 1) {
                return 0;
            }

            for (int i = 0; i < Punto.Length; i++) {
                if (i == Punto.Length) { break; }
                longitud += Distancia(Punto[i], Punto[i + 1]);
            }
            return longitud;
        }

        public T PuntoMasCercano(T punto)
        {

            T PuntoMasCercano = Punto[0];

            for (int i = 0; i < Punto.Length; i++)
            {

                if (Distancia(punto, Punto[i]) < Distancia(punto, PuntoMasCercano))
                {
                    PuntoMasCercano = Punto[i];
                }
            }

            return PuntoMasCercano;
        }

        public abstract double Distancia(T puntoA,T puntoB);

    }
}
