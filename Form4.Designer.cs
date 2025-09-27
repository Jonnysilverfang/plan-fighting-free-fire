namespace Kien
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox boss;
        private System.Windows.Forms.PictureBox playerBullet;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.ProgressBar bossHealthBar;
        private System.Windows.Forms.Button buttonExit;

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer survivalTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            player = new System.Windows.Forms.PictureBox();
            boss = new System.Windows.Forms.PictureBox();
            playerBullet = new System.Windows.Forms.PictureBox();
            txtScore = new System.Windows.Forms.Label();
            playerHealthBar = new System.Windows.Forms.ProgressBar();
            bossHealthBar = new System.Windows.Forms.ProgressBar();
            buttonExit = new System.Windows.Forms.Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            survivalTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBullet).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = System.Drawing.Color.Transparent;
            player.Image = (System.Drawing.Image)resources.GetObject("player.Image");
            player.Location = new System.Drawing.Point(350, 520);
            player.Name = "player";
            player.Size = new System.Drawing.Size(62, 80);
            player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // boss
            // 
            boss.BackColor = System.Drawing.Color.Transparent;
            boss.BackgroundImage = (System.Drawing.Image)resources.GetObject("boss.BackgroundImage");
            boss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            boss.Location = new System.Drawing.Point(200, 50);
            boss.Name = "boss";
            boss.Size = new System.Drawing.Size(120, 100);
            boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            boss.TabIndex = 1;
            boss.TabStop = false;
            // 
            // playerBullet
            // 
            playerBullet.BackColor = System.Drawing.Color.Yellow;
            playerBullet.Location = new System.Drawing.Point(-50, -50);
            playerBullet.Name = "playerBullet";
            playerBullet.Size = new System.Drawing.Size(7, 20);
            playerBullet.TabIndex = 2;
            playerBullet.TabStop = false;
            playerBullet.Visible = false;
            // 
            // txtScore
            // 
            txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtScore.ForeColor = System.Drawing.Color.FromArgb(0, 192, 192);
            txtScore.Location = new System.Drawing.Point(0, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new System.Drawing.Size(473, 30);
            txtScore.TabIndex = 3;
            txtScore.Text = "Gold: 0  Time: 90";
            txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            txtScore.Click += txtScore_Click;
            // 
            // playerHealthBar
            // 
            playerHealthBar.ForeColor = System.Drawing.Color.Lime;
            playerHealthBar.Location = new System.Drawing.Point(0, 597);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new System.Drawing.Size(300, 20);
            playerHealthBar.TabIndex = 4;
            // 
            // bossHealthBar
            // 
            bossHealthBar.ForeColor = System.Drawing.Color.Red;
            bossHealthBar.Location = new System.Drawing.Point(488, 12);
            bossHealthBar.Name = "bossHealthBar";
            bossHealthBar.Size = new System.Drawing.Size(300, 20);
            bossHealthBar.TabIndex = 5;
            // 
            // buttonExit
            // 
            buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            buttonExit.ForeColor = System.Drawing.Color.FromArgb(0, 192, 192);
            buttonExit.Location = new System.Drawing.Point(350, 300);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(100, 40);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Visible = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // survivalTimer
            // 
            survivalTimer.Interval = 1000;
            survivalTimer.Tick += survivalTimer_Tick;
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(buttonExit);
            this.Controls.Add(bossHealthBar);
            this.Controls.Add(playerHealthBar);
            this.Controls.Add(txtScore);
            this.Controls.Add(playerBullet);
            this.Controls.Add(boss);
            this.Controls.Add(player);
            this.KeyPreview = true;
            this.Name = "Form4";
            this.Text = "Boss Shooter Game";
            this.Load += Form4_Load;
            this.KeyDown += keyisdown;
            this.KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)boss).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBullet).EndInit();
            this.ResumeLayout(false);
        }
    }
}

