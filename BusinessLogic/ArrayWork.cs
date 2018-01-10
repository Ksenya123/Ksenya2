using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class ArrayWork
    {
        //7.29
        public static double[] GetNegativeValues(double[] array)
        {
            double[] resultArray = new double[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[resultArray.Length - 1] = array[i];
                }
            }
            return resultArray;
        }

        //7.58
        public static double GetMinFromMaxs(double[] data)
        {
            double min = data[0];
            for (int i = 1; i < data.Length; i++)
                if (data[i] < min)
                    min = data[i];
            return min;
        }

        //7.58
        public static double[] GetLocalMaxs(double[] data)
        {
            double[] array = new double[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (IsLocalMax(data, i))
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = data[i];
                }
            }
            return array;
        }

        //7.58
        private static bool IsLocalMax(double[] data, int idx)
        {
            return ((idx - 1 < 0 || data[idx - 1] < data[idx]) &&
                    (idx + 1 == data.Length || data[idx + 1] < data[idx]));
        }
    }
}
