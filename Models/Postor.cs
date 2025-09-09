using System;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Dni { get; set; }      
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public double Monto { get; set; }   

        public Postor(int dni, string nombre, string apellido, string email)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            
        }

        public void Participar(Subasta subasta)
        {
        
        }

        public void Pujar(Subasta subasta, decimal monto)
        {  
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

    }
}
