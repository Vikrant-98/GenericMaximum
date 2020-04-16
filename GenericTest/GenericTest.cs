using System;
using Xunit;
using MaximumGeneric;

namespace GenericTest
{
    public class GenericTest<AnyDataType>
    {
        /// <summary>
        /// Checking for Generic Integer datatype
        /// </summary>
        [Fact]
        public void GeneticIntTest()
        {
            GenericCheck<int> obj = new GenericCheck<int>();
            int actual = (obj.Max(22, 33, 90));
            Assert.Equal(90, actual);
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
        [Fact]
        public void GeneticMaximumTest()
        {
            GenericCheck<int> obj1 = new GenericCheck<int>();
            GenericCheck<double> obj2 = new GenericCheck<double>();
            GenericCheck<String> obj3 = new GenericCheck<String>();
            int[] arr1 = { 88, 8, 56, 75 };
            double[] arr2 = { 8.8, 1.2, 5.6, 7.5 };
            String[] arr3 = { "88", "8", "56", "75" };
            int actual1 = (obj1.Max(arr1));
            double actual2 = (obj2.Max(arr2));
            String actual3 = (obj3.Max(arr3));
            Assert.Equal(88, actual1);
            Assert.Equal(8.8, actual2);
            Assert.Equal("88", actual3);
        }
    }
}
