using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastaController
    {
        private readonly List<Subasta> subastas = new();

        public IReadOnlyCollection<Subasta> ObtenerSubastas() => subastas.AsReadOnly();

        public int ObtenerNuevoId()
            => subastas.Count == 0 ? 1 : subastas.Max(s => s.Id) + 1;

        public void AgregarSubasta(Subasta s)
        {
            if (subastas.Any(x => x.Id == s.Id))
                throw new InvalidOperationException("Ya existe una subasta con ese ID.");

            if (s.Duracion <= TimeSpan.Zero)
                throw new InvalidOperationException("La duración de la subasta debe ser mayor a cero.");

            subastas.Add(s);
        }

        public void RegistrarPuja(Subasta s, Postor p, decimal monto)
        {
            s.RegistrarPuja(p, monto); 
        }

        public void ActualizarEstadoSubastas()
        {
            DateTime ahora = DateTime.Now;
            foreach (var subasta in subastas)
                subasta.ActualizarEstado(ahora);
        }
    }
}
