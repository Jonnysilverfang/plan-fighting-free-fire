using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kien
{
    public partial class Form4 : Form
    {
        private bool goLeft, goRight, shooting;
        private int playerSpeed = 8;
        private int bulletSpeed = 20;
        private int bossSpeed = 5;
        private int bossAttackTimer = 0;
        private int survivalTime = 90;

        private Random rnd = new Random();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Cài máu cho player và boss
            playerHealthBar.Maximum =  AccountData.UpgradeHP;
            playerHealthBar.Value = playerHealthBar.Maximum;
            bossHealthBar.Maximum = 1000;
            bossHealthBar.Value = 1000;

            // Reset vàng + thời gian
            survivalTime = 90;
            txtScore.Text = $"Gold: {AccountData.Gold}  Time: {survivalTime}";

            // Bắt đầu game
            gameTimer.Start();
            survivalTimer.Start();
        }

        // Game loop
        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = $"Gold: {AccountData.Gold}  Time: {survivalTime}";

            // Player movement
            if (goLeft && player.Left > 0) player.Left -= playerSpeed;
            if (goRight && player.Right < this.ClientSize.Width) player.Left += playerSpeed;

            // Boss di chuyển qua lại
            boss.Left += bossSpeed;
            if (boss.Left < 0 || boss.Right > this.ClientSize.Width)
            {
                bossSpeed = -bossSpeed;
            }

            // Boss bắn đạn định kỳ
            bossAttackTimer++;
            if (bossAttackTimer > 50) // mỗi 50 tick bắn 1 viên
            {
                bossAttackTimer = 0;
                ShootBossBullet();
            }

            // Xử lý tất cả các object trên form
            foreach (Control x in this.Controls)
            {
                // Player bullet
                if (x is PictureBox && (string)x.Tag == "playerBullet")
                {
                    x.Top -= bulletSpeed;

                    if (x.Top < 0)
                    {
                        this.Controls.Remove(x);
                        x.Dispose();
                    }

                    if (x.Bounds.IntersectsWith(boss.Bounds))
                    {
                        bossHealthBar.Value = Math.Max(0, bossHealthBar.Value - (10 + AccountData.UpgradeDamage));
                        this.Controls.Remove(x);
                        x.Dispose();

                        if (bossHealthBar.Value == 0)
                        {
                            EndGame(true);
                        }
                    }
                }

                // Boss bullet
                if (x is PictureBox && (string)x.Tag == "bossBullet")
                {
                    x.Top += 10;

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        playerHealthBar.Value = Math.Max(0, playerHealthBar.Value - 10);
                        this.Controls.Remove(x);
                        x.Dispose();

                        if (playerHealthBar.Value == 0)
                        {
                            EndGame(false);
                        }
                    }

                    if (x.Top > this.ClientSize.Height)
                    {
                        this.Controls.Remove(x);
                        x.Dispose();
                    }
                }
            }
        }

        // Boss bắn đạn
        private void ShootBossBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Red;
            bullet.Size = new Size(8, 20);
            bullet.Tag = "bossBullet";
            bullet.Left = boss.Left + boss.Width / 2 - bullet.Width / 2;
            bullet.Top = boss.Bottom;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        // Player bắn đạn
        private void ShootPlayerBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Yellow;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "playerBullet";
            bullet.Left = player.Left + player.Width / 2 - bullet.Width / 2;
            bullet.Top = player.Top - bullet.Height;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        // Thời gian sống sót
        private void survivalTimer_Tick(object sender, EventArgs e)
        {
            survivalTime--;
            if (survivalTime <= 0)
            {
                EndGame(true); // Thắng do sống sót
            }
        }

        // End game
        private void EndGame(bool win)
        {
            gameTimer.Stop();
            survivalTimer.Stop();

            if (win)
            {
                AccountData.Gold += 20; // thưởng
            }
            else
            {
                AccountData.Gold += 5; // thua vẫn có chút vàng
            }

            Database.UpdateAccountData();
            buttonExit.Visible = true;
        }

        // Bấm nút exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Database.UpdateAccountData();
            Form3 menu = new Form3();
            menu.Show();
            this.Close();
        }

        // Key down
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Space && !shooting)
            {
                shooting = true;
                ShootPlayerBullet();
            }
        }

        // Key up
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Space) shooting = false;
        }

        private void txtScore_Click(object sender, EventArgs e) { }
    }
}
