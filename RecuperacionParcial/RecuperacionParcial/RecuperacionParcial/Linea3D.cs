using System;
using System.Collections.Generic;
using System.Text;

namespace RecuperacionParcial
{
    class Linea3D : LineaAbstracta<Punto3D>
    {
        
        public override Punto3D[] Punto => throw new NotImplementedException();

        public override double Distancia(Punto3D puntoA, Punto3D puntoB)
        {
            double x = Math.Pow(puntoA.X - puntoB.X, 2);
            double y = Math.Pow(puntoA.Y - puntoB.Y, 2);
            double z = Math.Pow(puntoA.Z - puntoB.Z, 2);
            return Math.Sqrt(x + y + z);
            throw new NotImplementedException();
        }

        public Linea3D(Punto3D[] puntos)
        {
            Punto = puntos;
        }
    }
}
