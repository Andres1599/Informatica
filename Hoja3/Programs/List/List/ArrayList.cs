public class ArrayList<T> : Lista<T> where T : new()
{
    //Propiedades
    private T[] almacenamiento { get; set; }
    public ArrayList(T[] elemento)
    {
        this.almacenamiento = elemento;
    }

    public override bool Get(int indice, out T y)
    {
        y = new T();
        if (indice >= almacenamiento.Length)
        {
            return false;
        }
        else
        {
            y = almacenamiento[indice];
            return true;
        }
        throw new System.NotImplementedException();
    }

    public override int Length()
    {
        return this.almacenamiento.Length;
        throw new System.NotImplementedException();
    }

    public override void Push(T elemento)
    {
        T[] comodin = new T[almacenamiento.Length + 1];
        for (int i = 0; i < almacenamiento.Length; i++)
        {
            comodin[i] = almacenamiento[i];
        }
        comodin[comodin.Length - 1] = elemento;
        almacenamiento = comodin;
        throw new System.NotImplementedException();
    }

    public override bool Set(int x, T elemento)
    {

        if (x >= Length())
        {
            return false;
        }
        else
        {
            almacenamiento[x] = elemento;
            return true;
        }
        throw new System.NotImplementedException();
    }

    public override void Push(IList<T> elemento)
    {
        throw new System.NotImplementedException();
    }
}
