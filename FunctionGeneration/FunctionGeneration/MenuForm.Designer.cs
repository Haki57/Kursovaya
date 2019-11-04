namespace FunctionGeneration
{
    partial class MenuForm
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
            this.treeButton = new System.Windows.Forms.Button();
            this.systemButton = new System.Windows.Forms.Button();
            this.testingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeButton
            // 
            this.treeButton.BackColor = System.Drawing.Color.Yellow;
            this.treeButton.Location = new System.Drawing.Point(300, 100);
            this.treeButton.Name = "treeButton";
            this.treeButton.Size = new System.Drawing.Size(500, 150);
            this.treeButton.TabIndex = 0;
            this.treeButton.Text = "ГЕНЕРАЦИЯ ФУНКЦИЙ ПО ЗАДАННОМУ ДЕРЕВУ";
            this.treeButton.UseVisualStyleBackColor = false;
            this.treeButton.Click += new System.EventHandler(this.treeButton_Click);
            // 
            // systemButton
            // 
            this.systemButton.BackColor = System.Drawing.Color.Yellow;
            this.systemButton.Location = new System.Drawing.Point(300, 350);
            this.systemButton.Name = "systemButton";
            this.systemButton.Size = new System.Drawing.Size(500, 150);
            this.systemButton.TabIndex = 1;
            this.systemButton.Text = "ГЕНЕРАЦИЯ ФУНКЦИЙ ПО КЛАССУ ДЕРЕВЬЕВ";
            this.systemButton.UseVisualStyleBackColor = false;
            this.systemButton.Click += new System.EventHandler(this.systemButton_Click);
            // 
            // testingButton
            // 
            this.testingButton.BackColor = System.Drawing.Color.Yellow;
            this.testingButton.Location = new System.Drawing.Point(300, 600);
            this.testingButton.Name = "testingButton";
            this.testingButton.Size = new System.Drawing.Size(500, 150);
            this.testingButton.TabIndex = 2;
            this.testingButton.Text = "ПРОВЕРКА ГИПОТЕЗЫ ЭРИКА РОУЛАНДА";
            this.testingButton.UseVisualStyleBackColor = false;
            this.testingButton.Click += new System.EventHandler(this.testingButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1088, 912);
            this.Controls.Add(this.testingButton);
            this.Controls.Add(this.systemButton);
            this.Controls.Add(this.treeButton);
            this.MinimumSize = new System.Drawing.Size(1120, 1000);
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button treeButton;
        private System.Windows.Forms.Button systemButton;
        private System.Windows.Forms.Button testingButton;
    }
}