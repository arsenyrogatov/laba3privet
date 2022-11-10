namespace laba3privet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.table_textBox = new System.Windows.Forms.TextBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.code_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Арифметическое кодирование";
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(18, 119);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(890, 407);
            this.input_textBox.TabIndex = 1;
            this.input_textBox.Text = resources.GetString("input_textBox.Text");
            // 
            // table_textBox
            // 
            this.table_textBox.Location = new System.Drawing.Point(914, 119);
            this.table_textBox.Multiline = true;
            this.table_textBox.Name = "table_textBox";
            this.table_textBox.ReadOnly = true;
            this.table_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table_textBox.Size = new System.Drawing.Size(462, 407);
            this.table_textBox.TabIndex = 2;
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(18, 580);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(1358, 41);
            this.result_textBox.TabIndex = 3;
            // 
            // code_button
            // 
            this.code_button.AutoSize = true;
            this.code_button.Location = new System.Drawing.Point(599, 629);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(189, 44);
            this.code_button.TabIndex = 4;
            this.code_button.Text = "Кодировать!";
            this.code_button.UseVisualStyleBackColor = true;
            this.code_button.Click += new System.EventHandler(this.code_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст для кодирования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 683);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.code_button);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.table_textBox);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ъуъ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox table_textBox;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.Button code_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

