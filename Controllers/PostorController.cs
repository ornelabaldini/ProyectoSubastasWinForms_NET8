using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System;

namespace ProyectoSubastasWinForms_NET8.Controllers
{

    public class PostorController
    {
        private readonly PostorService service; //// Servicio de Postor usado por la clase, inicializado solo una vez (readonly)

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

        public bool AgregarPostor(string correo, string apellido)
        {
            Postor postor = new Postor(correo, apellido);
            postor.correo = correo;
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

        public bool ModificarApellidoPostor(int id, string nuevoApellido)
        {
            return service.ModificarApellidoPostor(id, nuevoApellido);
        }
        public bool ModificarcorreoPostor(int id, string nuevoCorreo)
        {
            return service.ModificarcorreoPostor(id, nuevoCorreo);
        }

        public List<Subasta> ObtenerSubastas()
        {
            return AppContext.SubastaController.ObtenerSubastas();
        }

    }
}