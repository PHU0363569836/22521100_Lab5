using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Cms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Lab5
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btn_SEND_Click(object sender, EventArgs e)
        {
            string fromEmail = tbFromMail.Text;
            string password = tbPassword.Text;
            string toEmail = tbToMail.Text;

            //tạo một instance của smtpClient sử dụng máy chủ SMTP của Gmail(smtp.gmail.com)
            //và port 465 là port dành cho kết nối an toàn ssl/tls
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
            {
                //xác thực bằng cách sử dụng emailvaf mật khẩu ứng dụng 
                Credentials = new NetworkCredential(fromEmail, password),
                //bật chế độ ssl
                EnableSsl = true
            };

            //Khởi tạo một đối tượng mới của lớp MailMessage ,đại diện cho một email
            MailMessage mailMessage = new MailMessage
            {
                //thiết lập email người gửi
                From = new MailAddress(fromEmail),
                //thiết lập chủ đề email
                Subject = tbSubject.Text,
                //thiết lập nội dung
                Body = rtbBody.Text
            };
            //thiết lập thông tin người nhận
            mailMessage.To.Add(toEmail);

            try
            {
                client.Send(mailMessage);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
