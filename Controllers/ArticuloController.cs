using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class ArticuloController
    {
        private readonly ArticuloService service;

        public ArticuloController()
        {
            service = new KundeServiceAdapter();
        }
        private class KundeServiceAdapter : ArticuloService;

        public List<Articulo> ObtenerArticulos()
        {
            return service.ObtenerArticulos();
        }

        public Articulo AgregarArticulo(string nombre, string detalle)
        {
            Articulo articulo = new Articulo(nombre, detalle);
            bool ok = service.RegistrarArticulo(articulo);
            return ok ? articulo : null;
        }


        public bool EliminarArticulo(int idArticulo)
        {
            return service.EliminarArticulo(idArticulo);
        }

        public bool ModificarDetalleArticulo(int idArticulo, string nuevoDetalle)
        {
            return service.ModificarDetalleArticulo(idArticulo, nuevoDetalle);
        }
        public bool ModificarNombreArticulo(int Articulo, string nuevoNombre)
        {
            return service.ModificarNombreArticulo(idArticulo, nuevoNombre);
        }

    }
}
