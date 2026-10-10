using Microsoft.Data.SqlClient;

namespace ProyecLibreria.Dal.Common
{
    public class Conexion
    {
        public static string CadenaConexion { get; set; } = string.Empty;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
