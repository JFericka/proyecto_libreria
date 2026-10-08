
using ProyecLibreria.Dal;
using ProyecLibreria.Dal.Common;
using ProyecLibreria.UI.Formularios;
using ProyecLibreria.UI.Formularios.Seguridad;
using ProyectLibreria.Bll;

namespace ProyecLibreria.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                ConfiguracionDal configuracionDal = new();

                // Si no existe la configuración, solicitarla
                if (!configuracionDal.ExisteConfiguracion())
                {
                    var frmConfig = new FrmConfiguracionConexion();
                    DialogResult resultado = frmConfig.ShowDialog();

                    if (resultado != DialogResult.OK)
                        return;
                }

                // Leer la configuración guardada
                var config = configuracionDal.Obtener();

                if (config is null)
                {
                    MessageBox.Show("No fue posible cargar la configuración de conexión", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construir la cadena de conexión
                Conexion.CadenaConexion =
                    $"Server={config.Servidor};" +
                    $"Database={config.BaseDatos};" +
                    $"User Id={config.UsuarioSql};" +
                    $"Password={config.Password};" +
                    $"TrustServerCertificate=True;";

                // Crear administrador inicial
                SistemaBll sistemaBll = new SistemaBll(new SistemaDal());
                sistemaBll.CrearAdministradorInicialAsync()
                    .GetAwaiter()
                    .GetResult();

                // Abrir el formulario principal
                Application.Run(new FrmPanelUsuario());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error en la aplicación");
            }
        }
    }
}