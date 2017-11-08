namespace Codewars_RomanNumeralsDecoder
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(52, 42);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(385, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(52, 98);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(385, 20);
            this.textBox_output.TabIndex = 0;
            // 
            // button_Decode
            // 
            this.button_Decode.Location = new System.Drawing.Point(479, 70);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(75, 23);
            this.button_Decode.TabIndex = 1;
            this.button_Decode.Text = "Decode";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.button_Decode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 525);
            this.Controls.Add(this.button_Decode);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_Decode;
    }
}

