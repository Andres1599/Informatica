using System;
using Xunit;

namespace BinaryTreeTests
{
    public class BinaryTreeTests
    {

        [Fact]
        public void TestInsert()
        {
            IBinTree sut = new BinaryTree(10);
            sut.Insert(9);
            sut.Insert(8);
            sut.Insert(7);
            sut.Insert(6);
            sut.Insert(5);
            sut.Insert(4);
            sut.Insert(3)
                ;
            int[] result = sut.ToArray();

            Assert.Equal(new int[] { 3,4,5,6,7,8,9,10 }, result);
        }
    }
}
