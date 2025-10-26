using system;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public string Correo;
        public string Contrasenia;


        public Postor(int id, string nombre, string apellido, string correo, string contrasenia)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contrasenia = contrasenia;
        }

        
    
        // Propiedades
        public int Id
        {
            get { return id; }
            internal set { id = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public string Contrasenia
        {
            get { return Contrasenia; }
            set { Contrasenia = value; }
        }

        //Fin propiedades

    } 
}
