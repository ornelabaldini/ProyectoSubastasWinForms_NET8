using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Repository;
using System.Collections.Generic;

//Inicio de la clase PostorService

namespace ProyectoSubastasWinForms_NET8.Services
{
    //Constructores
    public class PostorService
    {
        private readonly PostorRepository repository;
        public PostorService()
        {
            repository = new PostorRepository();
        }

        // Registrar un nuevo postor
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

        // Obtener un postor por su ID
        public Postor ObtenerPostor(int id)
        {
            return repository.ObtenerPorId(id);
        }

        // Obtener todos los postores registrados
        public List<Postor> ObtenerTodos()
        {
            return repository.ObtenerTodos();
        }

        // Eliminar un postor por su ID
        public bool EliminarPostor(int idSeleccionado)
        {
            Postor existente = repository.ObtenerPorId(idSeleccionado);
            if (existente == null)
                return false;

            repository.EliminarPorId(idSeleccionado);
            return true;
        }

        // Modificar A de un postor existente
        public bool ModificarApellidoPostor(int id, string nuevoApellido)
        {
            var postor = repository.ObtenerPorId(id);
            if (postor == null) return false;

            if (string.IsNullOrWhiteSpace(nuevoApellido)) // Validar que el nuevo apellido no esté vacío
                throw new ArgumentException("El Apellido no puede estar vacío.");

            return repository.Actualizarapellido(postor, nuevoApellido);
        }

        // Modificar el correo de un postor existente
        public bool ModificarcorreoPostor(int id, string nuevocorreo)
        {
            var postor = repository.ObtenerPorId(id);
            if (postor == null) return false; // Verificar si el postor existe

            if (string.IsNullOrWhiteSpace(nuevocorreo))
                throw new ArgumentException("El apellido no puede estar vacío.");

            return repository.Actualizarcorreo(postor, nuevocorreo);
        }

        // Obtener un postor por su ID (método adicional)
        public Postor ObtenerPorId(int id)
        {
            return repository.ObtenerPorId(id);
        }

    }
}
//Fin de la clase PostorService