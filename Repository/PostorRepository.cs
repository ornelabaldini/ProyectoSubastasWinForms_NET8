using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class PostorRepository
    {
        private readonly List<Postor> postores;

        public PostorRepository()
        {
            postores = new List<Postor>();
        }

        public List<Postor> ObtenerTodos()
        {
            return postores;
        }

        public Postor ObtenerPorDni(int dni)
        {
            /*foreach(Postor c in postores){
                if (c.Dni == dni)
                {
                    return c;
                }
                else return null;
            } */

            for (int i = 0; i < postores.Count; i++)
            {
                if (postores[i].Dni == dni)
                {
                    return postores[i];
                }
            }

            return null;
        }

        public void Agregar(Postor postor)
        {
            postores.Add(postor);
        }

        public void Modificar(Postor postor)
        {
            for (int i = 0; i < postores.Count; i++)
            {
                if (postores[i].Dni == postor.Dni)
                {
                    postores[i].Nombre = postor.Nombre;
                    postores[i].Apellido = postor.Apellido;
                    break;
                }
            }
        }

        public void Eliminar(int dni)
        {
            int indice = -1;
            for (int i = 0; i < postores.Count; i++)
            {
                if (postores[i].Dni == dni)
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
