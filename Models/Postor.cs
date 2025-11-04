using system;

namespace ProyectoSubastasWinForms_NET8.Models
{

    //Atributos de la clase Postor

    public class Postor
    {
        public int Id;
        public string Apellido;
        public string Correo;
        public string Contrasenia;

//Constructor 

        public Postor(int id, string apellido, string correo, string contrasenia)
        {
            Id = id;
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
