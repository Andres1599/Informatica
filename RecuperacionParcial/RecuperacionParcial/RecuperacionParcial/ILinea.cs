using System;
using System.Collections.Generic;
using System.Text;

namespace RecuperacionParcial
{
    interface ILinea<T>
    {
        double Longitud();
        T PuntoMasCercano(T punto);
    }
}
