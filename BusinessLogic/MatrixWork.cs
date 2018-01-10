using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class MatrixWork
    {
        //8.29
        public static double[,] DoDouble(double[,] data, int[] point, bool rowFlag)
        {
            double[,] result;
            if (rowFlag)
            {
                result = new double[data.GetLength(0), data.GetLength(1) + 1];
                for (int r = 0; r <= point[1]; r++)
                    for (int c = 0; c < result.GetLength(0); c++)
                        result[c, r] = data[c, r];
                for (int r = point[1] + 1; r < result.GetLength(1); r++)
                    for (int c = 0; c < result.GetLength(0); c++)
                        result[c, r] = data[c, r - 1];
            }
            else
            {
                result = new double[data.GetLength(0) + 1, data.GetLength(1)];
                for (int c = 0; c <= point[0]; c++)
                    for (int r = 0; r < result.GetLength(1); r++)
                        result[c, r] = data[c, r];
                for (int c = point[0] + 1; c < result.GetLength(0); c++)
                    for (int r = 0; r < result.GetLength(1); r++)
                        result[c, r] = data[c - 1, r];
            }
            return result;
        }

        //8.29
        public static int[] GetPoint(double[,] data, bool maxFlag)
        {
            int[] points = new int[2] { 0, 0 };
            for (int col = 0; col < data.GetLength(0); col++)
                for (int row = 0; row < data.GetLength(1); row++)
                    if (!maxFlag && data[col, row] < data[points[0], points[1]] ||
                        maxFlag && data[col, row] > data[points[0], points[1]])
                    {
                        points[0] = col;
                        points[1] = row;
                    }
            return points;
        }
    }
}
