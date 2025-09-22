using Kien;
using System;
using System.Windows.Forms;

namespace Kien
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Xin chào, {AccountData.Username}!";
        }
    }
}
