using System;

public interface IBinTree{
    int Valor {get;}

    IBinTree Derecho {get;}

    IBinTree Izquierdo {get;}

    int Sumar();
    int Minimo();
    int Reduce(int inicial, Func<int, int, int, int> fn);
}