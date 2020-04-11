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
    /// <summary>
    /// Generic Class createg to check Maximum of 3 Data Entry
    /// </summary>
    /// <typeparam name="AnyDataType"></typeparam>
        public class GenericCheck<AnyDataType>
        {
            public AnyDataType Max(AnyDataType data1, AnyDataType data2, AnyDataType data3)
            {
                AnyDataType[] array = { data1, data2, data3 };
                AnyDataType MaximumValue = array.Max();
                return MaximumValue;
            }
        }
}
