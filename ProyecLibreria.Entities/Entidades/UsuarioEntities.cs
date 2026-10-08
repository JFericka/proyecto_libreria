using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProyecLibreria.Entities.Entidades
{
    public class UsuarioEntities
    {
        public int Id { get; private set; }
        public string NombreCompleto { get; private set; } = string.Empty;
        public string NombreUsuario { get; private set; } = string.Empty;
        public string CorreoElectronico { get; private set; } = string.Empty;
        public int IdRol { get; private set; }
        public string NombreRol { get; private set; } = string.Empty;

        public bool Activo { get; private set; } = false;
        public string Estado => Activo ? "Activo" : "Inactivo";

        #region Constructores
        public UsuarioEntities() { }
        public UsuarioEntities(string nombreCompleto, string nombreUsuario, string correoElectronico, int idRol)
        {
            CambiarNombreCompleto(nombreCompleto);
            CambiarNombreUsuario(nombreUsuario);
            CambiarCorreoElectronico(correoElectronico);
            CambiarIdRol(idRol);
            Activo = true;
        }
        #endregion
        #region Métodos
        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarNombreCompleto(string nombreCompleto)
        {
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                throw new ArgumentException("El nombre completo no puede estar vacío.");
            NombreCompleto = nombreCompleto.Trim();
        }
        #endregion

        public void CambiarNombreUsuario(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");
            NombreUsuario = nombreUsuario.Trim();
        }

        public void CambiarCorreoElectronico(string correoElectronico)
        {
            if (string.IsNullOrWhiteSpace(correoElectronico))
                throw new ArgumentException("El correo electrónico no puede estar vacío.");
            CorreoElectronico = correoElectronico.Trim();
        }

        public void CambiarIdRol(int idRol)
        {
            if (idRol <= 0)
                throw new ArgumentException("El ID del rol debe ser un número positivo.");
            IdRol = idRol;

        }

        public void CambiarNombreRol(string nombreRol)
        {
            NombreRol = nombreRol.Trim();
        }

        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }
    }
}