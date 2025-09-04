using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class PostorRepository
    {
        private readonly List<Postor> postores;

        public PostorRepository()
        {
            postores = new List<Postor>();
        }

        public List<Postor> ObtenerTodos() => postores;

        public Postor ObtenerPorDni(int dni) => postores.FirstOrDefault(p => p.Dni == dni);

        public void AgregarPostor(Postor postor) => postores.Add(postor);

        public void ModificarPostor(Postor postor)
        {
            var existente = postores.FirstOrDefault(p => p.Dni == postor.Dni);
            if (existente != null)
            {
                existente.Nombre = postor.Nombre;
                existente.Email = postor.Email;
            }
        }

        public void EliminarPostor(int dni)
        {
            var postor = postores.FirstOrDefault(p => p.Dni == dni);
            if (postor != null)
                postores.Remove(postor);
        }
    }
}
