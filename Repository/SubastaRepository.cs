using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class SubastaRepository
    {
        private readonly List<Subasta> subastas;

        public SubastaRepository()
        {
            subastas = new List<Subasta>();
        }

        public void Agregar(Subasta subasta) => subastas.Add(subasta);

        public List<Subasta> ObtenerTodas() => subastas;

        public Subasta ObtenerPorId(int id) => subastas.FirstOrDefault(s => s.Id == id);

        public void Eliminar(int id)
        {
            var subasta = ObtenerPorId(id);
            if (subasta != null)
                subastas.Remove(subasta);
        }
    }
}
