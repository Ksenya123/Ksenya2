namespace _06_29
{
    partial class StringForm
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
            this.inputStringLabel = new System.Windows.Forms.Label();
            this.inputStringTextBox = new System.Windows.Forms.TextBox();
            this.languageTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.kirillRB = new System.Windows.Forms.RadioButton();
            this.latinRB = new System.Windows.Forms.RadioButton();
            this.minRB = new System.Windows.Forms.RadioButton();
            this.maxRB = new System.Windows.Forms.RadioButton();
            this.outputStringLabel = new System.Windows.Forms.Label();
            this.outputStringTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.languageTypeGroupBox.SuspendLayout();
            this.sizeTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputStringLabel
            // 
            this.inputStringLabel.AutoSize = true;
            this.inputStringLabel.Location = new System.Drawing.Point(13, 13);
            this.inputStringLabel.Name = "inputStringLabel";
            this.inputStringLabel.Size = new System.Drawing.Size(97, 13);
            this.inputStringLabel.TabIndex = 0;
            this.inputStringLabel.Text = "Исходная строка:";
            // 
            // inputStringTextBox
            // 
            this.inputStringTextBox.Location = new System.Drawing.Point(116, 10);
            this.inputStringTextBox.Name = "inputStringTextBox";
            this.inputStringTextBox.Size = new System.Drawing.Size(292, 20);
            this.inputStringTextBox.TabIndex = 1;
            // 
            // languageTypeGroupBox
            // 
            this.languageTypeGroupBox.Controls.Add(this.latinRB);
            this.languageTypeGroupBox.Controls.Add(this.kirillRB);
            this.languageTypeGroupBox.Location = new System.Drawing.Point(16, 40);
            this.languageTypeGroupBox.Name = "languageTypeGroupBox";
            this.languageTypeGroupBox.Size = new System.Drawing.Size(158, 69);
            this.languageTypeGroupBox.TabIndex = 2;
            this.languageTypeGroupBox.TabStop = false;
            this.languageTypeGroupBox.Text = "Языковой тип:";
            // 
            // sizeTypeGroupBox
            // 
            this.sizeTypeGroupBox.Controls.Add(this.maxRB);
            this.sizeTypeGroupBox.Controls.Add(this.minRB);
            this.sizeTypeGroupBox.Location = new System.Drawing.Point(180, 40);
            this.sizeTypeGroupBox.Name = "sizeTypeGroupBox";
            this.sizeTypeGroupBox.Size = new System.Drawing.Size(158, 69);
            this.sizeTypeGroupBox.TabIndex = 3;
            this.sizeTypeGroupBox.TabStop = false;
            this.sizeTypeGroupBox.Text = "Размерный тип:";
            // 
            // kirillRB
            // 
            this.kirillRB.AutoSize = true;
            this.kirillRB.Checked = true;
            this.kirillRB.Location = new System.Drawing.Point(7, 20);
            this.kirillRB.Name = "kirillRB";
            this.kirillRB.Size = new System.Drawing.Size(67, 17);
            this.kirillRB.TabIndex = 0;
            this.kirillRB.TabStop = true;
            this.kirillRB.Text = "Русские";
            this.kirillRB.UseVisualStyleBackColor = true;
            // 
            // latinRB
            // 
            this.latinRB.AutoSize = true;
            this.latinRB.Location = new System.Drawing.Point(6, 43);
            this.latinRB.Name = "latinRB";
            this.latinRB.Size = new System.Drawing.Size(80, 17);
            this.latinRB.TabIndex = 1;
            this.latinRB.Text = "Латинские";
            this.latinRB.UseVisualStyleBackColor = true;
            // 
            // minRB
            // 
            this.minRB.AutoSize = true;
            this.minRB.Checked = true;
            this.minRB.Location = new System.Drawing.Point(6, 20);
            this.minRB.Name = "minRB";
            this.minRB.Size = new System.Drawing.Size(74, 17);
            this.minRB.TabIndex = 2;
            this.minRB.TabStop = true;
            this.minRB.Text = "Строчные";
            this.minRB.UseVisualStyleBackColor = true;
            // 
            // maxRB
            // 
            this.maxRB.AutoSize = true;
            this.maxRB.Location = new System.Drawing.Point(6, 43);
            this.maxRB.Name = "maxRB";
            this.maxRB.Size = new System.Drawing.Size(147, 17);
            this.maxRB.TabIndex = 3;
            this.maxRB.Text = "Прописные (заглавные)";
            this.maxRB.UseVisualStyleBackColor = true;
            // 
            // outputStringLabel
            // 
            this.outputStringLabel.AutoSize = true;
            this.outputStringLabel.Location = new System.Drawing.Point(13, 130);
            this.outputStringLabel.Name = "outputStringLabel";
            this.outputStringLabel.Size = new System.Drawing.Size(135, 13);
            this.outputStringLabel.TabIndex = 4;
            this.outputStringLabel.Text = "Результирующая строка:";
            // 
            // outputStringTextBox
            // 
            this.outputStringTextBox.Location = new System.Drawing.Point(154, 127);
            this.outputStringTextBox.Name = "outputStringTextBox";
            this.outputStringTextBox.Size = new System.Drawing.Size(292, 20);
            this.outputStringTextBox.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(356, 60);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(104, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Преобразовать";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // StringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 165);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputStringTextBox);
            this.Controls.Add(this.outputStringLabel);
            this.Controls.Add(this.sizeTypeGroupBox);
            this.Controls.Add(this.languageTypeGroupBox);
            this.Controls.Add(this.inputStringTextBox);
            this.Controls.Add(this.inputStringLabel);
            this.Name = "StringForm";
            this.Text = "Преобразование строки";
            this.languageTypeGroupBox.ResumeLayout(false);
            this.languageTypeGroupBox.PerformLayout();
            this.sizeTypeGroupBox.ResumeLayout(false);
            this.sizeTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputStringLabel;
        private System.Windows.Forms.TextBox inputStringTextBox;
        private System.Windows.Forms.GroupBox languageTypeGroupBox;
        private System.Windows.Forms.RadioButton latinRB;
        private System.Windows.Forms.RadioButton kirillRB;
        private System.Windows.Forms.GroupBox sizeTypeGroupBox;
        private System.Windows.Forms.RadioButton maxRB;
        private System.Windows.Forms.RadioButton minRB;
        private System.Windows.Forms.Label outputStringLabel;
        private System.Windows.Forms.TextBox outputStringTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

