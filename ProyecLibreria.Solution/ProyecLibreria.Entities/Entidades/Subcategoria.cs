using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecLibreria.Entities.Entidades
{
    public class SubcategoriaEntities
    {
        public int Id { get; private set; }
        public int CategoriaId { get; private set; }
        public string Nombre { get; private set; } = string.Empty;
        public string? Especificaciones { get; private set; }
        public bool Activo { get; private set; } = true;
        public string NombreCategoria { get; private set; } = string.Empty; // útil para joins

        public string Estado => Activo ? "Activo" : "Inactivo";

        public SubcategoriaEntities() { }

        public SubcategoriaEntities(int categoriaId, string nombre, string? especificaciones = null)
        {
            CambiarCategoriaId(categoriaId);
            CambiarNombre(nombre);
            CambiarEspecificaciones(especificaciones);
            Activo = true;
        }

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarCategoriaId(int categoriaId)
        {
            if (categoriaId <= 0)
                throw new ArgumentException("El ID de la categoría debe ser un número positivo.");
            CategoriaId = categoriaId;
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la subcategoría no puede estar vacío.");
            Nombre = nombre.Trim();
        }

        public void CambiarEspecificaciones(string? especificaciones)
        {
            Especificaciones = string.IsNullOrWhiteSpace(especificaciones) ? null : especificaciones.Trim();
        }

        public void CambiarNombreCategoria(string nombreCategoria)
        {
            NombreCategoria = nombreCategoria?.Trim() ?? string.Empty;
        }

        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }
    }
}