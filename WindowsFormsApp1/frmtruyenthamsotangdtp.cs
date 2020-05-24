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
	public partial class frmtruyenthamso1 : Form
	{
		public frmtruyenthamso1()
		{
			InitializeComponent();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void bạnCầnNhập1SốThựcDươngToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			if (textBox1.Text == "")
			{
				MessageBox.Show("Bạn không được để trống ô nhập giá trị", "Thông báo");
			}
			else if (double.Parse(textBox1.Text) <= 0)
			{
				MessageBox.Show("Bạn cần nhập 1 số thực dương", "Thông báo");
			}
			else
			{
				this.Close();
			}
		}

		private void frmtruyenthamso1_Load(object sender, EventArgs e)
		{
			this.AcceptButton = button1;
		}

	}
}
