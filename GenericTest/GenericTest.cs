using System;
using Xunit;
using MaximumGeneric;

namespace GenericTest
{
    public class GenericTest
    {
        GenericCheck obj = new GenericCheck();
        [Fact]
        public void GeneticIntTest()
        {
            int actual = (obj.Max(22, 33, 90));
            Assert.Equal(90,actual);
        }
        [Fact]
        public void GeneticFloatTest()
        {
            double actual = (obj.Max(2.6, 3.3, 8.2));
            Assert.Equal(8.2, actual);
        }
        [Fact]
        public void GeneticStringTest()
        {
            String actual = (obj.Max("26", "33", "82"));
            Assert.Equal("82", actual);
        }
    }
}
