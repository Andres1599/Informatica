using System;
public class BinaryTree : IBinTree{
    public int Valor {get;}

    public IBinTree Derecho {get;}

    public IBinTree Izquierdo {get;}

    public BinaryTree(int valor, IBinTree derecho, IBinTree izquierdo){
        this.Valor = valor;
        this.Derecho = derecho;
        this.Izquierdo = izquierdo;
    }

    public BinaryTree(int valor){
        this.Valor = valor;
    }

    public override string ToString(){
        string derecho = this.Derecho == null ? string.Empty : this.Derecho.ToString();
        string izquierdo = this.Izquierdo == null ? string.Empty : this.Izquierdo.ToString();

        return $"{this.Valor} \n\t {derecho} \n\t {izquierdo}";
    }

    public int Minimo() {
        int minimoIzq = this.Valor;
        int minimoDer = this.Valor;
        if (this.Izquierdo == null && this.Derecho == null)
        {
            return this.Valor;
        }
        /*
        else {
            minimoIzq = this.Izquierdo != null && minimoIzq < this.Valor ? Izquierdo.Minimo() : this.Valor;
            minimoDer = this.Derecho != null && minimoDer < this.Valor ? Derecho.Minimo() : this.Valor;
        }*/

        if (this.Izquierdo == null)
            return this.Valor < this.Izquierdo.Minimo() ? this.Valor : this.Izquierdo.Minimo();
        if (this.Derecho == null)
            return this.Valor < this.Derecho.Minimo() ? this.Valor : this.Derecho.Minimo();

        minimoIzq = this.Izquierdo.Minimo();
        minimoDer = this.Derecho.Minimo();

        int minimo = minimoDer < minimoIzq ? minimoDer : minimoIzq;
       
        return this.Valor < minimo ? this.Valor : minimo;
    }

    public int Sumar()
    {
        return this.Reduce(0, (izq, der, valor) => izq + der + valor);
    }

    public int Menor()
    {
        return this.Reduce(this.Valor, (izq, der, valor) => Math.Min(Math.Min(izq, der), valor));
    }

    public int Reduce(int inicial, Func<int, int, int, int> fn)
    {
        int izquierdo = this.Izquierdo == null ? inicial : this.Izquierdo.Reduce(inicial, fn);
        int derecho = this.Derecho == null ? inicial : this.Derecho.Reduce(inicial, fn);

        return fn(izquierdo, derecho, this.Valor);
    }

}