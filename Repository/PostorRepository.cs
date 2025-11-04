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
            return postores.FirstOrDefault(p => p.Id == id); // Devuelve null si no se encuentra
        }

        public bool ActualizarApellido(Postor postor, string nuevoApellido)
        {
            postor.apellido = nuevoApellido;
            return true;
        }
        public bool Actualizarcorreo(Postor postor, string nuevocorreo)
        {
            postor.correo = nuevocorreo;
            return true;
        }
        public void Agregar(Postor postor)
        {
            postor.Id = siguienteId++; // Asigna el Id y luego incrementa para el siguiente
            postores.Add(postor);
        }

// Eliminar un postor por su Id
        public void EliminarPorId(int idSeleccionado)
        {
            int indice = -1;
            for (int i = 0; i < postores.Count; i++) // Bucle para encontrar el índice del postor con el Id dado
            {
                // Comparar el Id del postor en la posición i con el idSeleccionado
                if (postores[i].Id == idSeleccionado) 
                {
                    indice = i;
                    break;
                }
            }
            if (indice >= 0)
            {
                postores.RemoveAt(indice); // Eliminar el postor en el índice encontrado
            }
        }

    }

}