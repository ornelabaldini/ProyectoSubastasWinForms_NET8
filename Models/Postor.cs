using System;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Dni { get; set; }       // Identificador único del postor
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Postor(int dni, string nombre, string email)
        {
            Dni = dni;
            Nombre = nombre;
            Email = email;
        }

        public void Participar(Subasta subasta)
        {
            if (subasta.Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");

            if (subasta.PujaList.Exists(p => p.Postor.Dni == this.Dni))
                throw new InvalidOperationException("El postor ya está participando en esta subasta.");
        }

        public void RealizarPuja(Subasta subasta, decimal monto)
        {
            if (subasta.Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("No se puede pujar en una subasta que no está en curso.");

            Puja puja = new Puja(this, monto);
            subasta.AgregarPuja(puja);
        }
    }
}
