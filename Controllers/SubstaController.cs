using System.Collections.Generic;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastaController
    {
        private List<Subasta> subastas = new List<Subasta>();

        public List<Subasta> ObtenerSubastas() => subastas;
        public int ObtenerNuevoId()
        {
            if (subastas.Count == 0) return 1;
            return subastas.Max(s => s.Id) + 1;
        }

        public void AgregarSubasta(Subasta s)
        {
            subastas.Add(s);
        }

        public void RegistrarPuja(Subasta s, Postor p, decimal monto)
        {
            if (s.Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");

            if (!s.Postores.Contains(p))
                throw new InvalidOperationException("El postor no pertenece a esta subasta.");

 
            var nuevaPuja = new Puja(p, monto);
            s.AgregarPuja(nuevaPuja);
        }

    }

}

