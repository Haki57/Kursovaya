namespace FunctionGeneration
{
    partial class HypothesisTestingForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.hypTestingButton = new System.Windows.Forms.Button();
            this.verdictTextBox = new System.Windows.Forms.RichTextBox();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.makeNewFileButton = new System.Windows.Forms.Button();
            this.Gfunction = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hypTestingButton
            // 
            this.hypTestingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hypTestingButton.Location = new System.Drawing.Point(343, 97);
            this.hypTestingButton.Name = "hypTestingButton";
            this.hypTestingButton.Size = new System.Drawing.Size(358, 173);
            this.hypTestingButton.TabIndex = 0;
            this.hypTestingButton.Text = "ВЫБЕРИТЕ ФАЙЛ ДЛЯ ПРОВЕРКИ ГИПОТЕЗЫ";
            this.hypTestingButton.UseVisualStyleBackColor = false;
            this.hypTestingButton.Click += new System.EventHandler(this.hypTestingButton_Click);
            // 
            // verdictTextBox
            // 
            this.verdictTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.verdictTextBox.Location = new System.Drawing.Point(12, 276);
            this.verdictTextBox.Name = "verdictTextBox";
            this.verdictTextBox.Size = new System.Drawing.Size(689, 295);
            this.verdictTextBox.TabIndex = 1;
            this.verdictTextBox.Text = "";
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.Red;
            this.backToMenuButton.Location = new System.Drawing.Point(4, 4);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(182, 90);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "НАЗАД";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // makeNewFileButton
            // 
            this.makeNewFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.makeNewFileButton.Location = new System.Drawing.Point(12, 97);
            this.makeNewFileButton.Name = "makeNewFileButton";
            this.makeNewFileButton.Size = new System.Drawing.Size(325, 173);
            this.makeNewFileButton.TabIndex = 3;
            this.makeNewFileButton.Text = "СОЗДАТЬ НОВЫЙ ФАЙЛ";
            this.makeNewFileButton.UseVisualStyleBackColor = false;
            this.makeNewFileButton.Click += new System.EventHandler(this.makeNewFileButton_Click);
            // 
            // Gfunction
            // 
            this.Gfunction.AutoSize = true;
            this.Gfunction.BackColor = System.Drawing.Color.Fuchsia;
            this.Gfunction.Location = new System.Drawing.Point(783, 234);
            this.Gfunction.Name = "Gfunction";
            this.Gfunction.Size = new System.Drawing.Size(447, 36);
            this.Gfunction.TabIndex = 40;
            this.Gfunction.Text = "В файле только функция G(n)";
            this.Gfunction.UseVisualStyleBackColor = false;
            // 
            // HypothesisTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1377, 805);
            this.Controls.Add(this.Gfunction);
            this.Controls.Add(this.makeNewFileButton);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.verdictTextBox);
            this.Controls.Add(this.hypTestingButton);
            this.Name = "HypothesisTestingForm";
            this.Text = "Проверка гипотезы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button hypTestingButton;
        private System.Windows.Forms.RichTextBox verdictTextBox;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Button makeNewFileButton;
        private System.Windows.Forms.CheckBox Gfunction;
    }
}