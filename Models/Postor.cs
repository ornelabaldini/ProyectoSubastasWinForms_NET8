using System;
using System.Linq;
using ProyectoSubastasWinForms_NET8.Exceptions;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Dni { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public string Email { get; }

        public Postor(int dni, string nombre, string apellido, string email)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre es obligatorio.", nameof(nombre));
            if (string.IsNullOrWhiteSpace(apellido)) throw new ArgumentException("El apellido es obligatorio.", nameof(apellido));
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("El email es obligatorio.", nameof(email));

            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }

        public void Participar(Subasta subasta)
        {
            if (subasta.Estado != SubastaEstado.EnCurso)
                throw new SubastaNoEnCursoException();

            if (subasta.PostoresRegistrados.Any(p => p.Dni == Dni))
                throw new PostorInvalidoException("El postor ya está participando en esta subasta.");
        }

        public void RealizarPuja(Subasta subasta, decimal monto)
        {
            subasta.RegistrarPuja(this, monto); // delega toda la lógica a Subasta
        }
    }
}
