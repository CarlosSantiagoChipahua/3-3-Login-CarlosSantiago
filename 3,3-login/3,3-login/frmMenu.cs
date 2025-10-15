using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_3_login
{
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			InitializeComponent();
		}

		private void btnRegistrarUser_Click(object sender, EventArgs e)
		{
			frmRegistroUsers registro = new frmRegistroUsers();
			registro.Show();
			this.Hide();
		}

		private void btnVerUsers_Click(object sender, EventArgs e)
		{
			frmVerUsers verUsers = new frmVerUsers();
			verUsers.Show();
			this.Hide();
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmLogin login = new frmLogin();
			login.Show();
			this.Hide();
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{

		}

		private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void frmMenu_FormClosed_1(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
