using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace _06_29
{
    public partial class StringForm : Form
    {
        public StringForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string input = inputStringTextBox.Text;
            string output = Transform.Convert(input, kirillRB.Checked, maxRB.Checked);
            outputStringTextBox.Text = output;
        }
    }
}
