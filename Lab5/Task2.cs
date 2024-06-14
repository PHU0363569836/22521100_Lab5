using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit.Net;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using Org.BouncyCastle.Bcpg;
using MailKit.Net.Imap;

namespace Lab5
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "imap.gmail.com";
            int port = 993;
            string username = tb_username.Text;
            string password = tb_password.Text;
            int limit = 10;

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect(server, port, true); // IMAP host, port, use SSL.
                    client.Authenticate(username, password); // Gmail account, app password.

                    //Tạo một biến inbox và gán nó với thuộc tính Inbox của đối tượng client
                    //thuộc tính ibox trả về đối tượng imailfolder đại diện cho hộp thư đến
                    var inbox = client.Inbox;
                    //mở hộp thư đến tỏng chế độ chỉ đọc 
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    //thuộc tính cout trả về số lượng phần tử có trong ibox
                    int messageCount = inbox.Count;
                    int recentMessageCount = 0;

                    // Xóa các mục trước đó trong ListView
                    listView1.Items.Clear();

                    // Lặp lại từ các email gần đây nhất
                    for (int i = messageCount - 1; i >= 0 && recentMessageCount < limit; i--)
                    {
                        var message = inbox.GetMessage(i);

                        //Xuất chủ đề của từng email ra bảng điều khiển
                        Console.WriteLine($"Email {i}: {message.Subject}");

                        // DisplayHiển thị thông tin email trong ListView: message.Subject, message.From, message.Date
                        var listViewItem = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });

                        //Đảm bảo cập nhật này được thực hiện trên chuỗi giao diện người dùng
                        listView1.Invoke(new Action(() => listView1.Items.Add(listViewItem)));
                        recentMessageCount++;
                    }

                    //Cập nhật nhãn trên chuỗi giao diện người dùng
                    labelTotalEmails.Invoke(new Action(() => labelTotalEmails.Text = $"{messageCount}"));
                    labelRecentEmails.Invoke(new Action(() => labelRecentEmails.Text = $"{recentMessageCount}"));

                    //Tổng số đầu ra và số lượng tin nhắn gần đây
                    Console.WriteLine($"Total Emails: {messageCount}");
                    Console.WriteLine($"Recent Emails with specific subject: {recentMessageCount}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Xuất thông báo ngoại lệ ra bảng điều khiển
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

    }
}

