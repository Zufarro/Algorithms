namespace Algorithms
{
    partial class MainForm
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
            this.Output_label = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.cbMethods = new System.Windows.Forms.ComboBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Location = new System.Drawing.Point(337, 189);
            this.Output_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(76, 17);
            this.Output_label.TabIndex = 10;
            this.Output_label.Text = "Результат";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(231, 208);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(295, 22);
            this.tbOutput.TabIndex = 9;
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.Location = new System.Drawing.Point(74, 72);
            this.Input_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(113, 17);
            this.Input_label.TabIndex = 8;
            this.Input_label.Text = "Введите массив";
            this.Input_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbMethods
            // 
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Location = new System.Drawing.Point(427, 90);
            this.cbMethods.Margin = new System.Windows.Forms.Padding(4);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(249, 24);
            this.cbMethods.TabIndex = 7;
            this.cbMethods.Text = "Выберите способ сортировки";
            this.cbMethods.SelectedIndexChanged += new System.EventHandler(this.cbMethods_SelectedIndexChanged);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(78, 91);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Name = "tbInput";
            this.tbInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInput.Size = new System.Drawing.Size(295, 22);
            this.tbInput.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.cbMethods);
            this.Controls.Add(this.tbInput);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.ComboBox cbMethods;
        private System.Windows.Forms.TextBox tbInput;
    }
}

