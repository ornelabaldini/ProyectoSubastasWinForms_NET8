using ProyectoSubastasWinForms_NET8.Models.enums;
using System;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public decimal Monto { get; set; } 


        public Postor(int dni, string nombre, string apellido, string email, decimal monto)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Monto = monto;  
        }
        public void Participar(Subasta subasta)
        {
            if (subasta.Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");
        }
        public void RealizarPuja(Subasta subasta, decimal monto)
        {
            if (subasta.Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("No se puede pujar en una subasta que no está en curso.");
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

    }
}
