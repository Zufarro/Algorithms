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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Output_label
            // 
            this.Output_label.AutoSize = true;
            this.Output_label.Location = new System.Drawing.Point(126, 258);
            this.Output_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output_label.Name = "Output_label";
            this.Output_label.Size = new System.Drawing.Size(76, 17);
            this.Output_label.TabIndex = 10;
            this.Output_label.Text = "Результат";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(298, 255);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(295, 22);
            this.tbOutput.TabIndex = 9;
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.Location = new System.Drawing.Point(126, 111);
            this.Input_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(56, 17);
            this.Input_label.TabIndex = 8;
            this.Input_label.Text = "Массив";
            this.Input_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbMethods
            // 
            this.cbMethods.FormattingEnabled = true;
            this.cbMethods.Location = new System.Drawing.Point(298, 141);
            this.cbMethods.Margin = new System.Windows.Forms.Padding(4);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(249, 24);
            this.cbMethods.TabIndex = 7;
            this.cbMethods.Text = "Алгоритм сортировки";
            this.cbMethods.SelectedIndexChanged += new System.EventHandler(this.cbMethods_SelectedIndexChanged);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(298, 111);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Name = "tbInput";
            this.tbInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInput.Size = new System.Drawing.Size(295, 22);
            this.tbInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Время выполнения (мс)";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(298, 306);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(134, 22);
            this.tbTime.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output_label);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.cbMethods);
            this.Controls.Add(this.tbInput);
            this.Name = "MainForm";
            this.Text = "Сортировка массива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Output_label;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.ComboBox cbMethods;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTime;
    }
}

