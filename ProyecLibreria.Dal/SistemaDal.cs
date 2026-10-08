using Microsoft.Data.SqlClient;
using ProyecLibreria.Dal.Common;
using System;
using System.Data;
using System.Threading.Tasks;

namespace ProyecLibreria.Dal
{
    public class SistemaDal
    {
        public async Task CrearAdministradorInicialAsync()
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_CrearAdministradorInicial", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
