namespace _3_3_login
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

			// Verificar y crear usuario administrador si no existe
			VerificarYCrearUsuarioAdministrador();

            Application.Run(new frmLogin());
		}

		static void VerificarYCrearUsuarioAdministrador()
		{
			try
			{
				clsDaoUsuarios daoUsuarios = new clsDaoUsuarios();

				if (!daoUsuarios.HayUsuariosRegistrados())
				{
					DialogResult result = MessageBox.Show(
						"No se encontraron usuarios en la base de datos. ¿Desea crear un usuario administrador por defecto?",
						"Crear Usuario Administrador",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						if (daoUsuarios.CrearUsuarioAdministrador())
						{
							MessageBox.Show(
								"Usuario administrador creado exitosamente:\n\n" +
								"Usuario: admin\n" +
								"Contraseña: admin123\n\n" +
								"Por seguridad, cambie la contraseña después del primer acceso.",
								"Usuario Creado",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information);
						}
						else
						{
							MessageBox.Show(
								"No se pudo crear el usuario administrador. Verifique la conexión a la base de datos.",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al verificar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}