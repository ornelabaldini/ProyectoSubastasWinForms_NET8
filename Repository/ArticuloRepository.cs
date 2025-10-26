using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Repository
{
   public class ArticuloRepository
    {
        private readonly List<Articulo> articulos;
        private int siguienteId = 1;

        public ArticuloRepository()
        {
            articulos = new List<Articulo>();
        }
        public void Agregar(Articulo articulo)
        {
            articulo.idArticulo = siguienteId++;
            articulos.Add(articulo);
        }
        public List<Articulo> ObtenerTodos()
        {
            return articulos;
        }
        public Articulo ObtenerPoridArticulo(int numoeroArticulo)
        {
            for (int i = 0; i < articulos.Count; i++)
            {
                if (articulos[i].idArticulo == numoeroArticulo)
                {
                    return articulos[i];
                }
            }

            return null;
        }
        

        public void Eliminar(int idArticulo)
        {
            int indice = -1;
            for (int i = 0; i < articulos.Count; i++)
            {
                if (articulos[i].idArticulo == idArticulo)
                {
                    indice = i;
                    break;
                }
            }
            if (indice >= 0)
            {
                articulos.RemoveAt(indice);
            }
        }

        public bool ActualizarNombre(Articulo articulo, string nuevoNombre)
        {
            articulo.nombre = nuevoNombre;
            return true;
        }

        public bool ActualizarDetalle(Articulo articulo, string nuevoDetalle)
        {
            articulo.Detalle = nuevoDetalle;
            return true;
        }

    }
}
