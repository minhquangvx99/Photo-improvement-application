namespace project1
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnopen = new System.Windows.Forms.ToolStripMenuItem();
			this.btnsave = new System.Windows.Forms.ToolStripMenuItem();
			this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
			this.btnmau = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRGBtogray = new System.Windows.Forms.ToolStripMenuItem();
			this.btnGraytoBin = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRGBtoBin = new System.Windows.Forms.ToolStripMenuItem();
			this.btnInvert = new System.Windows.Forms.ToolStripMenuItem();
			this.btnloc = new System.Windows.Forms.ToolStripMenuItem();
			this.btnloctrungvi = new System.Windows.Forms.ToolStripMenuItem();
			this.mặcĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tuỳChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.x5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dấuCộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chéoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcTuyếnTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcTrungBìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tuỳChọnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.x5ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.x5ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.dấuCộngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.đườngChéoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcKLángGiềngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnloccaithien = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btndtp = new System.Windows.Forms.ToolStripMenuItem();
			this.cảiThiệnSángTốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ctdtp = new System.Windows.Forms.ToolStripMenuItem();
			this.btnnoibien = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcThôngCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcThôngCao2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lọcThôngCao3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Opendialog = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.anhgoc = new System.Windows.Forms.PictureBox();
			this.anhmoi = new System.Windows.Forms.PictureBox();
			this.Savedialog = new System.Windows.Forms.SaveFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.anhgoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.anhmoi)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.btnmau,
            this.btnloc,
            this.btnloccaithien,
            this.btndtp,
            this.btnnoibien});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnopen,
            this.btnsave,
            this.btnExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// btnopen
			// 
			this.btnopen.Name = "btnopen";
			this.btnopen.Size = new System.Drawing.Size(120, 26);
			this.btnopen.Text = "Open";
			this.btnopen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// btnsave
			// 
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(120, 26);
			this.btnsave.Text = "Save";
			this.btnsave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// btnExit
			// 
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 26);
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnmau
			// 
			this.btnmau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRGBtogray,
            this.btnGraytoBin,
            this.btnRGBtoBin,
            this.btnInvert});
			this.btnmau.Name = "btnmau";
			this.btnmau.Size = new System.Drawing.Size(122, 24);
			this.btnmau.Text = "Chuyển hệ màu";
			this.btnmau.Click += new System.EventHandler(this.xửLýĐiểmToolStripMenuItem_Click);
			// 
			// btnRGBtogray
			// 
			this.btnRGBtogray.Name = "btnRGBtogray";
			this.btnRGBtogray.Size = new System.Drawing.Size(353, 26);
			this.btnRGBtogray.Text = "Chuyển từ RGB sang Gray";
			this.btnRGBtogray.Click += new System.EventHandler(this.rGBToToolStripMenuItem_Click);
			// 
			// btnGraytoBin
			// 
			this.btnGraytoBin.Name = "btnGraytoBin";
			this.btnGraytoBin.Size = new System.Drawing.Size(353, 26);
			this.btnGraytoBin.Text = "Chuyển từ Gray sang Bin";
			this.btnGraytoBin.Click += new System.EventHandler(this.graySangBinToolStripMenuItem_Click);
			// 
			// btnRGBtoBin
			// 
			this.btnRGBtoBin.Name = "btnRGBtoBin";
			this.btnRGBtoBin.Size = new System.Drawing.Size(353, 26);
			this.btnRGBtoBin.Text = "Chuyển từ RGB sang Bin";
			this.btnRGBtoBin.Click += new System.EventHandler(this.rGBToBinToolStripMenuItem_Click);
			// 
			// btnInvert
			// 
			this.btnInvert.Name = "btnInvert";
			this.btnInvert.Size = new System.Drawing.Size(353, 26);
			this.btnInvert.Text = "Chuyển từ RGB sang CMY hoặc ngược lại";
			this.btnInvert.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
			// 
			// btnloc
			// 
			this.btnloc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnloctrungvi,
            this.lọcTuyếnTínhToolStripMenuItem});
			this.btnloc.Name = "btnloc";
			this.btnloc.Size = new System.Drawing.Size(84, 24);
			this.btnloc.Text = "Lọc nhiễu";
			this.btnloc.Click += new System.EventHandler(this.lọcNhiễuToolStripMenuItem_Click);
			// 
			// btnloctrungvi
			// 
			this.btnloctrungvi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mặcĐịnhToolStripMenuItem,
            this.tuỳChọnToolStripMenuItem});
			this.btnloctrungvi.Name = "btnloctrungvi";
			this.btnloctrungvi.Size = new System.Drawing.Size(263, 26);
			this.btnloctrungvi.Text = "Lọc phi tuyến - Lọc trung vị";
			this.btnloctrungvi.Click += new System.EventHandler(this.lọcNhiễuBằngLọcTrungVịToolStripMenuItem_Click);
			// 
			// mặcĐịnhToolStripMenuItem
			// 
			this.mặcĐịnhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mặcĐịnhToolStripMenuItem.Image")));
			this.mặcĐịnhToolStripMenuItem.Name = "mặcĐịnhToolStripMenuItem";
			this.mặcĐịnhToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
			this.mặcĐịnhToolStripMenuItem.Text = "Mặc định - Sử dụng cửa sổ lọc 3x3";
			this.mặcĐịnhToolStripMenuItem.Click += new System.EventHandler(this.mặcĐịnhToolStripMenuItem_Click);
			// 
			// tuỳChọnToolStripMenuItem
			// 
			this.tuỳChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x5ToolStripMenuItem,
            this.x5ToolStripMenuItem1,
            this.dấuCộngToolStripMenuItem,
            this.chéoToolStripMenuItem});
			this.tuỳChọnToolStripMenuItem.Name = "tuỳChọnToolStripMenuItem";
			this.tuỳChọnToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
			this.tuỳChọnToolStripMenuItem.Text = "Tuỳ chọn";
			// 
			// x5ToolStripMenuItem
			// 
			this.x5ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("x5ToolStripMenuItem.Image")));
			this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
			this.x5ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.x5ToolStripMenuItem.Text = "1x5";
			this.x5ToolStripMenuItem.Click += new System.EventHandler(this.x5ToolStripMenuItem_Click);
			// 
			// x5ToolStripMenuItem1
			// 
			this.x5ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("x5ToolStripMenuItem1.Image")));
			this.x5ToolStripMenuItem1.Name = "x5ToolStripMenuItem1";
			this.x5ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
			this.x5ToolStripMenuItem1.Text = "3x5";
			this.x5ToolStripMenuItem1.Click += new System.EventHandler(this.x5ToolStripMenuItem1_Click);
			// 
			// dấuCộngToolStripMenuItem
			// 
			this.dấuCộngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dấuCộngToolStripMenuItem.Image")));
			this.dấuCộngToolStripMenuItem.Name = "dấuCộngToolStripMenuItem";
			this.dấuCộngToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.dấuCộngToolStripMenuItem.Text = "dấu cộng";
			this.dấuCộngToolStripMenuItem.Click += new System.EventHandler(this.dấuCộngToolStripMenuItem_Click);
			// 
			// chéoToolStripMenuItem
			// 
			this.chéoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chéoToolStripMenuItem.Image")));
			this.chéoToolStripMenuItem.Name = "chéoToolStripMenuItem";
			this.chéoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.chéoToolStripMenuItem.Text = "đường chéo";
			this.chéoToolStripMenuItem.Click += new System.EventHandler(this.chéoToolStripMenuItem_Click);
			// 
			// lọcTuyếnTínhToolStripMenuItem
			// 
			this.lọcTuyếnTínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lọcTrungBìnhToolStripMenuItem,
            this.lọcKLángGiềngToolStripMenuItem,
            this.lọcToolStripMenuItem});
			this.lọcTuyếnTínhToolStripMenuItem.Name = "lọcTuyếnTínhToolStripMenuItem";
			this.lọcTuyếnTínhToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
			this.lọcTuyếnTínhToolStripMenuItem.Text = "Lọc tuyến tính";
			this.lọcTuyếnTínhToolStripMenuItem.Click += new System.EventHandler(this.lọcTuyếnTínhToolStripMenuItem_Click);
			// 
			// lọcTrungBìnhToolStripMenuItem
			// 
			this.lọcTrungBìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem,
            this.tuỳChọnToolStripMenuItem1});
			this.lọcTrungBìnhToolStripMenuItem.Name = "lọcTrungBìnhToolStripMenuItem";
			this.lọcTrungBìnhToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.lọcTrungBìnhToolStripMenuItem.Text = "Lọc trung bình";
			this.lọcTrungBìnhToolStripMenuItem.Click += new System.EventHandler(this.lọcTrungBìnhToolStripMenuItem_Click_1);
			// 
			// mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem
			// 
			this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem.Image")));
			this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem.Name = "mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem";
			this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
			this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem.Text = "Mặc định - Sử dụng cửa sổ lọc 3x3";
			this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem.Click += new System.EventHandler(this.mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem_Click);
			// 
			// tuỳChọnToolStripMenuItem1
			// 
			this.tuỳChọnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x5ToolStripMenuItem2,
            this.x5ToolStripMenuItem3,
            this.dấuCộngToolStripMenuItem1,
            this.đườngChéoToolStripMenuItem});
			this.tuỳChọnToolStripMenuItem1.Name = "tuỳChọnToolStripMenuItem1";
			this.tuỳChọnToolStripMenuItem1.Size = new System.Drawing.Size(312, 26);
			this.tuỳChọnToolStripMenuItem1.Text = "Tuỳ chọn";
			// 
			// x5ToolStripMenuItem2
			// 
			this.x5ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("x5ToolStripMenuItem2.Image")));
			this.x5ToolStripMenuItem2.Name = "x5ToolStripMenuItem2";
			this.x5ToolStripMenuItem2.Size = new System.Drawing.Size(164, 26);
			this.x5ToolStripMenuItem2.Text = "1x5";
			this.x5ToolStripMenuItem2.Click += new System.EventHandler(this.x5ToolStripMenuItem2_Click);
			// 
			// x5ToolStripMenuItem3
			// 
			this.x5ToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("x5ToolStripMenuItem3.Image")));
			this.x5ToolStripMenuItem3.Name = "x5ToolStripMenuItem3";
			this.x5ToolStripMenuItem3.Size = new System.Drawing.Size(164, 26);
			this.x5ToolStripMenuItem3.Text = "3x5";
			this.x5ToolStripMenuItem3.Click += new System.EventHandler(this.x5ToolStripMenuItem3_Click);
			// 
			// dấuCộngToolStripMenuItem1
			// 
			this.dấuCộngToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("dấuCộngToolStripMenuItem1.Image")));
			this.dấuCộngToolStripMenuItem1.Name = "dấuCộngToolStripMenuItem1";
			this.dấuCộngToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
			this.dấuCộngToolStripMenuItem1.Text = "dấu cộng";
			this.dấuCộngToolStripMenuItem1.Click += new System.EventHandler(this.dấuCộngToolStripMenuItem1_Click);
			// 
			// đườngChéoToolStripMenuItem
			// 
			this.đườngChéoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đườngChéoToolStripMenuItem.Image")));
			this.đườngChéoToolStripMenuItem.Name = "đườngChéoToolStripMenuItem";
			this.đườngChéoToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.đườngChéoToolStripMenuItem.Text = "đường chéo";
			this.đườngChéoToolStripMenuItem.Click += new System.EventHandler(this.đườngChéoToolStripMenuItem_Click);
			// 
			// lọcKLángGiềngToolStripMenuItem
			// 
			this.lọcKLángGiềngToolStripMenuItem.Name = "lọcKLángGiềngToolStripMenuItem";
			this.lọcKLángGiềngToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.lọcKLángGiềngToolStripMenuItem.Text = "Lọc láng giềng";
			this.lọcKLángGiềngToolStripMenuItem.Click += new System.EventHandler(this.lọcKLángGiềngToolStripMenuItem_Click);
			// 
			// lọcToolStripMenuItem
			// 
			this.lọcToolStripMenuItem.Name = "lọcToolStripMenuItem";
			this.lọcToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.lọcToolStripMenuItem.Text = "Lọc Gauss";
			this.lọcToolStripMenuItem.Click += new System.EventHandler(this.lọcToolStripMenuItem_Click);
			// 
			// btnloccaithien
			// 
			this.btnloccaithien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lọcMaxToolStripMenuItem,
            this.lọcMinToolStripMenuItem});
			this.btnloccaithien.Name = "btnloccaithien";
			this.btnloccaithien.Size = new System.Drawing.Size(104, 24);
			this.btnloccaithien.Text = "Lọc cải thiện";
			this.btnloccaithien.Click += new System.EventHandler(this.lọcCảiThiệnToolStripMenuItem_Click);
			// 
			// lọcMaxToolStripMenuItem
			// 
			this.lọcMaxToolStripMenuItem.Name = "lọcMaxToolStripMenuItem";
			this.lọcMaxToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.lọcMaxToolStripMenuItem.Text = "Lọc max (Lọc dãn)";
			this.lọcMaxToolStripMenuItem.Click += new System.EventHandler(this.lọcMaxToolStripMenuItem_Click);
			// 
			// lọcMinToolStripMenuItem
			// 
			this.lọcMinToolStripMenuItem.Name = "lọcMinToolStripMenuItem";
			this.lọcMinToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.lọcMinToolStripMenuItem.Text = "Lọc min (Lọc co)";
			this.lọcMinToolStripMenuItem.Click += new System.EventHandler(this.lọcMinToolStripMenuItem_Click);
			// 
			// btndtp
			// 
			this.btndtp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cảiThiệnSángTốiToolStripMenuItem,
            this.ctdtp});
			this.btndtp.Name = "btndtp";
			this.btndtp.Size = new System.Drawing.Size(182, 24);
			this.btndtp.Text = "Cải thiện độ tương phản";
			this.btndtp.Click += new System.EventHandler(this.btndtp_Click);
			// 
			// cảiThiệnSángTốiToolStripMenuItem
			// 
			this.cảiThiệnSángTốiToolStripMenuItem.Name = "cảiThiệnSángTốiToolStripMenuItem";
			this.cảiThiệnSángTốiToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.cảiThiệnSángTốiToolStripMenuItem.Text = "Cải thiện sáng tối";
			this.cảiThiệnSángTốiToolStripMenuItem.Click += new System.EventHandler(this.cảiThiệnSángTốiToolStripMenuItem_Click);
			// 
			// ctdtp
			// 
			this.ctdtp.Name = "ctdtp";
			this.ctdtp.Size = new System.Drawing.Size(245, 26);
			this.ctdtp.Text = "Cải thiện độ tương phản";
			this.ctdtp.Click += new System.EventHandler(this.ctdtpToolStripMenuItem_Click);
			// 
			// btnnoibien
			// 
			this.btnnoibien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lọcThôngCaoToolStripMenuItem,
            this.lọcThôngCao2ToolStripMenuItem,
            this.lọcThôngCao3ToolStripMenuItem});
			this.btnnoibien.Name = "btnnoibien";
			this.btnnoibien.Size = new System.Drawing.Size(107, 24);
			this.btnnoibien.Text = "Làm nổi biên";
			this.btnnoibien.Click += new System.EventHandler(this.làmNổiBiênToolStripMenuItem_Click);
			// 
			// lọcThôngCaoToolStripMenuItem
			// 
			this.lọcThôngCaoToolStripMenuItem.Name = "lọcThôngCaoToolStripMenuItem";
			this.lọcThôngCaoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.lọcThôngCaoToolStripMenuItem.Text = "Lọc thông cao 1";
			this.lọcThôngCaoToolStripMenuItem.Click += new System.EventHandler(this.lọcThôngCaoToolStripMenuItem_Click);
			// 
			// lọcThôngCao2ToolStripMenuItem
			// 
			this.lọcThôngCao2ToolStripMenuItem.Name = "lọcThôngCao2ToolStripMenuItem";
			this.lọcThôngCao2ToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.lọcThôngCao2ToolStripMenuItem.Text = "Lọc thông cao 2";
			this.lọcThôngCao2ToolStripMenuItem.Click += new System.EventHandler(this.lọcThôngCao2ToolStripMenuItem_Click);
			// 
			// lọcThôngCao3ToolStripMenuItem
			// 
			this.lọcThôngCao3ToolStripMenuItem.Name = "lọcThôngCao3ToolStripMenuItem";
			this.lọcThôngCao3ToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
			this.lọcThôngCao3ToolStripMenuItem.Text = "Lọc thông cao 3";
			this.lọcThôngCao3ToolStripMenuItem.Click += new System.EventHandler(this.lọcThôngCao3ToolStripMenuItem_Click);
			// 
			// Opendialog
			// 
			this.Opendialog.Filter = "Tất cả các file (*.*)|*.*|(*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.gif)|*.gif" +
    "|(*.tiff)|*.tiff";
			this.Opendialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Opendialog_FileOk);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.anhgoc, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.anhmoi, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// anhgoc
			// 
			this.anhgoc.BackColor = System.Drawing.Color.White;
			this.anhgoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.anhgoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.anhgoc.Location = new System.Drawing.Point(3, 3);
			this.anhgoc.Name = "anhgoc";
			this.anhgoc.Size = new System.Drawing.Size(394, 416);
			this.anhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.anhgoc.TabIndex = 0;
			this.anhgoc.TabStop = false;
			this.anhgoc.Click += new System.EventHandler(this.anhgoc_Click);
			// 
			// anhmoi
			// 
			this.anhmoi.BackColor = System.Drawing.Color.White;
			this.anhmoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.anhmoi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.anhmoi.Location = new System.Drawing.Point(403, 3);
			this.anhmoi.Name = "anhmoi";
			this.anhmoi.Size = new System.Drawing.Size(394, 416);
			this.anhmoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.anhmoi.TabIndex = 0;
			this.anhmoi.TabStop = false;
			this.anhmoi.Click += new System.EventHandler(this.anhmoi_Click);
			// 
			// Savedialog
			// 
			this.Savedialog.Filter = "Tất cả các file (*.*)|*.*|(*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.gif)|*.gif" +
    "|(*.tiff)|*.tiff";
			this.Savedialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Savedialog_FileOk);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(96, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 17);
			this.label2.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(241, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 17);
			this.label4.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(301, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 17);
			this.label5.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.Location = new System.Drawing.Point(359, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 17);
			this.label7.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(179, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 5;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(21, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm cải thiện ảnh";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.anhgoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.anhmoi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.OpenFileDialog Opendialog;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox anhmoi;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnopen;
		private System.Windows.Forms.ToolStripMenuItem btnsave;
		private System.Windows.Forms.ToolStripMenuItem btnmau;
		private System.Windows.Forms.ToolStripMenuItem btnRGBtogray;
		private System.Windows.Forms.ToolStripMenuItem btnRGBtoBin;
		private System.Windows.Forms.ToolStripMenuItem btnInvert;
		private System.Windows.Forms.SaveFileDialog Savedialog;
		private System.Windows.Forms.ToolStripMenuItem btnExit;
		private System.Windows.Forms.ToolStripMenuItem btnloc;
		private System.Windows.Forms.ToolStripMenuItem btnloctrungvi;
		private System.Windows.Forms.ToolStripMenuItem btndtp;
		private System.Windows.Forms.ToolStripMenuItem btnGraytoBin;
		private System.Windows.Forms.ToolStripMenuItem mặcĐịnhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tuỳChọnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem dấuCộngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chéoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btnloccaithien;
		private System.Windows.Forms.ToolStripMenuItem lọcMaxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcMinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcTuyếnTínhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcTrungBìnhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cảiThiệnSángTốiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ctdtp;
		private System.Windows.Forms.PictureBox anhgoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolStripMenuItem btnnoibien;
		private System.Windows.Forms.ToolStripMenuItem lọcThôngCaoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcThôngCao2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcThôngCao3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tuỳChọnToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem dấuCộngToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem đườngChéoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lọcKLángGiềngToolStripMenuItem;
	}
}

