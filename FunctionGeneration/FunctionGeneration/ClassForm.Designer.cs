namespace FunctionGeneration
{
    partial class ClassForm
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
            this.nLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ansButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(83, 130);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(322, 32);
            this.nLabel.TabIndex = 0;
            this.nLabel.Text = "Введите число листьев";
            // 
            // nTextBox
            // 
            this.nTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nTextBox.Location = new System.Drawing.Point(456, 130);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 38);
            this.nTextBox.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "nb";
            // 
            // ansButton
            // 
            this.ansButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ansButton.Location = new System.Drawing.Point(89, 242);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(467, 135);
            this.ansButton.TabIndex = 2;
            this.ansButton.Text = "Сохранить запросы в файл";
            this.ansButton.UseVisualStyleBackColor = false;
            this.ansButton.Click += new System.EventHandler(this.ansButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.Red;
            this.backToMenuButton.Location = new System.Drawing.Point(4, 4);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(182, 90);
            this.backToMenuButton.TabIndex = 3;
            this.backToMenuButton.Text = "НАЗАД";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.ansButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Name = "ClassForm";
            this.Text = "Генерация функций по классу деревьев";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ansButton;
        private System.Windows.Forms.Button backToMenuButton;
    }
}