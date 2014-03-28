namespace Calculate
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
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.ResultArgument = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.deducation = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new System.Drawing.Point(85, 21);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(100, 20);
            this.FirstArgument.TabIndex = 0;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(85, 47);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(100, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // ResultArgument
            // 
            this.ResultArgument.Location = new System.Drawing.Point(85, 73);
            this.ResultArgument.Name = "ResultArgument";
            this.ResultArgument.Size = new System.Drawing.Size(100, 20);
            this.ResultArgument.TabIndex = 2;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(12, 119);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 23);
            this.Sum.TabIndex = 3;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(12, 148);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 23);
            this.substraction.TabIndex = 4;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(93, 119);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // deducation
            // 
            this.deducation.Location = new System.Drawing.Point(93, 148);
            this.deducation.Name = "deducation";
            this.deducation.Size = new System.Drawing.Size(75, 23);
            this.deducation.TabIndex = 6;
            this.deducation.Text = "/";
            this.deducation.UseVisualStyleBackColor = true;
            this.deducation.Click += new System.EventHandler(this.deducation_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(174, 119);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.deducation);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.ResultArgument);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.FirstArgument);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstArgument;
        private System.Windows.Forms.TextBox SecondArgument;
        private System.Windows.Forms.TextBox ResultArgument;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button deducation;
        private System.Windows.Forms.Button cos;

    }
}

