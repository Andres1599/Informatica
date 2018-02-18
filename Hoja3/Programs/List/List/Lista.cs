public abstract class Lista<T> : IList<T>
{
    public abstract bool Get(int x, out int y);
    public abstract int Length();
    public abstract void Push(T elemento);
    public abstract void Push(IList<T> elemento);    
    public abstract bool Set(int x, T elemento);
}
