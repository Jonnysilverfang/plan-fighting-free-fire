using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "Tên đăng nhập";
            textBoxUser.ForeColor = Color.Gray;

            textBoxPass.Text = "Mật khẩu";
            textBoxPass.ForeColor = Color.Gray;
            textBoxPass.UseSystemPasswordChar = false;

            textBoxUser.Enter += (s, ev) =>
            {
                if (textBoxUser.Text == "Tên đăng nhập")
                {
                    textBoxUser.Text = "";
                    textBoxUser.ForeColor = Color.Black;
                }
            };
            textBoxUser.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxUser.Text))
                {
                    textBoxUser.Text = "Tên đăng nhập";
                    textBoxUser.ForeColor = Color.Gray;
                }
            };

            textBoxPass.Enter += (s, ev) =>
            {
                if (textBoxPass.Text == "Mật khẩu")
                {
                    textBoxPass.Text = "";
                    textBoxPass.ForeColor = Color.Black;
                    textBoxPass.UseSystemPasswordChar = true;
                }
            };
            textBoxPass.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBoxPass.Text))
                {
                    textBoxPass.Text = "Mật khẩu";
                    textBoxPass.ForeColor = Color.Gray;
                    textBoxPass.UseSystemPasswordChar = false;
                }
            };
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text.Trim();
            string pass = textBoxPass.Text.Trim();

            if (user == "Tên đăng nhập" || pass == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AccountData.Username = user;
            AccountData.Password = pass;

            MessageBox.Show("Đăng ký thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
