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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
			// Configurar el TextBox de contraseña
			txtPassword.UseSystemPasswordChar = true;
			txtUserName.PlaceholderText = "User Name";
			txtPassword.PlaceholderText = "Password";
		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnSingIn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsDaoUsuarios daoUsuarios = new clsDaoUsuarios();
			if (daoUsuarios.ValidarUsuario(txtUserName.Text, txtPassword.Text))
			{
				frmMenu menu = new frmMenu();
				menu.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_FormClosed_1(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
