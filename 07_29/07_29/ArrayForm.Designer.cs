namespace _07_29
{
    partial class ArrayForm
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
            this.nLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.nButton = new System.Windows.Forms.Button();
            this.aLabel = new System.Windows.Forms.Label();
            this.AnDGV = new System.Windows.Forms.DataGridView();
            this.FillButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(13, 13);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(63, 13);
            this.nLabel.TabIndex = 2;
            this.nLabel.Text = "Введите N:";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(72, 10);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(28, 20);
            this.nTextBox.TabIndex = 3;
            this.nTextBox.Text = "10";
            // 
            // nButton
            // 
            this.nButton.Location = new System.Drawing.Point(106, 8);
            this.nButton.Name = "nButton";
            this.nButton.Size = new System.Drawing.Size(60, 23);
            this.nButton.TabIndex = 4;
            this.nButton.Text = "Задать";
            this.nButton.UseVisualStyleBackColor = true;
            this.nButton.Click += new System.EventHandler(this.nButton_Click);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(13, 36);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(49, 13);
            this.aLabel.TabIndex = 6;
            this.aLabel.Text = "Массив:";
            // 
            // AnDGV
            // 
            this.AnDGV.AllowDrop = true;
            this.AnDGV.AllowUserToAddRows = false;
            this.AnDGV.AllowUserToDeleteRows = false;
            this.AnDGV.AllowUserToOrderColumns = true;
            this.AnDGV.AllowUserToResizeColumns = false;
            this.AnDGV.AllowUserToResizeRows = false;
            this.AnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnDGV.Location = new System.Drawing.Point(16, 52);
            this.AnDGV.Name = "AnDGV";
            this.AnDGV.Size = new System.Drawing.Size(602, 58);
            this.AnDGV.TabIndex = 5;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(172, 8);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(81, 23);
            this.FillButton.TabIndex = 9;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(259, 8);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(224, 23);
            this.maxButton.TabIndex = 14;
            this.maxButton.Text = "Найти кол-во отрицательных элементов";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(14, 113);
            this.resultLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(62, 13);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Результат:";
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 160);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.FillButton);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.AnDGV);
            this.Controls.Add(this.nButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Name = "ArrayForm";
            this.Text = "Массив";
            ((System.ComponentModel.ISupportInitialize)(this.AnDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button nButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.DataGridView AnDGV;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

