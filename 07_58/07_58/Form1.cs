using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace _07_58
{
    public partial class Form1 : Form
    {
        public Form1()
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
            double[] values = GetValues(AnDGV);
            double[] localMaxs = ArrayWork.GetLocalMaxs(values);
            if (localMaxs.Length == 0)
            {
                resultLabel.Text = "Результат: Локальных максимумов нет";
                return;
            }
            double max = ArrayWork.GetMinFromMaxs(localMaxs);
            resultLabel.Text = "Результат: " + max;
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
