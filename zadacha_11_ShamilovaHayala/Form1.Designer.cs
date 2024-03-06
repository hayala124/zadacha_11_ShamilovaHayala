namespace zadacha_11_ShamilovaHayala
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
            this.OutputPrintButton = new System.Windows.Forms.Button();
            this.OutputToTextFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputPrintButton
            // 
            this.OutputPrintButton.BackColor = System.Drawing.Color.Thistle;
            this.OutputPrintButton.FlatAppearance.BorderSize = 0;
            this.OutputPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputPrintButton.Location = new System.Drawing.Point(42, 567);
            this.OutputPrintButton.Name = "OutputPrintButton";
            this.OutputPrintButton.Size = new System.Drawing.Size(228, 45);
            this.OutputPrintButton.TabIndex = 0;
            this.OutputPrintButton.Text = "Вывести на ПЕЧАТЬ";
            this.OutputPrintButton.UseVisualStyleBackColor = false;
            this.OutputPrintButton.Click += new System.EventHandler(this.OutputPrintButton_Click);
            // 
            // OutputToTextFileButton
            // 
            this.OutputToTextFileButton.BackColor = System.Drawing.Color.Thistle;
            this.OutputToTextFileButton.FlatAppearance.BorderSize = 0;
            this.OutputToTextFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputToTextFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputToTextFileButton.Location = new System.Drawing.Point(311, 567);
            this.OutputToTextFileButton.Name = "OutputToTextFileButton";
            this.OutputToTextFileButton.Size = new System.Drawing.Size(228, 45);
            this.OutputToTextFileButton.TabIndex = 0;
            this.OutputToTextFileButton.Text = "Вывести в ТЕКСТОВЫЙ ФАЙЛ";
            this.OutputToTextFileButton.UseVisualStyleBackColor = false;
            this.OutputToTextFileButton.Click += new System.EventHandler(this.OutputToTextFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 628);
            this.Controls.Add(this.OutputToTextFileButton);
            this.Controls.Add(this.OutputPrintButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Судоку";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OutputPrintButton;
        private System.Windows.Forms.Button OutputToTextFileButton;
    }
}

