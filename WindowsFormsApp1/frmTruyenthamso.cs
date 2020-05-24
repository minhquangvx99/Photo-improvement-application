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
	public partial class frmTruyenthamso : Form
	{
		public frmTruyenthamso()
		{
			InitializeComponent();
		}
		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
		private void bạnCầnNhập1SốThựcToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void frmTruyenthamso_Load(object sender, EventArgs e)
		{
			this.AcceptButton = button1;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if ( textBox1.Text == "")
			{
				MessageBox.Show("Bạn không được để trống ô nhập giá trị", "Thông báo");
			}
			else
			{
				this.Close();
			}
		}

	}
}
