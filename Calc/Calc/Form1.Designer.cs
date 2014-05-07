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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstArgument
            // 
            this.firstArgument.Location = new System.Drawing.Point(12, 9);
            this.firstArgument.Name = "firstArgument";
            this.firstArgument.Size = new System.Drawing.Size(260, 20);
            this.firstArgument.TabIndex = 0;
            // 
            // multiplycation
            // 
            this.multiplycation.Location = new System.Drawing.Point(10, 61);
            this.multiplycation.Name = "multiplycation";
            this.multiplycation.Size = new System.Drawing.Size(22, 84);
            this.multiplycation.TabIndex = 1;
            this.multiplycation.Text = "*";
            this.multiplycation.UseVisualStyleBackColor = true;
            this.multiplycation.Click += new System.EventHandler(this.Calculate);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(38, 106);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 38);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.Calculate);
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(119, 61);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(22, 83);
            this.additionButton.TabIndex = 4;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.Calculate);
            // 
            // substractionButton
            // 
            this.substractionButton.Location = new System.Drawing.Point(38, 61);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(75, 38);
            this.substractionButton.TabIndex = 5;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.Calculate);
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
            this.label1.Location = new System.Drawing.Point(106, 39);
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
            this.resultField.Location = new System.Drawing.Point(38, 331);
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
            this.label3.Location = new System.Drawing.Point(315, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(319, 135);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 23);
            this.Square.TabIndex = 13;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.SCalculate);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Location = new System.Drawing.Point(400, 195);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(75, 23);
            this.SqrtButton.TabIndex = 14;
            this.SqrtButton.Text = "sqrt";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.SCalculate);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "x^y";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "ln";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SCalculate);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "sin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SCalculate);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(319, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "tan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SCalculate);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "n!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SCalculate);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(319, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "x^3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SCalculate);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(563, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "x^(1/y)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Calculate);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(319, 103);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "sqrt^3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SCalculate);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(563, 252);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "log";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Calculate);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(563, 223);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 24;
            this.button10.Text = "mod";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Calculate);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(563, 281);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 22);
            this.button11.TabIndex = 25;
            this.button11.Text = "exp";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Calculate);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(400, 69);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 26;
            this.button12.Text = "lg";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.SCalculate);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(400, 103);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 27;
            this.button13.Text = "arctg";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SCalculate);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(400, 135);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 28;
            this.button14.Text = "arcsin";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.SCalculate);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(400, 166);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "ctg";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SCalculate);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(319, 194);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 30;
            this.button16.Text = "Arccos";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.SCalculate);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(83, 193);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 31;
            this.button17.Text = "qsort";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.SortCalculate);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(83, 223);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 32;
            this.button18.Text = "InsertionSort";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.SortCalculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Calc.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(705, 395);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;

    }
}

