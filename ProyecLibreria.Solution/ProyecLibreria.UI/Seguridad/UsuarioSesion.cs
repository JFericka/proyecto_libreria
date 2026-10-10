using System;
using System.Collections.Generic;
using System.Text;
using ProyecLibreria.Entities.Entidades;

namespace ProyecLibreria.UI.Seguridad
{
    public class UsuarioSesion
    {
        // Sin sesión por defecto: se llenan solo al iniciar sesión
        public static int IdUsuario { get; set; }
        public static string CorreoElectronico { get; set; } = string.Empty;
        public static int IdRol { get; set; }
        public static string NombreRol { get; set; } = string.Empty;

        /// <summary>
        /// Registrar sesión
        /// </summary>
        public static void IniciarSesion(UsuarioEntities usuario)
        {
            IdUsuario = usuario.Id;
            CorreoElectronico = usuario.Correo;
            IdRol = usuario.RolId;
            NombreRol = usuario.NombreRol;
        }

        /// <summary>
        /// Cerrar sesión
        /// </summary>
        public static void CerrarSesion()
        {
            IdUsuario = 0;
            CorreoElectronico = string.Empty;
            IdRol = 0;
            NombreRol = string.Empty;
        }
    }
}