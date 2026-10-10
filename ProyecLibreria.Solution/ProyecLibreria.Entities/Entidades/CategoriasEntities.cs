using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecLibreria.Entities.Entidades
{
    public class CategoriasEntities
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; } = string.Empty;
        public string? Descripcion { get; private set; }
        public bool Activo { get; private set; } = true;
        public string Estado => Activo ? "Activo" : "Inactivo";

        public CategoriasEntities() { }

        public CategoriasEntities(string nombre, string? descripcion = null)
        {
            CambiarNombre(nombre);
            CambiarDescripcion(descripcion);
            Activo = true;
        }

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            Nombre = nombre.Trim();
        }

        public void CambiarDescripcion(string? descripcion)
        {
            Descripcion = string.IsNullOrWhiteSpace(descripcion) ? null : descripcion.Trim();
        }

        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }
    }
}