using system;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Articulo
    {
        private int idArticulo;
        string nombre;
        string descripcion;
        string estadoArticulo;

        public Articulo(string name, string detalle, string estadoArticulo)
        {
            Name = name;
            Detalle = detalle;
            this.estadoArticulo = estadoArticulo;

        }

        public string Nombre

        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion

        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int idArticulo
        {
            get { return idArticulo; }
            internal set { idArticulo = value; }
        }

        public string estadoArticulo

        {
            get { return estadoArticulo; }
            set { estadoArticulo = value; }
        }
    }
}
