using ProyectoSubastasWinForms_NET8.Models;
using System.Collections.Generic;
using System;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class PostorController
    {
        private List<Postor> postores = new List<Postor>();

        public bool AgregarPostor(int dni, string nombre, string apellido, string email, decimal monto)
        {
            if (!postores.Exists(p => p.Dni == dni))
            {
                Postor p = new Postor(dni, nombre, apellido, email, monto);    
                postores.Add(p);
                return true;
            }

            return false;
        }

        public bool ModificarPostor(int dni, string nombre, string apellido, string email)
        {
            Postor p = postores.Find(x => x.Dni == dni);
            if (p == null) return false;

            p.Nombre = nombre;
            p.Apellido = apellido;
            p.Email = email;
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
