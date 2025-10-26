using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Services
{
    public class ArticuloService
    {
        private readonly ArticuloRepository repository;

        public ArticuloService()
        {
            repository = new ArticuloRepository();
        }

        public bool ModificarNombreArticulo(int numeroArticulo, string nuevoNombre)
        {
            var articulo = repository.ObtenerPorNumeroArticulo(numeroArticulo);
            if (articulo == null) return false;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                throw new ArgumentException("El nombre del artículo no puede estar vacío.");

            return repository.ActualizarNombre(articulo, nuevoNombre);
        }

        public bool ModificarDetalleArticulo(int numeroArticulo, string nuevoDetalle)
        {
            var articulo = repository.ObtenerPorNumeroArticulo(numeroArticulo);
            if (articulo == null) return false;

            if (string.IsNullOrWhiteSpace(nuevoDetalle))
                throw new ArgumentException("El detalle del artículo no puede estar vacío.");

            return repository.ActualizarDetalle(articulo, nuevoDetalle);
        }

        public List<Articulo> ObtenerArticulos()
        {
            return repository.ObtenerTodos();
        }

        public bool RegistrarArticulo(Articulo articulo)
        {
            if (articulo == null || string.IsNullOrWhiteSpace(articulo.Name))
                return false;

            repository.Agregar(articulo);
            return true;
        }

        public bool EliminarArticulo(int numeroArticulo)
        {
            var existente = repository.ObtenerPorNumeroArticulo(numeroArticulo);
            if (existente == null) return false;

            repository.Eliminar(numeroArticulo);
            return true;
        }
    }
}