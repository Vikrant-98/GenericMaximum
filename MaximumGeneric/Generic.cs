using System;
using System.Linq;

namespace MaximumGeneric
{
    public class Generic
    {
        static void Main(string[] args)
        {
        }
    }

    public class GenericCheck
    {
        public int Max(int data1, int data2, int data3)
        {
            int[] array = { data1, data2, data3 };
            int MaximumValue = array.Max();
            return MaximumValue;
        }
    }
}
