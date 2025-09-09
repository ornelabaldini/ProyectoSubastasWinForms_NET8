using System.Collections.Generic;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastaController
    {
        private List<Subasta> subastas = new List<Subasta>();

        public List<Subasta> ObtenerSubastasPorEstado(SubastaEstado estado)
        {
            return subastas.FindAll(s => s.Estado == estado);
        }

        public int ObtenerNuevoId()
        {
            if (subastas.Count == 0) return 1;
            return subastas.Max(s => s.Id) + 1;
        }

        public void AgregarSubasta(Subasta s)
        {
            subastas.Add(s);
        }

        public override string ToString()
        {
            return $"Total de subastas: {subastas.Count}";
        }

    }

}

