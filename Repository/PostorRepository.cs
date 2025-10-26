using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class PostorRepository
    {
        private readonly List<Postor> postores;
        private int siguienteId = 1;
        public PostorRepository()
        {
            postores = new List<Postor>();
        }
        public List<Postor> ObtenerTodos()
        {
            return postores;
        }
        public Postor ObtenerPorId(int id)
        {
            return postores.FirstOrDefault(p => p.Id == id);
        }

        public bool ActualizarNombre(Postor postor, string nuevoNombre)
        {
            postor.nombre = nuevoNombre;
            return true;
        }
        public bool Actualizarcorreo(Postor postor, string nuevocorreo)
        {
            postor.correo = nuevocorreo;
            return true;
        }
        public void Agregar(Postor postor)
        {
            postor.Id = siguienteId++;
            postores.Add(postor);
        }

        public void EliminarPorId(int idSeleccionado)
        {
            int indice = -1;
            for (int i = 0; i < postores.Count; i++)
            {
                if (postores[i].Id == idSeleccionado)
                {
                    indice = i;
                    break;
                }
            }
            if (indice >= 0)
            {
                postores.RemoveAt(indice);
            }
        }

    }

}