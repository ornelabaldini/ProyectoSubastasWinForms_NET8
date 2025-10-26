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
        
        public bool RegistrarPostor(Postor nuevoPostor)
        {
            Postor existente = repository.ObtenerPorId(nuevoPostor.Id);
            if (existente != null)
            {
                return false;
            }
            repository.Agregar(nuevoPostor);
            return true;
        }
        public Postor ObtenerPostor(int id)
        {
            return repository.ObtenerPorId(id);
        }
        public List<Postor> ObtenerTodos()
        {
            return repository.ObtenerTodos();
        }

        public bool EliminarPostor(int idSeleccionado)
        {
            Postor existente = repository.ObtenerPorId(idSeleccionado);
            if (existente == null)
                return false;

            repository.EliminarPorId(idSeleccionado);
            return true;
        }

        public bool ModificarNombrePostor(int id, string nuevoNombre)
        {
            var postor = repository.ObtenerPorId(id);
            if (postor == null) return false;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            return repository.ActualizarNombre(postor, nuevoNombre);
        }
        public bool ModificarcorreoPostor(int id, string nuevocorreo)
        {
            var postor = repository.ObtenerPorId(id);
            if (postor == null) return false;

            if (string.IsNullOrWhiteSpace(nuevocorreo))
                throw new ArgumentException("El nombre no puede estar vacío.");

            return repository.Actualizarcorreo(postor, nuevocorreo);
        }

        public Postor ObtenerPorId(int id)
        {
            return repository.ObtenerPorId(id);
        }

    }
}
