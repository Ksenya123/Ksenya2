namespace _08_29
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Matrix = new System.Windows.Forms.DataGridView();
            this.nLabel = new System.Windows.Forms.Label();
            this.nTB = new System.Windows.Forms.TextBox();
            this.mTB = new System.Windows.Forms.TextBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.minmaxGB = new System.Windows.Forms.GroupBox();
            this.maxRB = new System.Windows.Forms.RadioButton();
            this.minRB = new System.Windows.Forms.RadioButton();
            this.elemGB = new System.Windows.Forms.GroupBox();
            this.colRB = new System.Windows.Forms.RadioButton();
            this.rowRB = new System.Windows.Forms.RadioButton();
            this.doDoubleElemsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).BeginInit();
            this.minmaxGB.SuspendLayout();
            this.elemGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Matrix
            // 
            this.Matrix.AllowDrop = true;
            this.Matrix.AllowUserToAddRows = false;
            this.Matrix.AllowUserToDeleteRows = false;
            this.Matrix.AllowUserToOrderColumns = true;
            this.Matrix.AllowUserToResizeColumns = false;
            this.Matrix.AllowUserToResizeRows = false;
            this.Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix.Location = new System.Drawing.Point(12, 12);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(361, 225);
            this.Matrix.TabIndex = 0;
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(380, 13);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(18, 13);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "N:";
            // 
            // nTB
            // 
            this.nTB.Location = new System.Drawing.Point(395, 10);
            this.nTB.Name = "nTB";
            this.nTB.Size = new System.Drawing.Size(31, 20);
            this.nTB.TabIndex = 2;
            this.nTB.Text = "5";
            // 
            // mTB
            // 
            this.mTB.Location = new System.Drawing.Point(447, 10);
            this.mTB.Name = "mTB";
            this.mTB.Size = new System.Drawing.Size(31, 20);
            this.mTB.TabIndex = 4;
            this.mTB.Text = "5";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(432, 13);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(19, 13);
            this.mLabel.TabIndex = 3;
            this.mLabel.Text = "M:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(484, 8);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(92, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(484, 37);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(92, 23);
            this.FillButton.TabIndex = 10;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // minmaxGB
            // 
            this.minmaxGB.Controls.Add(this.maxRB);
            this.minmaxGB.Controls.Add(this.minRB);
            this.minmaxGB.Location = new System.Drawing.Point(383, 66);
            this.minmaxGB.Name = "minmaxGB";
            this.minmaxGB.Size = new System.Drawing.Size(193, 65);
            this.minmaxGB.TabIndex = 11;
            this.minmaxGB.TabStop = false;
            this.minmaxGB.Text = "Крайность";
            // 
            // maxRB
            // 
            this.maxRB.AutoSize = true;
            this.maxRB.Location = new System.Drawing.Point(12, 43);
            this.maxRB.Name = "maxRB";
            this.maxRB.Size = new System.Drawing.Size(103, 17);
            this.maxRB.TabIndex = 1;
            this.maxRB.Text = "максимальный";
            this.maxRB.UseVisualStyleBackColor = true;
            // 
            // minRB
            // 
            this.minRB.AutoSize = true;
            this.minRB.Checked = true;
            this.minRB.Location = new System.Drawing.Point(12, 20);
            this.minRB.Name = "minRB";
            this.minRB.Size = new System.Drawing.Size(97, 17);
            this.minRB.TabIndex = 0;
            this.minRB.TabStop = true;
            this.minRB.Text = "минимальный";
            this.minRB.UseVisualStyleBackColor = true;
            // 
            // elemGB
            // 
            this.elemGB.Controls.Add(this.colRB);
            this.elemGB.Controls.Add(this.rowRB);
            this.elemGB.Location = new System.Drawing.Point(383, 137);
            this.elemGB.Name = "elemGB";
            this.elemGB.Size = new System.Drawing.Size(193, 68);
            this.elemGB.TabIndex = 12;
            this.elemGB.TabStop = false;
            this.elemGB.Text = "Элементы";
            // 
            // colRB
            // 
            this.colRB.AutoSize = true;
            this.colRB.Location = new System.Drawing.Point(12, 43);
            this.colRB.Name = "colRB";
            this.colRB.Size = new System.Drawing.Size(68, 17);
            this.colRB.TabIndex = 1;
            this.colRB.Text = "столбцы";
            this.colRB.UseVisualStyleBackColor = true;
            // 
            // rowRB
            // 
            this.rowRB.AutoSize = true;
            this.rowRB.Checked = true;
            this.rowRB.Location = new System.Drawing.Point(12, 20);
            this.rowRB.Name = "rowRB";
            this.rowRB.Size = new System.Drawing.Size(60, 17);
            this.rowRB.TabIndex = 0;
            this.rowRB.TabStop = true;
            this.rowRB.Text = "строки";
            this.rowRB.UseVisualStyleBackColor = true;
            // 
            // doDoubleElemsButton
            // 
            this.doDoubleElemsButton.Location = new System.Drawing.Point(383, 211);
            this.doDoubleElemsButton.Name = "doDoubleElemsButton";
            this.doDoubleElemsButton.Size = new System.Drawing.Size(193, 26);
            this.doDoubleElemsButton.TabIndex = 13;
            this.doDoubleElemsButton.Text = "Продублировать";
            this.doDoubleElemsButton.UseVisualStyleBackColor = true;
            this.doDoubleElemsButton.Click += new System.EventHandler(this.doDoubleElemsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 254);
            this.Controls.Add(this.doDoubleElemsButton);
            this.Controls.Add(this.elemGB);
            this.Controls.Add(this.minmaxGB);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.mTB);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.nTB);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.Matrix);
            this.Name = "Form1";
            this.Text = "Матрица";
            ((System.ComponentModel.ISupportInitialize)(this.Matrix)).EndInit();
            this.minmaxGB.ResumeLayout(false);
            this.minmaxGB.PerformLayout();
            this.elemGB.ResumeLayout(false);
            this.elemGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Matrix;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nTB;
        private System.Windows.Forms.TextBox mTB;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.GroupBox minmaxGB;
        private System.Windows.Forms.RadioButton maxRB;
        private System.Windows.Forms.RadioButton minRB;
        private System.Windows.Forms.GroupBox elemGB;
        private System.Windows.Forms.RadioButton colRB;
        private System.Windows.Forms.RadioButton rowRB;
        private System.Windows.Forms.Button doDoubleElemsButton;
    }
}

