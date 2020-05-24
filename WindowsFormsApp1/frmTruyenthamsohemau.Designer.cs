namespace project1
{
	partial class frmTruyenthamsohemau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTruyenthamsohemau));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.bạnCầnNhập1SốThựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(343, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(278, 22);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bạnCầnNhập1SốThựcToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(461, 28);
			this.menuStrip2.TabIndex = 6;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// bạnCầnNhập1SốThựcToolStripMenuItem
			// 
			this.bạnCầnNhập1SốThựcToolStripMenuItem.Name = "bạnCầnNhập1SốThựcToolStripMenuItem";
			this.bạnCầnNhập1SốThựcToolStripMenuItem.Size = new System.Drawing.Size(411, 24);
			this.bạnCầnNhập1SốThựcToolStripMenuItem.Text = "Nhập ngưỡng nhị phân T( 0<=T<=255, thường lấy T =128).";
			// 
			// frmTruyenthamsohemau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(461, 76);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTruyenthamsohemau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTruyenthamsohemau";
			this.Load += new System.EventHandler(this.frmTruyenthamsohemau_Load);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem bạnCầnNhập1SốThựcToolStripMenuItem;
	}
}