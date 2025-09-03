using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class PostorController
    {
        private List<Postor> postores = new List<Postor>();

        public bool AgregarPostor(int dni, string nombre, string apellido)
        {
            if (postores.Exists(p => p.Dni == dni))
                return false;

            Postor p = new Postor(dni, nombre, apellido);
            postores.Add(p);
            return true;
        }

        public bool ModificarPostor(int dni, string nombre, string apellido)
        {
            Postor p = postores.Find(x => x.Dni == dni);
            if (p == null) return false;

            p.Nombre = nombre;
            p.Apellido = apellido;
            return true;
        }

        public bool EliminarPostor(int dni)
        {
            Postor p = postores.Find(x => x.Dni == dni);
            if (p == null) return false;

            postores.Remove(p);
            return true;
        }

        public List<Postor> ObtenerPostores()
        {
            return postores;
        }
    }
}
