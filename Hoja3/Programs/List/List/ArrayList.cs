public class ArrayList<T> : Lista<T>
{
    //Propiedades
    private T[] almacenamiento { get; set; }
    public ArrayList<T> Resto{ get; private set;}
    public ArrayList(T elemento)
    {

    }

    public override bool Get(int x, out int y)
    {
        throw new System.NotImplementedException();
    }

    public override int Length()
    {
        return NewMethod();
        throw new System.NotImplementedException();
    }

    private int NewMethod()
    {
        ArrayList<T> lista = this;
        int len = 0;

        while (lista.Resto != null)
        {
            lista = lista.Resto;
            len++;
        }

        return len;
    }

    public override void Push(T elemento)
    {
        throw new System.NotImplementedException();
    }

    public override bool Set(int x, T elemento)
    {
        throw new System.NotImplementedException();
    }

    public override void Push(IList<T> elemento)
    {
        throw new System.NotImplementedException();
    }
}
