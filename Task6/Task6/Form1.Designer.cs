namespace Task6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DownButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.GenerateLevelButton = new System.Windows.Forms.Button();
            this.RunProgramButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.Window;
            this.Panel.Location = new System.Drawing.Point(-1, 1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(472, 353);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DownButton);
            this.groupBox1.Controls.Add(this.RightButton);
            this.groupBox1.Controls.Add(this.LeftButton);
            this.groupBox1.Controls.Add(this.UpButton);
            this.groupBox1.Controls.Add(this.ListBox);
            this.groupBox1.Location = new System.Drawing.Point(517, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(93, 401);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(94, 29);
            this.DownButton.TabIndex = 4;
            this.DownButton.Text = "Вниз";
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(171, 366);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(94, 29);
            this.RightButton.TabIndex = 3;
            this.RightButton.Text = "Вправо";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(22, 366);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(94, 29);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.Text = "Влево";
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(93, 326);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(94, 29);
            this.UpButton.TabIndex = 1;
            this.UpButton.Text = "Вверх";
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(17, 37);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(230, 264);
            this.ListBox.TabIndex = 0;
            // 
            // GenerateLevelButton
            // 
            this.GenerateLevelButton.Location = new System.Drawing.Point(12, 396);
            this.GenerateLevelButton.Name = "GenerateLevelButton";
            this.GenerateLevelButton.Size = new System.Drawing.Size(185, 42);
            this.GenerateLevelButton.TabIndex = 2;
            this.GenerateLevelButton.Text = "Генерировать уровень";
            this.GenerateLevelButton.UseVisualStyleBackColor = true;
            this.GenerateLevelButton.Click += new System.EventHandler(this.GenerateLevelButton_Click);
            // 
            // RunProgramButton
            // 
            this.RunProgramButton.Location = new System.Drawing.Point(286, 396);
            this.RunProgramButton.Name = "RunProgramButton";
            this.RunProgramButton.Size = new System.Drawing.Size(185, 42);
            this.RunProgramButton.TabIndex = 3;
            this.RunProgramButton.Text = "Выполнить программу";
            this.RunProgramButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunProgramButton);
            this.Controls.Add(this.GenerateLevelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel;
        private GroupBox groupBox1;
        private Button GenerateLevelButton;
        private Button RunProgramButton;
        private Button DownButton;
        private Button RightButton;
        private Button LeftButton;
        private Button UpButton;
        private ListBox ListBox;
    }
}