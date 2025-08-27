using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Services;
using System.Collections.Generic;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class PostorController
    {
        private readonly PostorService service;

        public PostorController()
        {
            service = new KundeServiceAdapter();
        }

        // Adaptador simple para mantener nombres claros en MainForm
        private class KundeServiceAdapter : PostorService { }

        public List<Postor> ObtenerPostores()
        {
            return service.ObtenerPostores();
        }

        public bool AgregarPostor(int dni, string nombre, string apellido)
        {
            Postor p = new Postor();
            p.Dni = dni;
            p.Nombre = nombre;
            p.Apellido = apellido;

            return service.CrearPostor(p);
        }

        public bool ModificarPostor(int dni, string nombre, string apellido)
        {
            Postor p = new Postor();
            p.Dni = dni;
            p.Nombre = nombre;
            p.Apellido = apellido;
            return service.ModificarPostor(p);
        }

        public bool EliminarPostor(int dni)
        {
            return service.EliminarPostor(dni);
        }
    }
}
