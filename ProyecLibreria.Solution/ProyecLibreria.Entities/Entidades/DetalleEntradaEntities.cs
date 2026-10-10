using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyecLibreria.Entities.Entidades
{
    public class DetalleEntradaEntities
    {
        public int Id { get; private set; }
        public int EntradaId { get; private set; }
        public int ProductoId { get; private set; }
        public int Cantidad { get; private set; }
        public decimal PrecioCostoUnitario { get; private set; }
        public string NombreProducto { get; private set; } = string.Empty;

        public DetalleEntradaEntities() { }

        public DetalleEntradaEntities(int entradaId, int productoId, int cantidad, decimal precioCostoUnitario)
        {
            CambiarEntradaId(entradaId);
            CambiarProductoId(productoId);
            CambiarCantidad(cantidad);
            CambiarPrecioCostoUnitario(precioCostoUnitario);
        }

        public void AsignarId(int id) => Id = id;

        public void CambiarEntradaId(int entradaId)
        {
            if (entradaId <= 0)
                throw new ArgumentException("El ID de la entrada debe ser positivo.");
            EntradaId = entradaId;
        }

        public void CambiarProductoId(int productoId)
        {
            if (productoId <= 0)
                throw new ArgumentException("El ID del producto debe ser positivo.");
            ProductoId = productoId;
        }

        public void CambiarCantidad(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            Cantidad = cantidad;
        }

        public void CambiarPrecioCostoUnitario(decimal precio)
        {
            if (precio < 0)
                throw new ArgumentException("El precio de costo no puede ser negativo.");
            PrecioCostoUnitario = precio;
        }

        public void CambiarNombreProducto(string nombre)
        {
            NombreProducto = nombre?.Trim() ?? string.Empty;
        }
    }
}