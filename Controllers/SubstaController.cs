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

            decimal pujaActual = s.ObtenerPujaActual();

            if (monto < pujaActual + s.Incremento)
                throw new InvalidOperationException($"La puja debe ser al menos {pujaActual + s.Incremento:C}.");

            var nuevaPuja = new Puja(p, monto);
            s.AgregarPuja(nuevaPuja);
        }

        public void ActualizarEstadoSubastas()
        {
            DateTime ahora = DateTime.Now;
            foreach (var subasta in subastas)
            {
                if (subasta.Estado == SubastaEstado.Finalizada)
                    continue;

                DateTime finSubasta = subasta.FechaInicio.Add(subasta.Duracion);

                if (ahora >= finSubasta)
                {
                    subasta.Estado = SubastaEstado.Finalizada;
                }
                else if (ahora >= subasta.FechaInicio)
                {
                    subasta.Estado = SubastaEstado.EnCurso;
                }
                else
                {
                    subasta.Estado = SubastaEstado.Pendiente;
                }
            }
        }

    }

}

