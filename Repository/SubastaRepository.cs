using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class SubastaRepository
    {
        private readonly List<Subasta> subastas = new();

        public IReadOnlyCollection<Subasta> ObtenerTodas() => subastas.AsReadOnly();

        public Subasta ObtenerPorId(int id) => subastas.FirstOrDefault(s => s.Id == id);

        public void Agregar(Subasta subasta)
        {
            if (subasta == null) throw new ArgumentNullException(nameof(subasta));
            if (subastas.Any(s => s.Id == subasta.Id))
                throw new InvalidOperationException("Ya existe una subasta con ese ID.");

            subastas.Add(subasta);
        }

        public void Eliminar(int id)
        {
            var subasta = ObtenerPorId(id);
            if (subasta != null)
                subastas.Remove(subasta);
        }
    }
}
