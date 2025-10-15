using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace _3_3_login
{
	internal class clsConexion
	{
		private MySqlConnection conexion;
		private string server = "localhost";
		private string database = "login";
		private string user = "root";
		private string password = "root";
		private string cadenaConexion;

		public clsConexion()
		{
			cadenaConexion = $"server={server}; database={database}; user={user}; pwd={password}";
		}

		public MySqlConnection GetConexion()
		{
			return new MySqlConnection(cadenaConexion);
		}

		public static string EncriptarPassword(string password)
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}
	}
}
