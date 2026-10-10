using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using ProyecLibreria.Dal.Common;
using ProyecLibreria.Entities.Entidades;
using System.Data;

namespace ProyecLibreria.Dal.Tablas
{
    public class UsuarioDal
    {
        public async Task<int> InsertarAsync(UsuarioEntities usuario)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_Usuario_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@RolId", usuario.RolId);

                await cn.OpenAsync();
                object result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task ActualizarAsync(UsuarioEntities usuario)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_Usuario_Actualizar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                cmd.Parameters.AddWithValue("@RolId", usuario.RolId);
                cmd.Parameters.AddWithValue("@Estado", usuario.Estado);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task CambiarEstadoAsync(int id, bool estado)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_Usuario_CambiarEstado", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Estado", estado);

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<UsuarioEntities>> ListarAsync()
        {
            List<UsuarioEntities> lista = new();

            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_Usuario_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                while (await dr.ReadAsync())
                {
                    UsuarioEntities usuario = new();
                    usuario.AsignarId(dr.GetInt32(dr.GetOrdinal("id")));
                    usuario.CambiarCorreo(dr.GetString(dr.GetOrdinal("correo")));
                    usuario.CambiarRolId(dr.GetInt32(dr.GetOrdinal("rol_id")));
                    usuario.CambiarNombreRol(dr.GetString(dr.GetOrdinal("nombre_rol")));
                    usuario.CambiarEstado(dr.GetBoolean(dr.GetOrdinal("estado")));
                    usuario.AsignarFechaRegistro(dr.GetDateTime(dr.GetOrdinal("fecha_registro")));

                    lista.Add(usuario);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return lista;
        }

        public async Task<UsuarioEntities?> ObtenerPorIdAsync(int id)
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new("sp_Usuario_ObtenerPorId", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                await cn.OpenAsync();
                using SqlDataReader dr = await cmd.ExecuteReaderAsync();

                if (await dr.ReadAsync())
                {
                    UsuarioEntities usuario = new();
                    usuario.AsignarId(dr.GetInt32(dr.GetOrdinal("id")));
                    usuario.CambiarCorreo(dr.GetString(dr.GetOrdinal("correo")));
                    usuario.CambiarRolId(dr.GetInt32(dr.GetOrdinal("rol_id")));
                    usuario.CambiarNombreRol(dr.GetString(dr.GetOrdinal("nombre_rol")));
                    usuario.CambiarEstado(dr.GetBoolean(dr.GetOrdinal("estado")));
                    usuario.AsignarFechaRegistro(dr.GetDateTime(dr.GetOrdinal("fecha_registro")));
                    return usuario;
                }

                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
