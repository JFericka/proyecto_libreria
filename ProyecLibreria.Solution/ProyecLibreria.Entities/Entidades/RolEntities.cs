using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecLibreria.Entities.Entidades
{
    public class RolEntities
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; } = string.Empty;
        public bool Activo { get; private set; } = true;

        public string EstadoTexto => Activo ? "Activo" : "Inactivo";

        public RolEntities() { }

        public RolEntities(string nombre)
        {
            CambiarNombre(nombre);
            Activo = true;
        }

        public void AsignarId(int id)
        {
            Id = id;
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del rol no puede estar vacío.");
            Nombre = nombre.Trim();
        }

        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }
    }
}
