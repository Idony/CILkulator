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
            this.multiplycationf = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.secondArgument = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultField = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstArgument
            // 
            this.firstArgument.Location = new System.Drawing.Point(44, 50);
            this.firstArgument.Name = "firstArgument";
            this.firstArgument.Size = new System.Drawing.Size(260, 20);
            this.firstArgument.TabIndex = 0;
            this.firstArgument.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // multiplycationf
            // 
            this.multiplycationf.Location = new System.Drawing.Point(324, 45);
            this.multiplycationf.Name = "multiplycationf";
            this.multiplycationf.Size = new System.Drawing.Size(31, 29);
            this.multiplycationf.TabIndex = 1;
            this.multiplycationf.Text = "*";
            this.multiplycationf.UseVisualStyleBackColor = true;
            this.multiplycationf.Click += new System.EventHandler(this.multiplycationf_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(324, 77);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(33, 29);
            this.divisionButton.TabIndex = 2;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(361, 77);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(33, 29);
            this.additionButton.TabIndex = 4;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // substractionButton
            // 
            this.substractionButton.Location = new System.Drawing.Point(361, 45);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(33, 29);
            this.substractionButton.TabIndex = 5;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.substractionButton_Click);
            // 
            // secondArgument
            // 
            this.secondArgument.Location = new System.Drawing.Point(409, 50);
            this.secondArgument.Name = "secondArgument";
            this.secondArgument.Size = new System.Drawing.Size(260, 20);
            this.secondArgument.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Аргумент 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Аргемент 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(44, 149);
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
            this.label3.Location = new System.Drawing.Point(321, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(714, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondArgument);
            this.Controls.Add(this.substractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplycationf);
            this.Controls.Add(this.firstArgument);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArgument;
        private System.Windows.Forms.Button multiplycationf;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.TextBox secondArgument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultField;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
    }
}

