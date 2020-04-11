using System;
using Xunit;
using MaximumGeneric;

namespace GenericTest
{
    public class GenericTest
    {
        /// <summary>
        /// Checking for Generic Integer datatype
        /// </summary>
        [Fact]
        public void GeneticIntTest()
        {
            GenericCheck<int> obj = new GenericCheck<int>();
            int actual = (obj.Max(22, 33, 90));
            Assert.Equal(90,actual);
        }
        /// <summary>
        /// Checking for Generic Float datatype
        /// </summary>
        [Fact]
        public void GeneticFloatTest()
        {
            GenericCheck<double> obj = new GenericCheck<double>();
            double actual = (obj.Max(2.6, 3.3, 8.2));
            Assert.Equal(8.2, actual);
        }
        /// <summary>
        /// Checking for Generic String datatype
        /// </summary>
        [Fact]
        public void GeneticStringTest()
        {
            GenericCheck<String> obj = new GenericCheck<String>();
            String actual = (obj.Max("26", "33", "82"));
            Assert.Equal("82", actual);
        }
    }
}
