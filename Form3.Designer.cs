namespace Kien
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelWelcome;
        private TextBox textBoxGold;
        private Button buttonPlay;
        private Button buttonUpgradeHP;
        private Button buttonUpgradeDamage;
        private Button buttonExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelWelcome = new Label();
            textBoxGold = new TextBox();
            buttonPlay = new Button();
            buttonUpgradeHP = new Button();
            buttonUpgradeDamage = new Button();
            buttonExit = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelWelcome.ForeColor = Color.FromArgb(0, 192, 192);
            labelWelcome.Location = new Point(160, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(171, 40);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Xin chào!";
            // 
            // textBoxGold
            // 
            textBoxGold.BackColor = Color.White;
            textBoxGold.BorderStyle = BorderStyle.None;
            textBoxGold.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBoxGold.ForeColor = Color.FromArgb(0, 192, 192);
            textBoxGold.Location = new Point(231, 159);
            textBoxGold.Name = "textBoxGold";
            textBoxGold.ReadOnly = true;
            textBoxGold.Size = new Size(100, 23);
            textBoxGold.TabIndex = 1;
            textBoxGold.TextChanged += textBoxGold_TextChanged;
            // 
            // buttonPlay
            // 
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonPlay.ForeColor = Color.FromArgb(0, 192, 192);
            buttonPlay.Location = new Point(93, 303);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(120, 40);
            buttonPlay.TabIndex = 2;
            buttonPlay.Text = "Chơi BOSS";
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonUpgradeHP
            // 
            buttonUpgradeHP.FlatStyle = FlatStyle.Flat;
            buttonUpgradeHP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonUpgradeHP.ForeColor = Color.FromArgb(0, 192, 192);
            buttonUpgradeHP.Location = new Point(279, 404);
            buttonUpgradeHP.Name = "buttonUpgradeHP";
            buttonUpgradeHP.Size = new Size(120, 40);
            buttonUpgradeHP.TabIndex = 3;
            buttonUpgradeHP.Text = "Nâng HP";
            buttonUpgradeHP.Click += buttonUpgradeHP_Click;
            // 
            // buttonUpgradeDamage
            // 
            buttonUpgradeDamage.FlatStyle = FlatStyle.Flat;
            buttonUpgradeDamage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonUpgradeDamage.ForeColor = Color.FromArgb(0, 192, 192);
            buttonUpgradeDamage.Location = new Point(93, 404);
            buttonUpgradeDamage.Name = "buttonUpgradeDamage";
            buttonUpgradeDamage.Size = new Size(120, 40);
            buttonUpgradeDamage.TabIndex = 4;
            buttonUpgradeDamage.Text = "Nâng Damage";
            buttonUpgradeDamage.Click += buttonUpgradeDamage_Click;
            // 
            // buttonExit
            // 
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonExit.ForeColor = Color.FromArgb(0, 192, 192);
            buttonExit.Location = new Point(176, 468);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(120, 40);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Thoát";
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(160, 161);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 6;
            label1.Text = "Vàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(160, 201);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 7;
            label2.Text = "HP";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(0, 192, 192);
            textBox1.Location = new Point(231, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 20);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(160, 240);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 9;
            label3.Text = "DAME";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);
            textBox2.Location = new Point(231, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 20);
            textBox2.TabIndex = 10;
            // 
            // Form3
            // 
            BackColor = Color.White;
            ClientSize = new Size(490, 541);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(textBoxGold);
            Controls.Add(buttonPlay);
            Controls.Add(buttonUpgradeHP);
            Controls.Add(buttonUpgradeDamage);
            Controls.Add(buttonExit);
            Name = "Form3";
            Text = "Menu Game";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}
