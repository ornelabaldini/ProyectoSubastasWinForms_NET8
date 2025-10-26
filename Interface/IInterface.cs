using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Interfaces
{
    public interface IInterface
    {
        public bool Eliminar(string correo);
        public object Agregar(string correo, string nombre);
        public bool Modificar(string correo, string nombre);
    }
}
