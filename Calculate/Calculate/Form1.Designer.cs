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
            this.sin = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.pix = new System.Windows.Forms.Button();
            this.clrscr = new System.Windows.Forms.Button();
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
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(12, 249);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 9;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(93, 249);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 10;
            this.arcsin.Text = "arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.arcsin_Click);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(174, 249);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(75, 23);
            this.tg.TabIndex = 11;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(174, 278);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(75, 23);
            this.sqr.TabIndex = 12;
            this.sqr.Text = "X ^ 2";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.sqr_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(93, 278);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 23);
            this.sqrt.TabIndex = 13;
            this.sqrt.Text = "V¯";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // pix
            // 
            this.pix.Location = new System.Drawing.Point(12, 278);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(75, 23);
            this.pix.TabIndex = 14;
            this.pix.Text = "PI ^ x";
            this.pix.UseVisualStyleBackColor = true;
            this.pix.Click += new System.EventHandler(this.pix_Click);
            // 
            // clrscr
            // 
            this.clrscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clrscr.Location = new System.Drawing.Point(206, 47);
            this.clrscr.Name = "clrscr";
            this.clrscr.Size = new System.Drawing.Size(43, 34);
            this.clrscr.TabIndex = 15;
            this.clrscr.Text = "C";
            this.clrscr.UseVisualStyleBackColor = true;
            this.clrscr.Click += new System.EventHandler(this.clrscr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(302, 329);
            this.Controls.Add(this.clrscr);
            this.Controls.Add(this.pix);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.deducation);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.ResultArgument);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.FirstArgument);
            this.Name = "Form1";
            this.Text = "Calculate";
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
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button pix;
        private System.Windows.Forms.Button clrscr;

    }
}

