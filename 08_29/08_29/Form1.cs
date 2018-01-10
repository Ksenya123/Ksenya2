using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace _08_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int N, M;
            if (!int.TryParse(nTB.Text, out N) || !int.TryParse(mTB.Text, out M))
            {
                MessageBox.Show("Размерность задана неверно!");
                return;
            }

            UpdateDGV(Matrix, N, M);
        }

        //Изменяет размер матрицы
        private void UpdateDGV(DataGridView DGV, int N, int M)
        {
            DGV.RowCount = M;
            DGV.ColumnCount = N;
            for (int i = 0; i < N; i++)
            {
                DGV.Columns[i].Name = (i + 1).ToString();
                DGV.Columns[i].Width = 40;
            }
        }

        Random random = new Random();
        private void FillRandom(DataGridView DGV)
        {
            for (int i = 0; i < DGV.ColumnCount; i++)
                for (int j = 0; j < DGV.RowCount; j++)
                    DGV[i, j].Value = random.Next(-200, 200) / 10.0;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            FillRandom(Matrix);
        }

        private double[,] FromDGVToArray(DataGridView DGV)
        {
            double[,] array = new double[DGV.ColumnCount, DGV.RowCount];
            for (int col = 0; col < DGV.ColumnCount; col++)
            {
                for (int row = 0; row < DGV.RowCount; row++)
                {
                    if (!Double.TryParse(DGV[col, row].Value.ToString(), out array[col, row]))
                    {
                        MessageBox.Show("Один из элементов матрицы [" + (col + 1)
                            + ':' + (row + 1) + "] записан некорректно ");
                        return null;
                    }
                }
            }
            return array;
        }

        private void FromArrayToDGV(DataGridView DGV, double[,] values)
        {
            UpdateDGV(DGV, values.GetLength(0), values.GetLength(1));
            for (int i = 0; i < DGV.ColumnCount; i++)
                for (int j = 0; j < DGV.RowCount; j++)
                    DGV[i, j].Value = values[i, j];
        }

        private void doDoubleElemsButton_Click(object sender, EventArgs e)
        {
            double[,] matrix = FromDGVToArray(Matrix);
            int[] point = MatrixWork.GetPoint(matrix, maxRB.Checked);
            double[,] result = MatrixWork.DoDouble(matrix, point, rowRB.Checked);
            FromArrayToDGV(Matrix, result);
        }
    }
}
