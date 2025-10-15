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
	public partial class frmRegistroUsers : Form
	{
		public frmRegistroUsers()
		{
			InitializeComponent();
			// Configurar los TextBox
			txtFirstName.PlaceholderText = "First Name";
			txtLastName.PlaceholderText = "Last Name";
			txtEmail.PlaceholderText = "Email";
			txtUserName.PlaceholderText = "User Name";

			txtPassword.UseSystemPasswordChar = true;
			txtPassword.PlaceholderText = "Password";
			txtConfirmPassword.UseSystemPasswordChar = true;
			txtConfirmPassword.PlaceholderText = "Confirmar Password";

			txtDescription.PlaceholderText = "About Yourselft...";
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCrearUser_Click(object sender, EventArgs e)
		{
			if (!ValidarCampos())
				return;

			try
			{
				clsUsuario nuevoUsuario = new clsUsuario();
				nuevoUsuario.FirstName = txtFirstName.Text;
				nuevoUsuario.LastName = txtLastName.Text;
				nuevoUsuario.Email = txtEmail.Text;
				nuevoUsuario.UserName = txtUserName.Text;
				nuevoUsuario.Password = txtPassword.Text; // Se encriptará en el DAO
				nuevoUsuario.Description = txtDescription.Text;

				clsDaoUsuarios daoUsuarios = new clsDaoUsuarios();
				if (daoUsuarios.AgregarUsuario(nuevoUsuario))
				{
					MessageBox.Show("Usuario registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimpiarCampos();
				}
				else
				{
					MessageBox.Show("Error al registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidarCampos()
		{
			if (string.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text.Length < 3)
			{
				MessageBox.Show("El nombre debe tener al menos 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text.Length < 3)
			{
				MessageBox.Show("El apellido debe tener al menos 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
			{
				MessageBox.Show("Ingrese un email válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text.Length < 3)
			{
				MessageBox.Show("El usuario debe tener al menos 3 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Length < 6)
			{
				MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (txtPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void LimpiarCampos()
		{
			txtFirstName.Clear();
			txtLastName.Clear();
			txtEmail.Clear();
			txtUserName.Clear();
			txtPassword.Clear();
			txtConfirmPassword.Clear();
			txtDescription.Clear();
		}

		private void frmRegistroUsers_Load(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = true;
			txtConfirmPassword.UseSystemPasswordChar = true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			frmMenu menu = new frmMenu();
			menu.Show();
			this.Hide();
		}

		private void frmRegistroUsers_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
