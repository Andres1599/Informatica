using System;
using Xunit;

namespace BinTreeTests
{
    public class BinTreeTests
    {
        [Fact]
        public void TestSuma()
        {
            IBinTree sut = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );

            Assert.Equal(26, sut.Sumar());
        }

        [Fact]
        public void TestMinimo() {
            IBinTree sut = new BinaryTree(
                  10,
                  new BinaryTree(20),
                  new BinaryTree(
                      50,
                      new BinaryTree(2),
                      null
                  )
              );

            Assert.Equal(2, sut.Minimo());
        }
    }
}
