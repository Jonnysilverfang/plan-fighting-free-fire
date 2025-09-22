using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Placeholder Username
            textBoxUser.Text = "Tên đăng nhập";
            textBoxUser.ForeColor = Color.Gray;

            // Placeholder Password
            textBoxPass.Text = "Mật khẩu";
            textBoxPass.ForeColor = Color.Gray;
            textBoxPass.UseSystemPasswordChar = false;

            // Sự kiện user
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

            // Sự kiện password
            textBoxPass.Enter += (s, ev) =>
            {
                if (textBoxPass.Text == "Mật khẩu")
                {
                    textBoxPass.Text = "";
                    textBoxPass.ForeColor = Color.Black;
                    textBoxPass.UseSystemPasswordChar = !checkBoxShow.Checked;
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

            // CheckBox hiển thị mật khẩu
            checkBoxShow.CheckedChanged += (s, ev) =>
            {
                if (textBoxPass.Text != "Mật khẩu")
                {
                    textBoxPass.UseSystemPasswordChar = !checkBoxShow.Checked;
                }
            };
        }

        // Đăng nhập
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text.Trim();
            string pass = textBoxPass.Text.Trim();

            if (user == "Tên đăng nhập" || pass == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user == AccountData.Username && pass == AccountData.Password)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở Form3 sau khi login thành công
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Mở form đăng ký
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form2 dk = new Form2();
            dk.ShowDialog();

            if (!string.IsNullOrEmpty(AccountData.Username) && !string.IsNullOrEmpty(AccountData.Password))
            {
                MessageBox.Show("Đăng ký thành công! Hãy đăng nhập bằng tài khoản mới.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
