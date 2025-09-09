using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Repository;
using System.Collections.Generic;

namespace ProyectoSubastasWinForms_NET8.Services
{
    public class PostorService
    {
        private readonly PostorRepository repository;

        public PostorService()
        {
            repository = new PostorRepository();
        }

       
        public bool CrearPostor(Postor postor)
        {
            Postor existente = repository.ObtenerPorDni(postor.Dni);
            if (existente != null)
            {
                return false;
            }
            repository.AgregarPostor(postor);
            return true;
        }

        public bool ModificarPostor(Postor postor)
        {
            Postor existente = repository.ObtenerPorDni(postor.Dni);
            if (existente == null)
            {
                return false;
            }
            repository.ModificarPostor(postor);
            return true;
        }

        public bool EliminarPostor(int dni)
        {
            Postor existente = repository.ObtenerPorDni(dni);
            if (existente == null)
            {
                return false;
            }
            repository.EliminarPostor(dni);
            return true;
        }

        public List<Postor> ObtenerPostores()
        {
            return repository.ObtenerTodos();
        }
    }
}
