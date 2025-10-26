using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Repository
{
    public class SubastadorRepository
    {
        private int siguienteId = 1;
        private static readonly List<Subastador> subastadores = new List<Subastador>();
        private static readonly SubastadorRepository instancia = new SubastadorRepository();
        public static SubastadorRepository Instancia => instancia;
        private SubastadorRepository() { }

        public List<Subastador> ObtenerTodos()
        {
            return subastadores;
        }
        public Subastador ObtenerPorcorreo(string correo)
        {
            for (int i = 0; i < subastadores.Count; i++)
            {
                if (subastadores[i].correo == correo)
                {
                    return subastadores[i];
                }
            }

            return null;
        }
        
        public void Agregar(Subastador subastador)
        {
            subastador.Id = siguienteId++;
            subastadores.Add(subastador);
            MessageBox.Show($"Subastador agregado: {subastador.correo}");
        }

        public void Eliminar(string correo)
        {
            int indice = -1;
            for (int i = 0; i < subastadores.Count; i++)
            {
                if (subastadores[i].correo == correo)
                {
                    indice = i;
                    break;
                }
            }
            if (indice >= 0)
            {
                subastadores.RemoveAt(indice);
            }
        }

        public void ModificarSubastador(Subastador subastador)
        {
            for (int i = 0; i < subastadores.Count; i++)
            {
                if (subastadores[i].correo == subastador.correo)
                {
                    subastadores[i].nombre = subastador.nombre;
                    break;
                }
            }
        }
    }
}
