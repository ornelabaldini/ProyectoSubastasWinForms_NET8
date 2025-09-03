namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Postor
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";

        public Postor(int dni, string nombre, string apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
