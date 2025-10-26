using System;
using System.Linq;
using ProyectoSubastasWinForms_NET8.Models;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class SubastaRepository
    {
        private readonly List<Subasta> subastas;
        private int siguienteid = 1;
        public SubastaRepository()
        {
            subastas = new List<Subasta>();
        }
        public List<Subasta> ObtenerTodos()
        {
            return subastas;
        }
        public Subasta ObtenerPoridSubasta(int idSubasta)
        {
            foreach (Subasta subasta in subastas)
            {
                if (subasta.idDeSubasta == idSubasta)
                {
                    return subasta;
                }
            }

            return null;
        }
        public void Agregar(Subasta subasta)
        {
            subasta.idDeSubasta = siguienteid++; // ← asignación aquí
            subastas.Add(subasta);
        }

        public void Eliminar(int idSubasta)
        {
            int indice = -1;
            for (int i = 0; i < subastas.Count; i++)
            {
                if (
                    subastas[i].idDeSubasta == idSubasta)
                {
                    indice = i;
                    break;
                }
            }
            if (indice >= 0)
            {
                subastas.RemoveAt(indice);
            }
        }

        public void ModificarSubasta(Subasta subasta)
        {
            Subasta sub = ObtenerPoridSubasta(subasta.idDeSubasta);

            if (sub != null)
            {
                sub.PujaInicial = subasta.PujaInicial;
                sub.Subastador = subasta.Subastador;
                sub.ArticuloPorSubastar = subasta.ArticuloPorSubastar;
            }

        }
        public void ActualizarPostorGanador(Subasta subasta)
        {
            Subasta sub = ObtenerPoridSubasta(subasta.idDeSubasta);

            if (sub != null)
            {
                sub.PostorGanador = subasta.PostorGanador;
            }

        }
    }
}

