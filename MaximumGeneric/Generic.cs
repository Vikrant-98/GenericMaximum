﻿using System;
using System.Linq;

namespace MaximumGeneric
{
    public class Generic
    {
        static void Main(string[] args)
        {
        }
    }
    
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
