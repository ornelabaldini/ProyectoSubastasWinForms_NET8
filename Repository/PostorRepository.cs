using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class PostorRepository
    {
        private readonly List<Postor> postores = new();

        public IReadOnlyCollection<Postor> ObtenerTodos() => postores.AsReadOnly();

        public Postor ObtenerPorDni(int dni) => postores.FirstOrDefault(p => p.Dni == dni);

        public void AgregarPostor(Postor postor)
        {
            if (postor == null) throw new ArgumentNullException(nameof(postor));
            if (postores.Any(p => p.Dni == postor.Dni))
                throw new InvalidOperationException("Ya existe un postor con ese DNI.");

            postores.Add(postor);
        }

        public void ReemplazarPostor(Postor postor)
        {
            if (postor == null) throw new ArgumentNullException(nameof(postor));

            var index = postores.FindIndex(p => p.Dni == postor.Dni);
            if (index == -1) throw new KeyNotFoundException("No se encontró el postor.");

            postores[index] = postor;
        }

        public void EliminarPostor(int dni)
        {
            var postor = postores.FirstOrDefault(p => p.Dni == dni);
            if (postor != null)
                postores.Remove(postor);
        }
    }
}
