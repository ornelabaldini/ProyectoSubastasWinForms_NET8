using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Subastador
    {
        private int id;
        private string correo;
        private string nombre;

        public Subastador(string correo, string nombre)
        {
            this.correo = correo;
            this.nombre = nombre;
        }
        public string correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Id
        {
            get { return id; }
            internal set { id = value; } 
        }
    }
}