using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecLibreria.Entities.Entidades
{
    public class ProductoEntities
    {
        public int Id { get; private set; }
        public string? CodigoBarras { get; private set; }
        public string Nombre { get; private set; } = string.Empty;
        public int? SubcategoriaId { get; private set; }
        public string Marca { get; private set; } = string.Empty;
        public decimal PrecioCosto { get; private set; }
        public decimal PrecioVenta { get; private set; }
        public int StockActual { get; private set; }
        public int StockMinimo { get; private set; } = 5;
        public bool Activo { get; private set; } = true;

        public string NombreSubcategoria { get; private set; } = string.Empty;
        public string Estado => Activo ? "Activo" : "Inactivo";

        public ProductoEntities() { }

        public ProductoEntities(string nombre, string marca, decimal precioCosto, decimal precioVenta, int? subcategoriaId = null, string? codigoBarras = null)
        {
            CambiarNombre(nombre);
            CambiarMarca(marca);
            CambiarPrecioCosto(precioCosto);
            CambiarPrecioVenta(precioVenta);
            CambiarSubcategoriaId(subcategoriaId);
            CambiarCodigoBarras(codigoBarras);
            StockActual = 0;
            StockMinimo = 5;
            Activo = true;
        }

        public void AsignarId(int id) => Id = id;

        public void CambiarCodigoBarras(string? codigoBarras)
        {
            CodigoBarras = string.IsNullOrWhiteSpace(codigoBarras) ? null : codigoBarras.Trim();
        }

        public void CambiarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            Nombre = nombre.Trim();
        }

        public void CambiarSubcategoriaId(int? subcategoriaId)
        {
            if (subcategoriaId.HasValue && subcategoriaId <= 0)
                throw new ArgumentException("El ID de la subcategoría debe ser positivo.");
            SubcategoriaId = subcategoriaId;
        }

        public void CambiarMarca(string marca)
        {
            if (string.IsNullOrWhiteSpace(marca))
                throw new ArgumentException("La marca no puede estar vacía.");
            Marca = marca.Trim();
        }

        public void CambiarPrecioCosto(decimal precioCosto)
        {
            if (precioCosto < 0)
                throw new ArgumentException("El precio de costo no puede ser negativo.");
            PrecioCosto = precioCosto;
        }

        public void CambiarPrecioVenta(decimal precioVenta)
        {
            if (precioVenta < 0)
                throw new ArgumentException("El precio de venta no puede ser negativo.");
            PrecioVenta = precioVenta;
        }

        public void CambiarStockActual(int stockActual)
        {
            if (stockActual < 0)
                throw new ArgumentException("El stock actual no puede ser negativo.");
            StockActual = stockActual;
        }

        public void CambiarStockMinimo(int stockMinimo)
        {
            if (stockMinimo < 0)
                throw new ArgumentException("El stock mínimo no puede ser negativo.");
            StockMinimo = stockMinimo;
        }

        public void CambiarNombreSubcategoria(string nombre)
        {
            NombreSubcategoria = nombre?.Trim() ?? string.Empty;
        }

        public void CambiarEstado(bool activo)
        {
            Activo = activo;
        }
    }
}