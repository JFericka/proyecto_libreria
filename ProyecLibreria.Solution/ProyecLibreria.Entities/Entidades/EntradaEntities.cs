using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecLibreria.Entities.Entidades
{
    public class EntradaEntities
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public DateTime FechaIngreso { get; private set; }
        public string? Observaciones { get; private set; }
        public string NombreUsuario { get; private set; } = string.Empty; // útil para joins

        public EntradaEntities() { }

        public EntradaEntities(int usuarioId, string? observaciones = null)
        {
            CambiarUsuarioId(usuarioId);
            CambiarObservaciones(observaciones);
            FechaIngreso = DateTime.Now;
        }

        public void AsignarId(int id) => Id = id;

        public void CambiarUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID del usuario debe ser positivo.");
            UsuarioId = usuarioId;
        }

        public void CambiarObservaciones(string? observaciones)
        {
            Observaciones = string.IsNullOrWhiteSpace(observaciones) ? null : observaciones.Trim();
        }

        public void AsignarFechaIngreso(DateTime fecha)
        {
            FechaIngreso = fecha;
        }

        public void CambiarNombreUsuario(string nombre)
        {
            NombreUsuario = nombre?.Trim() ?? string.Empty;
        }
    }
}
