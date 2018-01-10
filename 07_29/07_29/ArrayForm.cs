using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07_29
{
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            int N;
            if (!int.TryParse(nTextBox.Text, out N))
            {
                MessageBox.Show("N введено некорректно!");
                return;
            }
            UpdateDGV(AnDGV, N);
        }

        //Заполнение таблицы случайными числами
        Random random = new Random();
        private void FillRandom(DataGridView DGV)
        {
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                DGV[i, 0].Value = random.Next(-150, 150) / 10.0;
            }
        }

        //Изменение размера таблицы
        private void UpdateDGV(DataGridView DGV, int N)
        {
            DGV.RowCount = 1;
            DGV.ColumnCount = N;
            for (int i = 0; i < N; i++)
            {
                DGV.Columns[i].Width = 40;
                DGV.Columns[i].Name = (i + 1).ToString();
            }
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            FillRandom(AnDGV);
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            double[] values;
            try
            {
                values = GetValues(AnDGV);
            }
            catch (Exception ex)
            {
                return;
            }
            double[] negativeValues = BusinessLogic.ArrayWork.GetNegativeValues(values);
            string resultString = string.Join(" ", negativeValues);
            int count = negativeValues.Length;
            resultLabel.Text = "Результат - " + count +
                " отрицательных элементов: " + resultString;
        }

        private double[] GetValues(DataGridView DGV)
        {
            int N = DGV.ColumnCount;
            double[] values = new double[N];
            for (int i = 0; i < N; i++)
            {
                if (!double.TryParse(DGV[i, 0].Value.ToString(), out values[i]))
                {
                    MessageBox.Show("Число под номером " + (i + 1) + " некорректно!");
                    throw new Exception();
                }
            }
            return values;
        }
    }
}
