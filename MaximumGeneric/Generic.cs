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
    /// Generic Class createg to check Maximum of many Data Entry
    /// </summary>
    /// <typeparam name="AnyDataType"></typeparam>
        public class GenericCheck<AnyDataType>
        {
            public AnyDataType Max(AnyDataType[] data)
        {
                AnyDataType[] array = new AnyDataType[data.Length];
                for (int index = 0; index < data.Length ; index++ )
                {
                array[index] = data[index];
                }
                AnyDataType MaximumValue = array.Max();
                return MaximumValue;
            }
        }
}
