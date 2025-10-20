using ProyectoSubastasWinForms_NET8.Models.enums;
using System;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; } 


        public Postor(int id, string nombre, string apellido, string correo, string contrasenia)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contrasenia = contrasenia;
        }


/*----------------------------------*/

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

    }
}
