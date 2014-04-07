namespace Calc
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
            this.components = new System.ComponentModel.Container();
            this.firstArgument = new System.Windows.Forms.TextBox();
            this.multiplycation = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.secondArgument = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultField = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstArgument
            // 
            this.firstArgument.Location = new System.Drawing.Point(12, 9);
            this.firstArgument.Name = "firstArgument";
            this.firstArgument.Size = new System.Drawing.Size(260, 20);
            this.firstArgument.TabIndex = 0;
            this.firstArgument.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // multiplycation
            // 
            this.multiplycation.Location = new System.Drawing.Point(5, 164);
            this.multiplycation.Name = "multiplycation";
            this.multiplycation.Size = new System.Drawing.Size(31, 84);
            this.multiplycation.TabIndex = 1;
            this.multiplycation.Text = "*";
            this.multiplycation.UseVisualStyleBackColor = true;
            this.multiplycation.Click += new System.EventHandler(this.multiplycationf_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(38, 164);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(187, 84);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(203, 68);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(22, 90);
            this.additionButton.TabIndex = 4;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // substractionButton
            // 
            this.substractionButton.Location = new System.Drawing.Point(5, 68);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(192, 90);
            this.substractionButton.TabIndex = 5;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.substractionButton_Click);
            // 
            // secondArgument
            // 
            this.secondArgument.Location = new System.Drawing.Point(373, 12);
            this.secondArgument.Name = "secondArgument";
            this.secondArgument.Size = new System.Drawing.Size(260, 20);
            this.secondArgument.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Аргумент 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Аргемент 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(17, 268);
            this.resultField.Name = "resultField";
            this.resultField.ReadOnly = true;
            this.resultField.Size = new System.Drawing.Size(625, 20);
            this.resultField.TabIndex = 10;
            this.resultField.Tag = "орб";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.SquareClick);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(447, 68);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(139, 37);
            this.Square.TabIndex = 13;
            this.Square.Text = "X^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.SquareClick);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Location = new System.Drawing.Point(334, 68);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(75, 23);
            this.SqrtButton.TabIndex = 14;
            this.SqrtButton.Text = "Sqrt";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.Sqrt);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "x^y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ln";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Tan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(460, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "n!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Calc.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(705, 395);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondArgument);
            this.Controls.Add(this.substractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplycation);
            this.Controls.Add(this.firstArgument);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArgument;
        private System.Windows.Forms.Button multiplycation;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.TextBox secondArgument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultField;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

    }
}

