namespace Kien
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelWelcome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcomeB
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(50, 50);
            this.labelWelcome.Text = "Xin chào!";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.labelWelcome);
            this.Text = "Trang chính";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
