namespace Lab5
{
    partial class Task1
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
            tbFromMail = new TextBox();
            tbPassword = new TextBox();
            tbToMail = new TextBox();
            tbSubject = new TextBox();
            rtbBody = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_SEND = new Button();
            SuspendLayout();
            // 
            // tbFromMail
            // 
            tbFromMail.Location = new Point(192, 39);
            tbFromMail.Margin = new Padding(3, 2, 3, 2);
            tbFromMail.Name = "tbFromMail";
            tbFromMail.Size = new Size(196, 23);
            tbFromMail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(480, 39);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(187, 23);
            tbPassword.TabIndex = 1;
            // 
            // tbToMail
            // 
            tbToMail.Location = new Point(192, 101);
            tbToMail.Margin = new Padding(3, 2, 3, 2);
            tbToMail.Name = "tbToMail";
            tbToMail.Size = new Size(196, 23);
            tbToMail.TabIndex = 2;
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(146, 143);
            tbSubject.Margin = new Padding(3, 2, 3, 2);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(521, 23);
            tbSubject.TabIndex = 3;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(146, 180);
            rtbBody.Margin = new Padding(3, 2, 3, 2);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(521, 157);
            rtbBody.TabIndex = 4;
            rtbBody.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 44);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 44);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 106);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 7;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 146);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 180);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Body:";
            // 
            // btn_SEND
            // 
            btn_SEND.Location = new Point(27, 62);
            btn_SEND.Margin = new Padding(3, 2, 3, 2);
            btn_SEND.Name = "btn_SEND";
            btn_SEND.Size = new Size(82, 22);
            btn_SEND.TabIndex = 10;
            btn_SEND.Text = "SEND";
            btn_SEND.UseVisualStyleBackColor = true;
            btn_SEND.Click += btn_SEND_Click;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 430);
            Controls.Add(btn_SEND);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbBody);
            Controls.Add(tbSubject);
            Controls.Add(tbToMail);
            Controls.Add(tbPassword);
            Controls.Add(tbFromMail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Task1";
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFromMail;
        private TextBox tbPassword;
        private TextBox tbToMail;
        private TextBox tbSubject;
        private RichTextBox rtbBody;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_SEND;
    }
}