using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Services;
using System;

namespace ProyectoSubastasWinForms_NET8.Controllers
{
    public class SubastadorController
    {
        private readonly SubastadorService service;

        public SubastadorController()
        {
            service = new SubastadorService(); 
        }
     
        public Subastador ObtenerSubastadorPorcorreo(string correo)
        {
            return service.ObtenerSubastador(correo);
        }


        public Subastador AgregarSubastador(string correo, string nombre)
        {
            Subastador subastador = new Subastador(correo, nombre);

            bool ok = service.RegistrarSubastador(subastador);

            return ok ? subastador : null;
        }


        public bool EliminarSubastador(string correo)
        {
            return service.Eliminar(correo);
        }

        public bool ModificarSubastador(string correo, string nombre)
        {
            Subastador subastador = new Subastador(correo, nombre);
            subastador.correo = correo;
            subastador.nombre = nombre;
            return service.ModificarSubastador(subastador);
        }
    }
}