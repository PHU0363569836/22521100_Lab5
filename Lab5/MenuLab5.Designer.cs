namespace Lab5
{
    partial class MenuLab5
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
            btn_Task2 = new Button();
            btn_Task1 = new Button();
            btn_Task3 = new Button();
            SuspendLayout();
            // 
            // btn_Task2
            // 
            btn_Task2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Task2.Location = new Point(343, 62);
            btn_Task2.Margin = new Padding(3, 2, 3, 2);
            btn_Task2.Name = "btn_Task2";
            btn_Task2.Size = new Size(82, 22);
            btn_Task2.TabIndex = 0;
            btn_Task2.Text = "Task2";
            btn_Task2.UseVisualStyleBackColor = true;
            btn_Task2.Click += btn_Task2_Click;
            // 
            // btn_Task1
            // 
            btn_Task1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Task1.Location = new Point(136, 62);
            btn_Task1.Margin = new Padding(3, 2, 3, 2);
            btn_Task1.Name = "btn_Task1";
            btn_Task1.Size = new Size(82, 22);
            btn_Task1.TabIndex = 1;
            btn_Task1.Text = "Task1";
            btn_Task1.UseVisualStyleBackColor = true;
            btn_Task1.Click += btn_Task1_Click;
            // 
            // btn_Task3
            // 
            btn_Task3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Task3.Location = new Point(136, 141);
            btn_Task3.Margin = new Padding(3, 2, 3, 2);
            btn_Task3.Name = "btn_Task3";
            btn_Task3.Size = new Size(82, 22);
            btn_Task3.TabIndex = 2;
            btn_Task3.Text = "Task3";
            btn_Task3.UseVisualStyleBackColor = true;
            btn_Task3.Click += btn_Task3_Click;
            // 
            // MenuLab5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 294);
            Controls.Add(btn_Task3);
            Controls.Add(btn_Task1);
            Controls.Add(btn_Task2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuLab5";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Task2;
        private Button btn_Task1;
        private Button btn_Task3;
    }
}
