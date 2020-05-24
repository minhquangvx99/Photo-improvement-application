using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			xuly(false);
		}
		private void xuly(bool b)
		{
			btnsave.Enabled = btnmau.Enabled = btnloc.Enabled = btndtp.Enabled = btnloccaithien.Enabled = btnnoibien.Enabled = b;
		}
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
		private void anhgoc_Click(object sender, EventArgs e)
		{

		}
		private void anhmoi_Click(object sender, EventArgs e)
		{

		}
		private void Opendialog_FileOk(object sender, CancelEventArgs e)
		{

		}
		private void Savedialog_FileOk(object sender, CancelEventArgs e)
		{

		}
		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int h = 0;
			Opendialog.InitialDirectory = @"E:\Image";
			if (Opendialog.ShowDialog() == DialogResult.OK)
			{
				xuly(true);
				anhgoc.Image = Image.FromFile(Opendialog.FileName);
				Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
				label1.Text = "Chiều cao:";
				label2.Text = bmp.Height.ToString();
				label3.Text = "Bề rộng:";
				label4.Text = bmp.Width.ToString();
				label5.Text = "Hệ màu:";
				for (int y = 0; y < bmp.Height; y++)
				{
					for (int x = 0; x < bmp.Width; x++)
					{
						Color p = bmp.GetPixel(x, y);

						if (p.R == p.G && p.G == p.B && p.R == 0 || p.R == 255)
							h = 1;
						else if (p.R == p.G && p.G == p.B)
							h = 2;			
						else
							h = 3;
					}

				}
				if (h == 2)
					label7.Text = "ảnh xám";
				if (h == 1)
					label7.Text = "ảnh nhị phân";
				if (h == 3)
					label7.Text = "ảnh màu";
			}
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Savedialog.InitialDirectory = @"E:\Image";
			if (Savedialog.ShowDialog() == DialogResult.OK)
			{
				anhmoi.Image.Save(Savedialog.FileName);
			}
		}

		private void xửLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void rGBToToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					Color p = bmp.GetPixel(x, y);
					int t = (int)(p.R * .299 + p.G * .587 + p.B * .114);
					bmp.SetPixel(x, y, Color.FromArgb(t, t, t));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã chuyển hệ màu thành công", "Thông báo");
		}
		private void graySangBinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			frmTruyenthamsohemau frm = new frmTruyenthamsohemau();
			frm.ShowDialog();
			double T = double.Parse(frm.textBox1.Text);
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					Color p = bmp.GetPixel(x, y);
					int t = p.R;
					if (t >= T)
						t = 255;
					else
						t = 0;
					bmp.SetPixel(x, y, Color.FromArgb(t, t, t));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã chuyển hệ màu thành công", "Thông báo");
		}
		private void rGBToBinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			frmTruyenthamsohemau frm = new frmTruyenthamsohemau();
			frm.ShowDialog();
			double T = double.Parse(frm.textBox1.Text);
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					Color p = bmp.GetPixel(x, y);
					int t = (int)(p.R * .299 + p.G * .587 + p.B * .114);
					if (t >= T)
						t = 255;
					else
						t = 0;
					bmp.SetPixel(x, y, Color.FromArgb(t, t, t));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã chuyển hệ màu thành công", "Thông báo");
		}
		private void invertToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					Color c = bmp.GetPixel(x, y);
					bmp.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã chuyển hệ màu thành công", "Thông báo");
		}

		private void lọcNhiễuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void lọcNhiễuBằngLọcTrungVịToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		public static void sort(int[] a, int n)
		{
			int tam, i, j;
			for (i = 0; i < n - 1; i++)
				for (j = i + 1; j < n; j++)
					if (a[i] > a[j])
					{
						tam = a[i];
						a[i] = a[j];
						a[j] = tam;
					}
		}
		private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 1; x < bmp.Height - 1; x++)
			{
				for (int y = 1; y < bmp.Width - 1; y++)
				{
					A[0] = bmp.GetPixel(y - 1, x - 1).R;
					A[1] = bmp.GetPixel(y, x - 1).R;
					A[2] = bmp.GetPixel(y + 1, x - 1).R;
					A[3] = bmp.GetPixel(y - 1, x).R;
					A[4] = bmp.GetPixel(y, x).R;
					A[5] = bmp.GetPixel(y + 1, x).R;
					A[6] = bmp.GetPixel(y - 1, x + 1).R;
					A[7] = bmp.GetPixel(y, x + 1).R;
					A[8] = bmp.GetPixel(y + 1, x + 1).R;

					B[0] = bmp.GetPixel(y - 1, x - 1).G;
					B[1] = bmp.GetPixel(y, x - 1).G;
					B[2] = bmp.GetPixel(y + 1, x - 1).G;
					B[3] = bmp.GetPixel(y - 1, x).G;
					B[4] = bmp.GetPixel(y, x).G;
					B[5] = bmp.GetPixel(y + 1, x).G;
					B[6] = bmp.GetPixel(y - 1, x + 1).G;
					B[7] = bmp.GetPixel(y, x + 1).G;
					B[8] = bmp.GetPixel(y + 1, x + 1).G;
			
					C[0] = bmp.GetPixel(y - 1, x - 1).B;
					C[1] = bmp.GetPixel(y, x - 1).B;
					C[2] = bmp.GetPixel(y + 1, x - 1).B;
					C[3] = bmp.GetPixel(y - 1, x).B;
					C[4] = bmp.GetPixel(y, x).B;
					C[5] = bmp.GetPixel(y + 1, x).B;
					C[6] = bmp.GetPixel(y - 1, x + 1).B;
					C[7] = bmp.GetPixel(y, x + 1).B;
					C[8] = bmp.GetPixel(y + 1, x + 1).B;
					sort(A, 9);
					sort(B, 9);
					sort(C, 9);
					bmp.SetPixel(y, x, Color.FromArgb(A[4], B[4], C[4]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung vị thành công", "Thông báo");
		}
		private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[5];
			int[] B = new int[5];
			int[] C = new int[5];
			for (int x = 0; x < bmp.Height; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y - 2, x).R;
					A[1] = bmp.GetPixel(y - 1, x).R;
					A[2] = bmp.GetPixel(y, x).R;
					A[3] = bmp.GetPixel(y + 1, x).R;
					A[4] = bmp.GetPixel(y + 2, x).R;

					B[0] = bmp.GetPixel(y - 2, x).G;
					B[1] = bmp.GetPixel(y - 1, x).G;
					B[2] = bmp.GetPixel(y, x).G;
					B[3] = bmp.GetPixel(y + 1, x).G;
					B[4] = bmp.GetPixel(y + 2, x).G;

					C[0] = bmp.GetPixel(y - 2, x).B;
					C[1] = bmp.GetPixel(y - 1, x).B;
					C[2] = bmp.GetPixel(y, x).B;
					C[3] = bmp.GetPixel(y + 1, x).B;
					C[4] = bmp.GetPixel(y + 2, x).B;

					sort(A, 5);
					sort(B, 5);
					sort(C, 5);
					bmp.SetPixel(y, x, Color.FromArgb(A[2], B[2], C[2]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung vị thành công", "Thông báo");
		}
		private void x5ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[15];
			int[] B = new int[15];
			int[] C = new int[15];
			for (int x = 1; x < bmp.Height - 1; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y - 2, x - 1).R;
					A[1] = bmp.GetPixel(y - 1, x - 1).R;
					A[2] = bmp.GetPixel(y , x - 1).R;
					A[3] = bmp.GetPixel(y + 1, x - 1).R;
					A[4] = bmp.GetPixel(y + 2, x - 1).R;
					A[5] = bmp.GetPixel(y - 2, x).R;
					A[6] = bmp.GetPixel(y - 1, x).R;
					A[7] = bmp.GetPixel(y, x).R;
					A[8] = bmp.GetPixel(y + 1, x).R;
					A[9] = bmp.GetPixel(y + 2, x).R;
					A[10] = bmp.GetPixel(y - 2, x + 1).R;
					A[11] = bmp.GetPixel(y - 1, x + 1).R;
					A[12] = bmp.GetPixel(y, x + 1).R;
					A[13] = bmp.GetPixel(y + 1, x + 1).R;
					A[14] = bmp.GetPixel(y + 2, x + 1).R;

					B[0] = bmp.GetPixel(y - 2, x - 1).G;
					B[1] = bmp.GetPixel(y - 1, x - 1).G;
					B[2] = bmp.GetPixel(y, x - 1).G;
					B[3] = bmp.GetPixel(y + 1, x - 1).G;
					B[4] = bmp.GetPixel(y + 2, x - 1).G;
					B[5] = bmp.GetPixel(y - 2, x).G;
					B[6] = bmp.GetPixel(y - 1, x).G;
					B[7] = bmp.GetPixel(y, x).G;
					B[8] = bmp.GetPixel(y + 1, x).G;
					B[9] = bmp.GetPixel(y + 2, x).G;
					B[10] = bmp.GetPixel(y - 2, x + 1).G;
					B[11] = bmp.GetPixel(y - 1, x + 1).G;
					B[12] = bmp.GetPixel(y, x + 1).G;
					B[13] = bmp.GetPixel(y + 1, x + 1).G;
					B[14] = bmp.GetPixel(y + 2, x + 1).G;

					C[0] = bmp.GetPixel(y - 2, x - 1).B;
					C[1] = bmp.GetPixel(y - 1, x - 1).B;
					C[2] = bmp.GetPixel(y, x - 1).B;
					C[3] = bmp.GetPixel(y + 1, x - 1).B;
					C[4] = bmp.GetPixel(y + 2, x - 1).B;
					C[5] = bmp.GetPixel(y - 2, x).B;
					C[6] = bmp.GetPixel(y - 1, x).B;
					C[7] = bmp.GetPixel(y, x).B;
					C[8] = bmp.GetPixel(y + 1, x).B;
					C[9] = bmp.GetPixel(y + 2, x).B;
					C[10] = bmp.GetPixel(y - 2, x + 1).B;
					C[11] = bmp.GetPixel(y - 1, x + 1).B;
					C[12] = bmp.GetPixel(y, x + 1).B;
					C[13] = bmp.GetPixel(y + 1, x + 1).B;
					C[14] = bmp.GetPixel(y + 2, x + 1).B;

					sort(A, 15);
					sort(B, 15);
					sort(C, 15);
					bmp.SetPixel(y, x, Color.FromArgb(A[7], B[7], C[7]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung vị thành công", "Thông báo");
		}
		private void dấuCộngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 2; x < bmp.Height - 2; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y, x - 2).R;
					A[1] = bmp.GetPixel(y, x - 1).R;
					A[2] = bmp.GetPixel(y, x).R;
					A[3] = bmp.GetPixel(y, x + 1).R;
					A[4] = bmp.GetPixel(y, x + 2).R;
					A[5] = bmp.GetPixel(y - 1, x).R;
					A[6] = bmp.GetPixel(y - 2, x).R;
					A[7] = bmp.GetPixel(y + 1, x).R;
					A[8] = bmp.GetPixel(y + 2, x).R;

					B[0] = bmp.GetPixel(y, x - 2).G;
					B[1] = bmp.GetPixel(y, x - 1).G;
					B[2] = bmp.GetPixel(y, x).G;
					B[3] = bmp.GetPixel(y, x + 1).G;
					B[4] = bmp.GetPixel(y, x + 2).G;
					B[5] = bmp.GetPixel(y - 1, x).G;
					B[6] = bmp.GetPixel(y - 2, x).G;
					B[7] = bmp.GetPixel(y + 1, x).G;
					B[8] = bmp.GetPixel(y + 2, x).G;

					C[0] = bmp.GetPixel(y, x - 2).B;
					C[1] = bmp.GetPixel(y, x - 1).B;
					C[2] = bmp.GetPixel(y, x).B;
					C[3] = bmp.GetPixel(y, x + 1).B;
					C[4] = bmp.GetPixel(y, x + 2).B;
					C[5] = bmp.GetPixel(y - 1, x).B;
					C[6] = bmp.GetPixel(y - 2, x).B;
					C[7] = bmp.GetPixel(y + 1, x).B;
					C[8] = bmp.GetPixel(y + 2, x).B;

					sort(A, 9);
					sort(B, 9);
					sort(C, 9);
					bmp.SetPixel(y, x, Color.FromArgb(A[4], B[4], C[4]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung vị thành công", "Thông báo");
		}
		private void chéoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[5];
			int[] B = new int[5];
			int[] C = new int[5];
			for (int x = 2; x < bmp.Height - 2; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y + 2, x - 2).R;
					A[1] = bmp.GetPixel(y + 1, x - 1).R;
					A[2] = bmp.GetPixel(y, x).R;
					A[3] = bmp.GetPixel(y - 1, x + 1).R;
					A[4] = bmp.GetPixel(y - 2, x + 2).R;

					B[0] = bmp.GetPixel(y + 2, x - 2).G;
					B[1] = bmp.GetPixel(y + 1, x - 1).G;
					B[2] = bmp.GetPixel(y, x).G;
					B[3] = bmp.GetPixel(y - 1, x + 1).G;
					B[4] = bmp.GetPixel(y - 2, x + 2).G;

					C[0] = bmp.GetPixel(y + 2, x - 2).B;
					C[1] = bmp.GetPixel(y + 1, x - 1).B;
					C[2] = bmp.GetPixel(y, x).B;
					C[3] = bmp.GetPixel(y - 1, x + 1).B;
					C[4] = bmp.GetPixel(y - 2, x + 2).B;

					sort(A, 5);
					sort(B, 5);
					sort(C, 5);
					bmp.SetPixel(y, x, Color.FromArgb(A[2], B[2], C[2]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung vị thành công", "Thông báo");
		}

		private void lọcTuyếnTínhToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void lọcTrungBìnhToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

		}
		private void mặcĐịnhSửDụngMaTrậnLọc3x3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 1; x < bmp.Height - 1; x++)
			{
				for (int y = 1; y < bmp.Width - 1; y++)
				{
					A[0] = bmp.GetPixel(y - 1, x - 1).R;
					A[1] = bmp.GetPixel(y, x - 1).R;
					A[2] = bmp.GetPixel(y + 1, x - 1).R;
					A[3] = bmp.GetPixel(y - 1, x).R;
					A[4] = bmp.GetPixel(y, x).R;
					A[5] = bmp.GetPixel(y + 1, x).R;
					A[6] = bmp.GetPixel(y - 1, x + 1).R;
					A[7] = bmp.GetPixel(y, x + 1).R;
					A[8] = bmp.GetPixel(y + 1, x + 1).R;

					B[0] = bmp.GetPixel(y - 1, x - 1).G;
					B[1] = bmp.GetPixel(y, x - 1).G;
					B[2] = bmp.GetPixel(y + 1, x - 1).G;
					B[3] = bmp.GetPixel(y - 1, x).G;
					B[4] = bmp.GetPixel(y, x).G;
					B[5] = bmp.GetPixel(y + 1, x).G;
					B[6] = bmp.GetPixel(y - 1, x + 1).G;
					B[7] = bmp.GetPixel(y, x + 1).G;
					B[8] = bmp.GetPixel(y + 1, x + 1).G;

					C[0] = bmp.GetPixel(y - 1, x - 1).B;
					C[1] = bmp.GetPixel(y, x - 1).B;
					C[2] = bmp.GetPixel(y + 1, x - 1).B;
					C[3] = bmp.GetPixel(y - 1, x).B;
					C[4] = bmp.GetPixel(y, x).B;
					C[5] = bmp.GetPixel(y + 1, x).B;
					C[6] = bmp.GetPixel(y - 1, x + 1).B;
					C[7] = bmp.GetPixel(y, x + 1).B;
					C[8] = bmp.GetPixel(y + 1, x + 1).B;

					int t1 = (A[0] + A[1] + A[2] + A[3] + A[4] + A[5] + A[6] + A[7] + A[8]) / 9;
					int t2 = (B[0] + B[1] + B[2] + B[3] + B[4] + B[5] + B[6] + B[7] + B[8]) / 9;
					int t3 = (C[0] + C[1] + C[2] + C[3] + C[4] + C[5] + C[6] + C[7] + C[8]) / 9;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung bình thành công", "Thông báo");
		}
		private void x5ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[5];
			int[] B = new int[5];
			int[] C = new int[5];
			for (int x = 0; x < bmp.Height; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y - 2, x).R;
					A[1] = bmp.GetPixel(y - 1, x).R;
					A[2] = bmp.GetPixel(y, x).R;
					A[3] = bmp.GetPixel(y + 1, x).R;
					A[4] = bmp.GetPixel(y + 2, x).R;

					B[0] = bmp.GetPixel(y - 2, x).G;
					B[1] = bmp.GetPixel(y - 1, x).G;
					B[2] = bmp.GetPixel(y, x).G;
					B[3] = bmp.GetPixel(y + 1, x).G;
					B[4] = bmp.GetPixel(y + 2, x).G;

					C[0] = bmp.GetPixel(y - 2, x).B;
					C[1] = bmp.GetPixel(y - 1, x).B;
					C[2] = bmp.GetPixel(y, x).B;
					C[3] = bmp.GetPixel(y + 1, x).B;
					C[4] = bmp.GetPixel(y + 2, x).B;

					int t1 = (A[0] + A[1] + A[2] + A[3] + A[4]) / 5;
					int t2 = (B[0] + B[1] + B[2] + B[3] + B[4]) / 5;
					int t3 = (C[0] + C[1] + C[2] + C[3] + C[4]) / 5;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung bình thành công", "Thông báo");
		}
		private void x5ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[15];
			int[] B = new int[15];
			int[] C = new int[15];
			for (int x = 1; x < bmp.Height - 1; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y - 2, x - 1).R;
					A[1] = bmp.GetPixel(y - 1, x - 1).R;
					A[2] = bmp.GetPixel(y, x - 1).R;
					A[3] = bmp.GetPixel(y + 1, x - 1).R;
					A[4] = bmp.GetPixel(y + 2, x - 1).R;
					A[5] = bmp.GetPixel(y - 2, x).R;
					A[6] = bmp.GetPixel(y - 1, x).R;
					A[7] = bmp.GetPixel(y, x).R;
					A[8] = bmp.GetPixel(y + 1, x).R;
					A[9] = bmp.GetPixel(y + 2, x).R;
					A[10] = bmp.GetPixel(y - 2, x + 1).R;
					A[11] = bmp.GetPixel(y - 1, x + 1).R;
					A[12] = bmp.GetPixel(y, x + 1).R;
					A[13] = bmp.GetPixel(y + 1, x + 1).R;
					A[14] = bmp.GetPixel(y + 2, x + 1).R;

					B[0] = bmp.GetPixel(y - 2, x - 1).G;
					B[1] = bmp.GetPixel(y - 1, x - 1).G;
					B[2] = bmp.GetPixel(y, x - 1).G;
					B[3] = bmp.GetPixel(y + 1, x - 1).G;
					B[4] = bmp.GetPixel(y + 2, x - 1).G;
					B[5] = bmp.GetPixel(y - 2, x).G;
					B[6] = bmp.GetPixel(y - 1, x).G;
					B[7] = bmp.GetPixel(y, x).G;
					B[8] = bmp.GetPixel(y + 1, x).G;
					B[9] = bmp.GetPixel(y + 2, x).G;
					B[10] = bmp.GetPixel(y - 2, x + 1).G;
					B[11] = bmp.GetPixel(y - 1, x + 1).G;
					B[12] = bmp.GetPixel(y, x + 1).G;
					B[13] = bmp.GetPixel(y + 1, x + 1).G;
					B[14] = bmp.GetPixel(y + 2, x + 1).G;

					C[0] = bmp.GetPixel(y - 2, x - 1).B;
					C[1] = bmp.GetPixel(y - 1, x - 1).B;
					C[2] = bmp.GetPixel(y, x - 1).B;
					C[3] = bmp.GetPixel(y + 1, x - 1).B;
					C[4] = bmp.GetPixel(y + 2, x - 1).B;
					C[5] = bmp.GetPixel(y - 2, x).B;
					C[6] = bmp.GetPixel(y - 1, x).B;
					C[7] = bmp.GetPixel(y, x).B;
					C[8] = bmp.GetPixel(y + 1, x).B;
					C[9] = bmp.GetPixel(y + 2, x).B;
					C[10] = bmp.GetPixel(y - 2, x + 1).B;
					C[11] = bmp.GetPixel(y - 1, x + 1).B;
					C[12] = bmp.GetPixel(y, x + 1).B;
					C[13] = bmp.GetPixel(y + 1, x + 1).B;
					C[14] = bmp.GetPixel(y + 2, x + 1).B;

					int t1 = (A[0] + A[1] + A[2] + A[3] + A[4] + A[5] + A[6] + A[7] + A[8] + A[9] + A[10] + A[11] + A[12] + A[13] + A[14]) / 15;
					int t2 = (B[0] + B[1] + B[2] + B[3] + B[4] + B[5] + B[6] + B[7] + B[8] + B[9] + B[10] + B[11] + B[12] + B[13] + B[14]) / 15;
					int t3 = (C[0] + C[1] + C[2] + C[3] + C[4] + C[5] + C[6] + C[7] + C[8] + C[9] + C[10] + C[11] + C[12] + C[13] + C[14]) / 15;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung bình thành công", "Thông báo");
		}
		private void dấuCộngToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 2; x < bmp.Height - 2; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y, x - 2).R;
					A[1] = bmp.GetPixel(y, x - 1).R;
					A[2] = bmp.GetPixel(y, x).R;
					A[3] = bmp.GetPixel(y, x + 1).R;
					A[4] = bmp.GetPixel(y, x + 2).R;
					A[5] = bmp.GetPixel(y - 1, x).R;
					A[6] = bmp.GetPixel(y - 2, x).R;
					A[7] = bmp.GetPixel(y + 1, x).R;
					A[8] = bmp.GetPixel(y + 2, x).R;

					B[0] = bmp.GetPixel(y, x - 2).G;
					B[1] = bmp.GetPixel(y, x - 1).G;
					B[2] = bmp.GetPixel(y, x).G;
					B[3] = bmp.GetPixel(y, x + 1).G;
					B[4] = bmp.GetPixel(y, x + 2).G;
					B[5] = bmp.GetPixel(y - 1, x).G;
					B[6] = bmp.GetPixel(y - 2, x).G;
					B[7] = bmp.GetPixel(y + 1, x).G;
					B[8] = bmp.GetPixel(y + 2, x).G;

					C[0] = bmp.GetPixel(y, x - 2).B;
					C[1] = bmp.GetPixel(y, x - 1).B;
					C[2] = bmp.GetPixel(y, x).B;
					C[3] = bmp.GetPixel(y, x + 1).B;
					C[4] = bmp.GetPixel(y, x + 2).B;
					C[5] = bmp.GetPixel(y - 1, x).B;
					C[6] = bmp.GetPixel(y - 2, x).B;
					C[7] = bmp.GetPixel(y + 1, x).B;
					C[8] = bmp.GetPixel(y + 2, x).B;

					int t1 = (A[0] + A[1] + A[2] + A[3] + A[4] + A[5] + A[6] + A[7] + A[8]) / 9;
					int t2 = (B[0] + B[1] + B[2] + B[3] + B[4] + B[5] + B[6] + B[7] + B[8]) / 9;
					int t3 = (C[0] + C[1] + C[2] + C[3] + C[4] + C[5] + C[6] + C[7] + C[8]) / 9;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung bình thành công", "Thông báo");
		}
		private void đườngChéoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[5];
			int[] B = new int[5];
			int[] C = new int[5];
			for (int x = 2; x < bmp.Height - 2; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y + 2, x - 2).R;
					A[1] = bmp.GetPixel(y + 1, x - 1).R;
					A[2] = bmp.GetPixel(y, x).R;
					A[3] = bmp.GetPixel(y - 1, x + 1).R;
					A[4] = bmp.GetPixel(y - 2, x + 2).R;

					B[0] = bmp.GetPixel(y + 2, x - 2).G;
					B[1] = bmp.GetPixel(y + 1, x - 1).G;
					B[2] = bmp.GetPixel(y, x).G;
					B[3] = bmp.GetPixel(y - 1, x + 1).G;
					B[4] = bmp.GetPixel(y - 2, x + 2).G;

					C[0] = bmp.GetPixel(y + 2, x - 2).B;
					C[1] = bmp.GetPixel(y + 1, x - 1).B;
					C[2] = bmp.GetPixel(y, x).B;
					C[3] = bmp.GetPixel(y - 1, x + 1).B;
					C[4] = bmp.GetPixel(y - 2, x + 2).B;

					int t1 = (A[0] + A[1] + A[2] + A[3] + A[4]) / 5;
					int t2 = (B[0] + B[1] + B[2] + B[3] + B[4]) / 5;
					int t3 = (C[0] + C[1] + C[2] + C[3] + C[4]) / 5;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc trung bình thành công", "Thông báo");
		}
		private void lọcKLángGiềngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 1; x < bmp.Height - 1; x++)
			{
				for (int y = 1; y < bmp.Width - 1; y++)
				{
					A[0] = bmp.GetPixel(y - 1, x - 1).R;
					A[1] = bmp.GetPixel(y, x - 1).R;
					A[2] = bmp.GetPixel(y + 1, x - 1).R;
					A[3] = bmp.GetPixel(y - 1, x).R;
					A[4] = bmp.GetPixel(y, x).R;
					A[5] = bmp.GetPixel(y + 1, x).R;
					A[6] = bmp.GetPixel(y - 1, x + 1).R;
					A[7] = bmp.GetPixel(y, x + 1).R;
					A[8] = bmp.GetPixel(y + 1, x + 1).R;

					B[0] = bmp.GetPixel(y - 1, x - 1).G;
					B[1] = bmp.GetPixel(y, x - 1).G;
					B[2] = bmp.GetPixel(y + 1, x - 1).G;
					B[3] = bmp.GetPixel(y - 1, x).G;
					B[4] = bmp.GetPixel(y, x).G;
					B[5] = bmp.GetPixel(y + 1, x).G;
					B[6] = bmp.GetPixel(y - 1, x + 1).G;
					B[7] = bmp.GetPixel(y, x + 1).G;
					B[8] = bmp.GetPixel(y + 1, x + 1).G;

					C[0] = bmp.GetPixel(y - 1, x - 1).B;
					C[1] = bmp.GetPixel(y, x - 1).B;
					C[2] = bmp.GetPixel(y + 1, x - 1).B;
					C[3] = bmp.GetPixel(y - 1, x).B;
					C[4] = bmp.GetPixel(y, x).B;
					C[5] = bmp.GetPixel(y + 1, x).B;
					C[6] = bmp.GetPixel(y - 1, x + 1).B;
					C[7] = bmp.GetPixel(y, x + 1).B;
					C[8] = bmp.GetPixel(y + 1, x + 1).B;

					int t1 = (A[0] + 2*A[1] + A[2] + 2*A[3] + 4 * A[4] + 2*A[5] + A[6] + 2*A[7] + A[8]) / 16;
					int t2 = (B[0] + 2*B[1] + B[2] + 2*B[3] + 4 * B[4] + 2*B[5] + B[6] + 2*B[7] + B[8]) / 16;
					int t3 = (C[0] + 2*C[1] + C[2] + 2*C[3] + 4 * C[4] + 2*C[5] + C[6] + 2*C[7] + C[8]) / 16;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc láng giềng thành công", "Thông báo");
		}
		private void lọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[25];
			int[] B = new int[25];
			int[] C = new int[25];
			for (int x = 2; x < bmp.Height - 2; x++)
			{
				for (int y = 2; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y - 2, x - 2).R;
					A[1] = bmp.GetPixel(y - 1, x - 2).R;
					A[2] = bmp.GetPixel(y, x - 2).R;
					A[3] = bmp.GetPixel(y + 1, x - 2).R;
					A[4] = bmp.GetPixel(y + 2, x - 2).R;
					A[5] = bmp.GetPixel(y - 2, x - 1).R;
					A[6] = bmp.GetPixel(y - 1, x - 1).R;
					A[7] = bmp.GetPixel(y, x - 1).R;
					A[8] = bmp.GetPixel(y + 1, x - 1).R;
					A[9] = bmp.GetPixel(y + 2, x - 1).R;
					A[10] = bmp.GetPixel(y - 2, x).R;
					A[11] = bmp.GetPixel(y - 1, x).R;
					A[12] = bmp.GetPixel(y, x).R;
					A[13] = bmp.GetPixel(y + 1, x).R;
					A[14] = bmp.GetPixel(y + 2, x).R;
					A[15] = bmp.GetPixel(y - 2, x + 1).R;
					A[16] = bmp.GetPixel(y - 1, x + 1).R;
					A[17] = bmp.GetPixel(y, x + 1).R;
					A[18] = bmp.GetPixel(y + 1, x + 1).R;
					A[19] = bmp.GetPixel(y + 2, x + 1).R;
					A[20] = bmp.GetPixel(y - 2, x + 2).R;
					A[21] = bmp.GetPixel(y - 1, x + 2).R;
					A[22] = bmp.GetPixel(y, x + 2).R;
					A[23] = bmp.GetPixel(y + 1, x + 2).R;
					A[24] = bmp.GetPixel(y + 2, x + 2).R;

					B[0] = bmp.GetPixel(y - 2, x - 2).G;
					B[1] = bmp.GetPixel(y - 1, x - 2).G;
					B[2] = bmp.GetPixel(y, x - 2).G;
					B[3] = bmp.GetPixel(y + 1, x - 2).G;
					B[4] = bmp.GetPixel(y + 2, x - 2).G;
					B[5] = bmp.GetPixel(y - 2, x - 1).G;
					B[6] = bmp.GetPixel(y - 1, x - 1).G;
					B[7] = bmp.GetPixel(y, x - 1).G;
					B[8] = bmp.GetPixel(y + 1, x - 1).G;
					B[9] = bmp.GetPixel(y + 2, x - 1).G;
					B[10] = bmp.GetPixel(y - 2, x).G;
					B[11] = bmp.GetPixel(y - 1, x).G;
					B[12] = bmp.GetPixel(y, x).G;
					B[13] = bmp.GetPixel(y + 1, x).G;
					B[14] = bmp.GetPixel(y + 2, x).G;
					B[15] = bmp.GetPixel(y - 2, x + 1).G;
					B[16] = bmp.GetPixel(y - 1, x + 1).G;
					B[17] = bmp.GetPixel(y, x + 1).G;
					B[18] = bmp.GetPixel(y + 1, x + 1).G;
					B[19] = bmp.GetPixel(y + 2, x + 1).G;
					B[20] = bmp.GetPixel(y - 2, x + 2).G;
					B[21] = bmp.GetPixel(y - 1, x + 2).G;
					B[22] = bmp.GetPixel(y, x + 2).G;
					B[23] = bmp.GetPixel(y + 1, x + 2).G;
					B[24] = bmp.GetPixel(y + 2, x + 2).G;

					C[0] = bmp.GetPixel(y - 2, x - 2).B;
					C[1] = bmp.GetPixel(y - 1, x - 2).B;
					C[2] = bmp.GetPixel(y, x - 2).B;
					C[3] = bmp.GetPixel(y + 1, x - 2).B;
					C[4] = bmp.GetPixel(y + 2, x - 2).B;
					C[5] = bmp.GetPixel(y - 2, x - 1).B;
					C[6] = bmp.GetPixel(y - 1, x - 1).B;
					C[7] = bmp.GetPixel(y, x - 1).B;
					C[8] = bmp.GetPixel(y + 1, x - 1).B;
					C[9] = bmp.GetPixel(y + 2, x - 1).B;
					C[10] = bmp.GetPixel(y - 2, x).B;
					C[11] = bmp.GetPixel(y - 1, x).B;
					C[12] = bmp.GetPixel(y, x).B;
					C[13] = bmp.GetPixel(y + 1, x).B;
					C[14] = bmp.GetPixel(y + 2, x).B;
					C[15] = bmp.GetPixel(y - 2, x + 1).B;
					C[16] = bmp.GetPixel(y - 1, x + 1).B;
					C[17] = bmp.GetPixel(y, x + 1).B;
					C[18] = bmp.GetPixel(y + 1, x + 1).B;
					C[19] = bmp.GetPixel(y + 2, x + 1).B;
					C[20] = bmp.GetPixel(y - 2, x + 2).B;
					C[21] = bmp.GetPixel(y - 1, x + 2).B;
					C[22] = bmp.GetPixel(y, x + 2).B;
					C[23] = bmp.GetPixel(y + 1, x + 2).B;
					C[24] = bmp.GetPixel(y + 2, x + 2).B;

					int t1 = (A[0] + 4 * A[1] + 7 * A[2] + 4 * A[3] + A[4] + 4 * A[5] + 16 * A[6] + 26 * A[7] + 16 * A[8] + 4 * A[9] + 7 * A[10]
						+ 26 * A[11] + 41 * A[12] + 26 * A[13] + 7 * A[14] + 4 * A[15] + 16 * A[16] + 26 * A[17] + 16 * A[18] + 4 * A[19] + A[20]
						+ 4 * A[21] + 7 * A[22] + 4 * A[23] + A[24]) / 273;
					int t2 = (B[0] + 4 * B[1] + 7 * B[2] + 4 * B[3] + B[4] + 4 * B[5] + 16 * B[6] + 26 * B[7] + 16 * B[8] + 4 * B[9] + 7 * B[10]
						+ 26 * B[11] + 41 * B[12] + 26 * B[13] + 7 * B[14] + 4 * B[15] + 16 * B[16] + 26 * B[17] + 16 * B[18] + 4 * B[19] + B[20]
						+ 4 * B[21] + 7 * B[22] + 4 * B[23] + B[24]) / 273;
					int t3 = (C[0] + 4 * C[1] + 7 * C[2] + 4 * C[3] + C[4] + 4 * C[5] + 16 * C[6] + 26 * C[7] + 16 * C[8] + 4 * C[9] + 7 * C[10]
						+ 26 * C[11] + 41 * C[12] + 26 * C[13] + 7 * C[14] + 4 * C[15] + 16 * C[16] + 26 * C[17] + 16 * C[18] + 4 * C[19] + C[20]
						+ 4 * C[21] + 7 * C[22] + 4 * C[23] + C[24]) / 273;

					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc gauss thành công", "Thông báo");
		}

		private void lọcCảiThiệnToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void lọcMaxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 0; x < bmp.Height - 2; x++)
			{
				for (int y = 0; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y, x).R;
					A[1] = bmp.GetPixel(y + 1, x).R;
					A[2] = bmp.GetPixel(y + 2, x).R;
					A[3] = bmp.GetPixel(y, x + 1).R;
					A[4] = bmp.GetPixel(y + 1, x + 1).R;
					A[5] = bmp.GetPixel(y + 2, x + 1).R;
					A[6] = bmp.GetPixel(y, x + 2).R;
					A[7] = bmp.GetPixel(y + 1, x + 2).R;
					A[8] = bmp.GetPixel(y + 2, x + 2).R;

					B[0] = bmp.GetPixel(y, x).G;
					B[1] = bmp.GetPixel(y + 1, x).G;
					B[2] = bmp.GetPixel(y + 2, x).G;
					B[3] = bmp.GetPixel(y, x + 1).G;
					B[4] = bmp.GetPixel(y + 1, x + 1).G;
					B[5] = bmp.GetPixel(y + 2, x + 1).G;
					B[6] = bmp.GetPixel(y, x + 2).G;
					B[7] = bmp.GetPixel(y + 1, x + 2).G;
					B[8] = bmp.GetPixel(y + 2, x + 2).G;

					C[0] = bmp.GetPixel(y, x).B;
					C[1] = bmp.GetPixel(y + 1, x).B;
					C[2] = bmp.GetPixel(y + 2, x).B;
					C[3] = bmp.GetPixel(y, x + 1).B;
					C[4] = bmp.GetPixel(y + 1, x + 1).B;
					C[5] = bmp.GetPixel(y + 2, x + 1).B;
					C[6] = bmp.GetPixel(y, x + 2).B;
					C[7] = bmp.GetPixel(y + 1, x + 2).B;
					C[8] = bmp.GetPixel(y + 2, x + 2).B;

					sort(A, 9);
					sort(B, 9);
					sort(C, 9);
					bmp.SetPixel(y, x, Color.FromArgb(A[8], B[8], C[8]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc max thành công", "Thông báo");
		}
		private void lọcMinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 0; x < bmp.Height - 2; x++)
			{
				for (int y = 0; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y, x).R;
					A[1] = bmp.GetPixel(y + 1, x).R;
					A[2] = bmp.GetPixel(y + 2, x).R;
					A[3] = bmp.GetPixel(y, x + 1).R;
					A[4] = bmp.GetPixel(y + 1, x + 1).R;
					A[5] = bmp.GetPixel(y + 2, x + 1).R;
					A[6] = bmp.GetPixel(y, x + 2).R;
					A[7] = bmp.GetPixel(y + 1, x + 2).R;
					A[8] = bmp.GetPixel(y + 2, x + 2).R;

					B[0] = bmp.GetPixel(y, x).G;
					B[1] = bmp.GetPixel(y + 1, x).G;
					B[2] = bmp.GetPixel(y + 2, x).G;
					B[3] = bmp.GetPixel(y, x + 1).G;
					B[4] = bmp.GetPixel(y + 1, x + 1).G;
					B[5] = bmp.GetPixel(y + 2, x + 1).G;
					B[6] = bmp.GetPixel(y, x + 2).G;
					B[7] = bmp.GetPixel(y + 1, x + 2).G;
					B[8] = bmp.GetPixel(y + 2, x + 2).G;

					C[0] = bmp.GetPixel(y, x).B;
					C[1] = bmp.GetPixel(y + 1, x).B;
					C[2] = bmp.GetPixel(y + 2, x).B;
					C[3] = bmp.GetPixel(y, x + 1).B;
					C[4] = bmp.GetPixel(y + 1, x + 1).B;
					C[5] = bmp.GetPixel(y + 2, x + 1).B;
					C[6] = bmp.GetPixel(y, x + 2).B;
					C[7] = bmp.GetPixel(y + 1, x + 2).B;
					C[8] = bmp.GetPixel(y + 2, x + 2).B;

					sort(A, 9);
					sort(B, 9);
					sort(C, 9);
					bmp.SetPixel(y, x, Color.FromArgb(A[0], B[0], C[0]));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc min thành công", "Thông báo");
		}

		private void btndtp_Click(object sender, EventArgs e)
		{

		}
		private void cảiThiệnSángTốiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTruyenthamso frm = new frmTruyenthamso();
			frm.ShowDialog();
			double value = double.Parse(frm.textBox1.Text);
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			for (int y = 0; y < bmp.Height; y++)
			{
				for (int x = 0; x < bmp.Width; x++)
				{
					Color c = bmp.GetPixel(x, y);
					int t1 = (int)Math.Max(Math.Min(c.R + value, 255), 0);
					int t2 = (int)Math.Max(Math.Min(c.G + value, 255), 0);
					int t3 = (int)Math.Max(Math.Min(c.B + value, 255), 0);
					bmp.SetPixel(x, y, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã cải thiện sáng tối thành công", "Thông báo");
		}
		private void ctdtpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmtruyenthamso1 frm1 = new frmtruyenthamso1();
			frm1.ShowDialog();
			double n = double.Parse(frm1.textBox1.Text);
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			for (int x = 0; x < bmp.Height - 1; x++)
			{
				for (int y = 0; y < bmp.Width - 1; y++)
				{
					Color c = bmp.GetPixel(y, x);
					int t1 = (int)Math.Min(c.R * n, 255);
					int t2 = (int)Math.Min(c.G * n, 255);
					int t3 = (int)Math.Min(c.B * n, 255);
					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã cải thiện độ tương phản thành công", "Thông báo");
		}

		private void làmNổiBiênToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void lọcThôngCaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 0; x < bmp.Height - 2; x++)
			{
				for (int y = 0; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y, x).R;
					A[1] = bmp.GetPixel(y + 1, x).R;
					A[2] = bmp.GetPixel(y + 2, x).R;
					A[3] = bmp.GetPixel(y, x + 1).R;
					A[4] = bmp.GetPixel(y + 1, x + 1).R;
					A[5] = bmp.GetPixel(y + 2, x + 1).R;
					A[6] = bmp.GetPixel(y, x + 2).R;
					A[7] = bmp.GetPixel(y + 1, x + 2).R;
					A[8] = bmp.GetPixel(y + 2, x + 2).R;

					B[0] = bmp.GetPixel(y, x).G;
					B[1] = bmp.GetPixel(y + 1, x).G;
					B[2] = bmp.GetPixel(y + 2, x).G;
					B[3] = bmp.GetPixel(y, x + 1).G;
					B[4] = bmp.GetPixel(y + 1, x + 1).G;
					B[5] = bmp.GetPixel(y + 2, x + 1).G;
					B[6] = bmp.GetPixel(y, x + 2).G;
					B[7] = bmp.GetPixel(y + 1, x + 2).G;
					B[8] = bmp.GetPixel(y + 2, x + 2).G;

					C[0] = bmp.GetPixel(y, x).B;
					C[1] = bmp.GetPixel(y + 1, x).B;
					C[2] = bmp.GetPixel(y + 2, x).B;
					C[3] = bmp.GetPixel(y, x + 1).B;
					C[4] = bmp.GetPixel(y + 1, x + 1).B;
					C[5] = bmp.GetPixel(y + 2, x + 1).B;
					C[6] = bmp.GetPixel(y, x + 2).B;
					C[7] = bmp.GetPixel(y + 1, x + 2).B;
					C[8] = bmp.GetPixel(y + 2, x + 2).B;

					int t1 = - A[0] - A[1] - A[2] - A[3] + 9 * A[4] - A[5] - A[6] - A[7] - A[8];
					int t2 = - B[0] - B[1] - B[2] - B[3] + 9 * B[4] - B[5] - B[6] - B[7] - B[8];
					int t3 = - C[0] - C[1] - C[2] - C[3] + 9 * C[4] - C[5] - C[6] - C[7] - C[8];

					if (t1 > 255)
						t1 = 255;
					else if (t1 < 0)
						t1 = 0;
					if (t2 > 255)
						t2 = 255;
					else if (t2 < 0)
						t2 = 0;
					if (t3 > 255)
						t3 = 255;
					else if (t3 < 0)
						t3 = 0;
					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc thông cao thành công", "Thông báo");
		}
		private void lọcThôngCao2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[9];
			int[] B = new int[9];
			int[] C = new int[9];
			for (int x = 0; x < bmp.Height - 2; x++)
			{
				for (int y = 0; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y, x).R;
					A[1] = bmp.GetPixel(y + 1, x).R;
					A[2] = bmp.GetPixel(y + 2, x).R;
					A[3] = bmp.GetPixel(y, x + 1).R;
					A[4] = bmp.GetPixel(y + 1, x + 1).R;
					A[5] = bmp.GetPixel(y + 2, x + 1).R;
					A[6] = bmp.GetPixel(y, x + 2).R;
					A[7] = bmp.GetPixel(y + 1, x + 2).R;
					A[8] = bmp.GetPixel(y + 2, x + 2).R;

					B[0] = bmp.GetPixel(y, x).G;
					B[1] = bmp.GetPixel(y + 1, x).G;
					B[2] = bmp.GetPixel(y + 2, x).G;
					B[3] = bmp.GetPixel(y, x + 1).G;
					B[4] = bmp.GetPixel(y + 1, x + 1).G;
					B[5] = bmp.GetPixel(y + 2, x + 1).G;
					B[6] = bmp.GetPixel(y, x + 2).G;
					B[7] = bmp.GetPixel(y + 1, x + 2).G;
					B[8] = bmp.GetPixel(y + 2, x + 2).G;

					C[0] = bmp.GetPixel(y, x).B;
					C[1] = bmp.GetPixel(y + 1, x).B;
					C[2] = bmp.GetPixel(y + 2, x).B;
					C[3] = bmp.GetPixel(y, x + 1).B;
					C[4] = bmp.GetPixel(y + 1, x + 1).B;
					C[5] = bmp.GetPixel(y + 2, x + 1).B;
					C[6] = bmp.GetPixel(y, x + 2).B;
					C[7] = bmp.GetPixel(y + 1, x + 2).B;
					C[8] = bmp.GetPixel(y + 2, x + 2).B;

					int t1 = A[0] - 2*A[1] + A[2] - 2*A[3] + 5 * A[4] - 2*A[5] + A[6] - 2*A[7] + A[8];
					int t2 = B[0] - 2*B[1] + B[2] - 2*B[3] + 5 * B[4] - 2*B[5] + B[6] - 2*B[7] + B[8];
					int t3 = C[0] - 2*C[1] + C[2] - 2*C[3] + 5 * C[4] - 2*C[5] + C[6] - 2*C[7] + C[8];

					if (t1 > 255)
						t1 = 255;
					else if (t1 < 0)
						t1 = 0;
					if (t2 > 255)
						t2 = 255;
					else if (t2 < 0)
						t2 = 0;
					if (t3 > 255)
						t3 = 255;
					else if (t3 < 0)
						t3 = 0;
					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc thông cao thành công", "Thông báo");
		}
		private void lọcThôngCao3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
			int[] A = new int[5];
			int[] B = new int[5];
			int[] C = new int[5];
			for (int x = 0; x < bmp.Height - 2; x++)
			{
				for (int y = 0; y < bmp.Width - 2; y++)
				{
					A[0] = bmp.GetPixel(y + 1, x).R;
					A[1] = bmp.GetPixel(y, x + 1).R;
					A[2] = bmp.GetPixel(y + 1, x + 1).R;
					A[3] = bmp.GetPixel(y + 2, x + 1).R;
					A[4] = bmp.GetPixel(y + 1, x + 2).R;

					B[0] = bmp.GetPixel(y + 1, x).G;
					B[1] = bmp.GetPixel(y, x + 1).G;
					B[2] = bmp.GetPixel(y + 1, x + 1).G;
					B[3] = bmp.GetPixel(y + 2, x + 1).G;
					B[4] = bmp.GetPixel(y + 1, x + 2).G;

					C[0] = bmp.GetPixel(y + 1, x).B;
					C[1] = bmp.GetPixel(y, x + 1).B;
					C[2] = bmp.GetPixel(y + 1, x + 1).B;
					C[3] = bmp.GetPixel(y + 2, x + 1).B;
					C[4] = bmp.GetPixel(y + 1, x + 2).B;

					int t1 =  - A[0] - A[1] + 5 * A[2] - A[3] - A[4] ;
					int t2 =  - B[0] - B[1] + 5 * B[2] - B[3] - B[4] ;
					int t3 =  - C[0] - C[1] + 5 * C[2] - C[3] - C[4] ;

					if (t1 > 255)
						t1 = 255;
					else if (t1 < 0)
						t1 = 0;
					if (t2 > 255)
						t2 = 255;
					else if (t2 < 0)
						t2 = 0;
					if (t3 > 255)
						t3 = 255;
					else if (t3 < 0)
						t3 = 0;
					bmp.SetPixel(y, x, Color.FromArgb(t1, t2, t3));
				}
			}
			anhmoi.Image = bmp;
			MessageBox.Show("Đã lọc thông cao thành công", "Thông báo");
		}


		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}