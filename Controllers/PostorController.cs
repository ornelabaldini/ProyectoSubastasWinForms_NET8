using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System;

namespace ProyectoSubastasWinForms_NET8.Controllers
{

    public class PostorController
    {
        private readonly PostorService service;

        public PostorController()
        {
            service = new KundeServiceAdapter();
        }
        private class KundeServiceAdapter : PostorService;

        public List<Postor> ObtenerPostores()
        {
            return service.ObtenerTodos();
        }
        public Postor ObtenerPostor(int id)
        {
            return service.ObtenerPostor(id);
        }

        public bool AgregarPostor(string correo, string nombre)
        {
            Postor postor = new Postor(correo, nombre);
            postor.correo = correo;
            postor.nombre = nombre;
            return service.RegistrarPostor(postor);
        }
        public bool Pujar(int numeroSubasta, int idPostor)
        {
            Postor postor = service.ObtenerPorId(idPostor);
            if (postor == null) return false;

            return AppContext.SubastaController.RegistrarPostorGanador(numeroSubasta, postor);
        }


        public bool EliminarPostor(int idSeleccionado)
        {
            return service.EliminarPostor(idSeleccionado);
        }

        public bool ModificarNombrePostor(int id, string nuevoNombre)
        {
            return service.ModificarNombrePostor(id, nuevoNombre);
        }
        public bool ModificarcorreoPostor(int id, string nuevoMail)
        {
            return service.ModificarcorreoPostor(id, nuevoMail);
        }

        public List<Subasta> ObtenerSubastas()
        {
            return AppContext.SubastaController.ObtenerSubastas();
        }

    }
}