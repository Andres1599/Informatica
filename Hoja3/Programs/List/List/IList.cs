public interface IList<T>
{
     bool Get(int x,out int y);
     bool Set(int x,T elemento);
     void Push(T elemento);
     int Length();

}