using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyecLibreria.Entities.Entidades
{
    public class VentaEntities
    {
        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public DateTime FechaVenta { get; private set; }
        public decimal TotalPagar { get; private set; }
        public string NombreUsuario { get; private set; } = string.Empty;

        public VentaEntities() { }

        public VentaEntities(int usuarioId, decimal totalPagar)
        {
            CambiarUsuarioId(usuarioId);
            CambiarTotalPagar(totalPagar);
            FechaVenta = DateTime.Now;
        }

        public void AsignarId(int id) => Id = id;

        public void CambiarUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("El ID del usuario debe ser positivo.");
            UsuarioId = usuarioId;
        }

        public void CambiarTotalPagar(decimal total)
        {
            if (total < 0)
                throw new ArgumentException("El total a pagar no puede ser negativo.");
            TotalPagar = total;
        }

        public void AsignarFechaVenta(DateTime fecha)
        {
            FechaVenta = fecha;
        }

        public void CambiarNombreUsuario(string nombre)
        {
            NombreUsuario = nombre?.Trim() ?? string.Empty;
        }
    }
}