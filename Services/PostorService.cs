using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Repository;
using System.Collections.Generic;

namespace ProyectoSubastasWinForms_NET8.Services
{
    public class PostorService
    {
        private readonly PostorRepository repository;

        public PostorService(PostorRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IReadOnlyCollection<Postor> ObtenerPostores() => repository.ObtenerTodos();

        public void CrearPostor(Postor postor)
        {
            repository.AgregarPostor(postor);
        }

        public void ReemplazarPostor(Postor postor)
        {
            repository.ReemplazarPostor(postor);
        }

        public void EliminarPostor(int dni)
        {
            repository.EliminarPostor(dni);
        }
    }
}
