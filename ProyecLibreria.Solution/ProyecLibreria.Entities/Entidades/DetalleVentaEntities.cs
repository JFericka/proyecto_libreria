using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyecLibreria.Entities.Entidades
{
    public class DetalleVentaEntities
    {
        public int Id { get; private set; }
        public int VentaId { get; private set; }
        public int ProductoId { get; private set; }
        public int Cantidad { get; private set; }
        public decimal PrecioUnitario { get; private set; }
        public decimal Subtotal { get; private set; }
        public string NombreProducto { get; private set; } = string.Empty;

        public DetalleVentaEntities() { }

        public DetalleVentaEntities(int ventaId, int productoId, int cantidad, decimal precioUnitario)
        {
            CambiarVentaId(ventaId);
            CambiarProductoId(productoId);
            CambiarCantidad(cantidad);
            CambiarPrecioUnitario(precioUnitario);
            CalcularSubtotal();
        }

        public void AsignarId(int id) => Id = id;

        public void CambiarVentaId(int ventaId)
        {
            if (ventaId <= 0)
                throw new ArgumentException("El ID de la venta debe ser positivo.");
            VentaId = ventaId;
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
            CalcularSubtotal();
        }

        public void CambiarPrecioUnitario(decimal precio)
        {
            if (precio < 0)
                throw new ArgumentException("El precio unitario no puede ser negativo.");
            PrecioUnitario = precio;
            CalcularSubtotal();
        }

        private void CalcularSubtotal()
        {
            Subtotal = Cantidad * PrecioUnitario;
        }

        public void CambiarNombreProducto(string nombre)
        {
            NombreProducto = nombre?.Trim() ?? string.Empty;
        }
    }
}