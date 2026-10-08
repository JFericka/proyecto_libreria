using System;
using System.Collections.Generic;
using System.Text;
using ProyecLibreria.Entities.Entidades;

namespace ProyecLibreria.UI.Seguridad
{
    public class UsuarioSesion
    {
        public static int IdUsuario { get; set; } = 1;
        public static string NombreCompleto { get; set; } = "Administrador del Sistema";
        public static string NombreUsuario { get; set; } = "admin";
        public static string CorreoElectronico { get; set; } = "admin@libreria.com";
        public static int IdRol { get; set; } = 1;
        public static string NombreRol { get; set; } = "Administrador";

        /// <summary>
        /// Registrar sesión
        /// </summary>
        public static void IniciarSesion(UsuarioEntities usuario)
        {
            IdUsuario = usuario.Id;
            NombreCompleto = usuario.NombreCompleto;
            NombreUsuario = usuario.NombreUsuario;
            CorreoElectronico = usuario.CorreoElectronico;
            IdRol = usuario.IdRol;
            NombreRol = usuario.NombreRol;
        }

        /// <summary>
        /// Cerrar sesión
        /// </summary>
        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreCompleto = string.Empty;
            NombreUsuario = string.Empty;
            CorreoElectronico = string.Empty;
            IdRol = 0;
            NombreRol = string.Empty;
        }
    }
}