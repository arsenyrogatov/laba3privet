namespace laba3privet
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bwtInput_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bwtResult_textBox = new System.Windows.Forms.TextBox();
            this.mtfResult_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtfInput_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bwtCode_button = new System.Windows.Forms.Button();
            this.mtfCode_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "BWT";
            // 
            // bwtInput_textBox
            // 
            this.bwtInput_textBox.Location = new System.Drawing.Point(18, 105);
            this.bwtInput_textBox.Name = "bwtInput_textBox";
            this.bwtInput_textBox.Size = new System.Drawing.Size(904, 41);
            this.bwtInput_textBox.TabIndex = 2;
            this.bwtInput_textBox.Text = "СПАСАПНРЕКККРОШГРЕЕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Текст для кодирования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат:";
            // 
            // bwtResult_textBox
            // 
            this.bwtResult_textBox.Location = new System.Drawing.Point(18, 193);
            this.bwtResult_textBox.Name = "bwtResult_textBox";
            this.bwtResult_textBox.ReadOnly = true;
            this.bwtResult_textBox.Size = new System.Drawing.Size(904, 41);
            this.bwtResult_textBox.TabIndex = 8;
            // 
            // mtfResult_textBox
            // 
            this.mtfResult_textBox.Location = new System.Drawing.Point(18, 470);
            this.mtfResult_textBox.Name = "mtfResult_textBox";
            this.mtfResult_textBox.ReadOnly = true;
            this.mtfResult_textBox.Size = new System.Drawing.Size(904, 41);
            this.mtfResult_textBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Результат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Текст для кодирования:";
            // 
            // mtfInput_textBox
            // 
            this.mtfInput_textBox.Location = new System.Drawing.Point(18, 382);
            this.mtfInput_textBox.Name = "mtfInput_textBox";
            this.mtfInput_textBox.Size = new System.Drawing.Size(904, 41);
            this.mtfInput_textBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 44);
            this.label6.TabIndex = 9;
            this.label6.Text = "MTF";
            // 
            // bwtCode_button
            // 
            this.bwtCode_button.AutoSize = true;
            this.bwtCode_button.Location = new System.Drawing.Point(364, 250);
            this.bwtCode_button.Name = "bwtCode_button";
            this.bwtCode_button.Size = new System.Drawing.Size(189, 44);
            this.bwtCode_button.TabIndex = 14;
            this.bwtCode_button.Text = "Кодировать!";
            this.bwtCode_button.UseVisualStyleBackColor = true;
            this.bwtCode_button.Click += new System.EventHandler(this.bwtCode_button_Click);
            // 
            // mtfCode_button
            // 
            this.mtfCode_button.AutoSize = true;
            this.mtfCode_button.Location = new System.Drawing.Point(364, 527);
            this.mtfCode_button.Name = "mtfCode_button";
            this.mtfCode_button.Size = new System.Drawing.Size(189, 44);
            this.mtfCode_button.TabIndex = 15;
            this.mtfCode_button.Text = "Кодировать!";
            this.mtfCode_button.UseVisualStyleBackColor = true;
            this.mtfCode_button.Click += new System.EventHandler(this.mtfCode_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 583);
            this.Controls.Add(this.mtfCode_button);
            this.Controls.Add(this.bwtCode_button);
            this.Controls.Add(this.mtfResult_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtfInput_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bwtResult_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bwtInput_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "йьй";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bwtInput_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bwtResult_textBox;
        private System.Windows.Forms.TextBox mtfResult_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mtfInput_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bwtCode_button;
        private System.Windows.Forms.Button mtfCode_button;
    }
}