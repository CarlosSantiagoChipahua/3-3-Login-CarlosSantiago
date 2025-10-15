using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_3_login
{
	public partial class frmVerUsers : Form
	{
		public frmVerUsers()
		{
			InitializeComponent();
			CargarUsuarios();
		}

		private void frmVerUsers_Load(object sender, EventArgs e)
		{

		}

		private void CargarUsuarios()
		{
			try
			{
				clsDaoUsuarios daoUsuarios = new clsDaoUsuarios();
				var listaUsuarios = daoUsuarios.ObtenerUsuarios();

				dgvUsers.DataSource = listaUsuarios;
				dgvUsers.Columns["Password"].Visible = false; // No mostrar la contraseña
				dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			frmMenu menu = new frmMenu();
			menu.Show();
			this.Hide();
		}

		private void frmVerUsers_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
