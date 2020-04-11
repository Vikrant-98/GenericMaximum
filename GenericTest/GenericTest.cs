using System;
using Xunit;
using MaximumGeneric;

namespace GenericTest
{
    public class GenericTest
    {
        [Fact]
        public void GeneticIntTest()
        {
            GenericCheck obj = new GenericCheck();
            int actual = (obj.Max(22, 33, 90));
            Assert.Equal(88,actual);
        }
    }
}
