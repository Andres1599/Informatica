public interface IList<T> where T : new()
{
    bool Get(int x, out T y);
    bool Set(int x, T elemento);
    void Push(T elemento);
    int Length();

}