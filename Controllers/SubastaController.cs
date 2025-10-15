using System.Collections.Generic;
using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Services;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastaController
    {
        private readonly SubastaService service;

        public SubastaController(SubastaService srv)
        {
            service = srv;
        }

        public List<Subasta> ObtenerSubastas()
        {
            return service.ObtenerSubastas();
        }

        public void AgregarSubasta(Subasta s)
        {
            service.AgregarSubasta(s);
        }

        public int ObtenerNuevoId()
        {
            return service.ObtenerNuevoId();
        }

        public void RegistrarPuja(Subasta subasta, Postor postor, decimal monto)
        {
            service.RegistrarPuja(subasta, postor, monto);
        }

    }
}