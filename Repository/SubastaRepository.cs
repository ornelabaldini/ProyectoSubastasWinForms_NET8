using System;
using System.Linq;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class SubastaRepository
    {
        private readonly List<Subasta> subastas = new List<Subasta>();

        public List<Subasta> ObtenerTodos() => subastas;

        public void Agregar(Subasta subasta)
        {
            subastas.Add(subasta);
        }

        public int ObtenerNuevoId()
        {
            if (subastas.Count == 0)
                return 1;
            return subastas[subastas.Count - 1].Id + 1;}
    }
}
