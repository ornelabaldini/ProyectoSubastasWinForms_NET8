using System.Collections.Generic;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastaController
    {
        private List<Subasta> subastas = new List<Subasta>();

        public List<Subasta> ObtenerSubastas() => subastas;

        public void AgregarSubasta(Subasta s)
        {
            subastas.Add(s);
        }

        public void RegistrarPuja(Subasta s, Postor p, decimal monto)
        {
            if (!s.Postores.Contains(p)) return;

            if (monto >= s.Pujainicial && monto > s.OfertaGanadora)
            {
                s.OfertaGanadora = monto;
                s.Ganador = p;
            }
        }
    }
}
