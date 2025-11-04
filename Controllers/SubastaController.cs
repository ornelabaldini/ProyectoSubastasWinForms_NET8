using System.Collections.Generic;
using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Services;


namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastaController
    {
        private readonly SubastaService service;
        private readonly PostorService postorService;
        private readonly ArticuloService articuloService;
        

        public SubastaController()
        {
            service = new KundeServiceAdapter(); // Adaptador para SubastaService
            this.postorService = new PostorService();
        }
        private class KundeServiceAdapter : SubastaService;

        public List<Subasta> ObtenerSubastas()
        {
            return service.ObtenerSubastas();
        }

        public bool AgregarSubasta( Subastador subastador, Articulo articulo, decimal montoInicial, decimal pujaDAumento)
        {
            Subasta subasta = new Subasta(montoInicial, pujaAumento, subastador, articulo);
            return service.RegistrarSubasta(subasta);
        }
        public bool ModificarNombreArticuloSubasta(int idSubasta, string nuevoNombre)
        {
            var subasta = service.ObtenerPoridSubasta(idSubasta);
            if (subasta == null) return false;

            var articulo = subasta.ArticuloPorSubastar;
            if (articulo == null) return false;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            return articuloService.ModificarNombreArticulo(articulo.idArticulo, nuevoNombre);
        }

        public bool EliminarSubasta(int idSubasta)
        {
            return service.EliminarSubasta(idSubasta);
        }

        public bool RegistrarPostorGanador(int idSubasta, Postor postor)
        {
            Subasta subasta = service.ObtenerPorid(Subasta);
            if (subasta == null || postor == null) return false;
            if (subasta.EstaFinalizada) return false;

            subasta.RegistrarPuja(postor);  // Registrar la puja del postor. Actualiza el monto de la subasta internamente.
            return service.ActualizarPostorGanador(subasta); 
        }

    }}