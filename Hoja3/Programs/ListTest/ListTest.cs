using System;
using System.Collections.Generic;
using Xunit;
public class ListTest
{
    [Fact]
    public void Test1()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int retorno = 0;
        IList<int> valor = new ArrayList<int>(array);
        valor.Push(6);
        valor.Get(valor.Length() - 1, retorno);
    }

    [Fact]
    public void Test2()
    {
        int[] array = {2,3,4,5};
        IList<int> valor = new ArrayList<int>(array);
        int retorno = 0;
        if(!valor.Get(10,out retorno)){
            Console.WriteLine("Error");
        }
    }

    [Fact]
    public void Test3()
    {
        int[] array = {1,2,3};
        IList<int> valor = new ArrayList<int>(array);
    }
}

