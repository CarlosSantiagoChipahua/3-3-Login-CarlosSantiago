using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _3_3_login
{
	internal class clsDaoUsuarios
	{
		private clsConexion conexion;

		public clsDaoUsuarios()
		{
			conexion = new clsConexion();
		}

		// Método para verificar si hay usuarios en la base de datos
		public bool HayUsuariosRegistrados()
		{
			using (MySqlConnection cn = conexion.GetConexion())
			{
				try
				{
					cn.Open();
					string strSQL = "SELECT COUNT(*) FROM users";
					MySqlCommand comando = new MySqlCommand(strSQL, cn);
					int count = Convert.ToInt32(comando.ExecuteScalar());
					return count > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al verificar usuarios: " + ex.Message);
					return false;
				}
			}
		}

		// Método para crear usuario administrador por defecto
		public bool CrearUsuarioAdministrador()
		{
			using (MySqlConnection cn = conexion.GetConexion())
			{
				try
				{
					cn.Open();
					string strSQL = @"INSERT INTO users (firstname, lastname, username, password, email, description) 
                                VALUES ('Administrador', 'Principal', 'admin', @Password, 'admin@sistema.com', 'Usuario administrador del sistema')";

					MySqlCommand comando = new MySqlCommand(strSQL, cn);
					comando.Parameters.AddWithValue("@Password", clsConexion.EncriptarPassword("admin123"));

					int resultado = comando.ExecuteNonQuery();
					return resultado > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al crear usuario administrador: " + ex.Message);
					return false;
				}
			}
		}

		public bool ValidarUsuario(string username, string password)
		{
			string passwordEncriptado = clsConexion.EncriptarPassword(password);

			using (MySqlConnection cn = conexion.GetConexion())
			{
				try
				{
					cn.Open();
					string strSQL = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password AND userstatus = true";
					MySqlCommand comando = new MySqlCommand(strSQL, cn);
					comando.Parameters.AddWithValue("@Username", username);
					comando.Parameters.AddWithValue("@Password", passwordEncriptado);

					int count = Convert.ToInt32(comando.ExecuteScalar());
					return count > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al validar usuario: " + ex.Message);
					return false;
				}
			}
		}

		public bool AgregarUsuario(clsUsuario usuario)
		{
			using (MySqlConnection cn = conexion.GetConexion())
			{
				try
				{
					cn.Open();
					string strSQL = @"INSERT INTO users (firstname, lastname, username, password, email, description) 
                                VALUES (@FirstName, @LastName, @UserName, @Password, @Email, @Description)";

					MySqlCommand comando = new MySqlCommand(strSQL, cn);
					comando.Parameters.AddWithValue("@FirstName", usuario.FirstName);
					comando.Parameters.AddWithValue("@LastName", usuario.LastName);
					comando.Parameters.AddWithValue("@UserName", usuario.UserName);
					comando.Parameters.AddWithValue("@Password", clsConexion.EncriptarPassword(usuario.Password));
					comando.Parameters.AddWithValue("@Email", usuario.Email);
					comando.Parameters.AddWithValue("@Description", usuario.Description);

					int resultado = comando.ExecuteNonQuery();
					return resultado > 0;
				}
				catch (MySqlException ex)
				{
					if (ex.Number == 1062) // Duplicate entry
					{
						MessageBox.Show("El nombre de usuario o email ya existe.");
					}
					else
					{
						MessageBox.Show("Error al agregar usuario: " + ex.Message);
					}
					return false;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al agregar usuario: " + ex.Message);
					return false;
				}
			}
		}

		public List<clsUsuario> ObtenerUsuarios()
		{
			List<clsUsuario> listaUsuarios = new List<clsUsuario>();

			using (MySqlConnection cn = conexion.GetConexion())
			{
				try
				{
					cn.Open();
					string strSQL = "SELECT userid, firstname, lastname, username, email, description, userstatus, createddate FROM users";
					MySqlCommand comando = new MySqlCommand(strSQL, cn);

					using (MySqlDataReader reader = comando.ExecuteReader())
					{
						while (reader.Read())
						{
							clsUsuario usuario = new clsUsuario();
							usuario.UserId = reader.GetInt32("userid");
							usuario.FirstName = reader.GetString("firstname");
							usuario.LastName = reader.GetString("lastname");
							usuario.UserName = reader.GetString("username");
							usuario.Email = reader.GetString("email");
							usuario.Description = reader.GetString("description");
							usuario.UserStatus = reader.GetBoolean("userstatus");
							usuario.CreatedDate = reader.GetDateTime("createddate");

							listaUsuarios.Add(usuario);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al obtener usuarios: " + ex.Message);
				}
			}

			return listaUsuarios;
		}
	}
}
