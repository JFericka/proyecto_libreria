using Microsoft.Data.SqlClient;
using ProyecLibreria.Dal.Common;
using ProyecLibreria.Entities.Entidades;
using System.Data;
using System.Xml;

namespace ProyecLibreria.Dal.Tablas
{
    public class RolDal
    {
        public async Task<PaginacionEntity<RolEntities>>MostrarAsync(int pagina, int tamPagina, string? buscar = null)
        {
            try
            {
                PaginacionEntity<RolEntities> resultado = new();

                using SqlConnection cn = Conexion.ObtenerConexion();

                // total de registros
                using SqlCommand cmdTotal = new(" sp_ContarRoles", cn);

                cmdTotal.CommandType = CommandType.StoredProcedure;
                cmdTotal.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());


                await cn.OpenAsync();


                resultado.TotalRegistros = Convert.ToInt32(await cmdTotal.ExecuteScalarAsync());

                //mostrar registros 
                using SqlCommand cmd = new("sp_MostrarRoles", cn);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buscar", string.IsNullOrWhiteSpace(buscar) ? DBNull.Value : buscar.Trim());
                cmd.Parameters.AddWithValue("@pagina", pagina);
                cmd.Parameters.AddWithValue("@tamPagina", tamPagina);

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    RolEntities rol = new();
                    rol.AsignarId(Convert.ToInt32(dr["Id"]));
                    rol.CambiarNombre(dr["nombre"].ToString()!);
                    rol.CambiarEstado(Convert.ToBoolean(dr["activo"]));

                    resultado.Registros.Add(rol);
                }

                resultado.PaginaActual = pagina;
                resultado.TamPagina = tamPagina;

                return resultado;

            }
            catch (SqlException ex)
            {
                throw SqlErrorHelpers.TraducirError(ex);

            }
        }

        public async Task<List<RolEntities>> MostrarRolesActivosAsync()
        {

            try
            {
                List<RolEntities> lista = [];

                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_MostrarRolesActivos", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                await cn.OpenAsync();
               
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    RolEntities rol = new();

                    rol.AsignarId(Convert.ToInt32(dr["Id"]));
                    rol.CambiarNombre(dr["nombre"].ToString()!);

                    lista.Add(rol);

                }

                return lista;

            }
            catch (SqlException ex)
            {
                throw SqlErrorHelpers.TraducirError(ex);

            }
        }

        public async Task<RolEntities?>  ObtenerPorIdAsync(int id)
        {

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_ObtenerRolPorId", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                await cn.OpenAsync();

                using SqlDataReader dr = await cmd.ExecuteReaderAsync();


                if (!await dr.ReadAsync())
                    return null;

                RolEntities rol = new();

                    rol.AsignarId(Convert.ToInt32(dr["Id"]));
                    rol.CambiarNombre(dr["nombre"].ToString()!);
                    rol.CambiarEstado(Convert.ToBoolean(dr["activo"]));
                

                return rol;

            }
            catch (SqlException ex)
            {
                throw SqlErrorHelpers.TraducirError(ex);

            }
        }

        public async Task AgregrarAsync(RolEntities rol, string usuarioApp)
        {

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_AgregarRol", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd .ExecuteReaderAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelpers.TraducirError(ex);

            }
        }

        public async Task ActualizarAsync(RolEntities rol, string usuarioApp)
        {

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new(" sp_ActualizarRol", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rol.Id);
                cmd.Parameters.AddWithValue("@nombre", rol.Nombre);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd.ExecuteReaderAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelpers.TraducirError(ex);

            }
        }

        public async Task CambiarEstadoAsync(int id, bool activo, string usuarioApp)
        {

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_CambiarEstadoRol", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@usuarioApp", usuarioApp);

                await cn.OpenAsync();
                await cmd.ExecuteReaderAsync();
            }
            catch (SqlException ex)
            {
                throw SqlErrorHelpers.TraducirError(ex);

            }
        }
    }
}








































               