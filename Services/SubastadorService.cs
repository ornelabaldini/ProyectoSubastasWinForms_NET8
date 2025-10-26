using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSubastasWinForms_NET8.Services
{
    public class SubastadorService
    {
        private readonly SubastadorRepository repository;

        public SubastadorService()
        {
            repository = SubastadorRepository.Instancia;
        }
        //La siguiente funcion chequea si existe un subastador ya creado con ese mail y retorna T o F segun.
        public bool RegistrarSubastador(Subastador nuevoSubastador)
        {
            Subastador existente = repository.ObtenerPorcorreo(nuevoSubastador.correo);
            if (existente != null)
            {
                //Ya existe un subastador con ese correo
                return false;
            }
            repository.Agregar(nuevoSubastador);
            return true;
        }
        public Subastador ObtenerSubastador(string correo) 
        {
            return repository.ObtenerPorcorreo(correo);
        }

        public bool Eliminar(string correo)
        {
            Subastador existente = repository.ObtenerPorcorreo(correo);
            if (existente == null)
            { return false; }
            repository.Eliminar(correo);
            return true;
        }

        public bool ModificarSubastador(Subastador subastador)
        {
            Subastador existente = repository.ObtenerPorcorreo(subastador.correo);
            if (existente == null)
            {
                return false;
            }
            repository.ModificarSubastador(subastador);
            return true;
        }
    }
}


