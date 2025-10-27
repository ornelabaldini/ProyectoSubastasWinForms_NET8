using System;
using System.Collections.Generic;
using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Models.enums;
using ProyectoSubastasWinForms_NET8.Repository;

namespace ProyectoSubastasWinForms_NET8.Services
{
    public class SubastaService
    {
        private readonly SubastaRepository repository;
        public SubastaService() 
        {
            repository = new SubastaRepository();
        }
        public Subasta ObtenerPoridSubasta(int idSubasta)
        {
            return repository.ObtenerPoridSubasta(idSubasta);
        }

        public bool RegistrarSubasta(Subasta nuevaSubasta)
        {

            if (nuevaSubasta == null || nuevaSubasta.ArticuloPorSubastar == null || nuevaSubasta.Subastador == null)
                return false;
            if (nuevaSubasta.getPrecioBase < 0)
                throw new ArgumentException("La puja inicial debe ser mayor a 0");
            
            repository.Agregar(nuevaSubasta); 
            return true;
        }

        public List<Subasta> ObtenerSubastas() 
        {
            return repository.ObtenerTodos();
        }

        public bool EliminarSubasta(int idSubasta)
        {
            Subasta existente = repository.ObtenerPoridSubasta(idSubasta);
            if (existente == null)
            { return false; }
            repository.Eliminar(idSubasta);
            return true;
        }

        public bool ModificarSubasta(Subasta subasta)
        {
            Subasta existente = repository.ObtenerPoridSubasta(subasta.idDeSubasta);
            if (existente == null)
            {
                return false;
            }
            repository.ModificarSubasta(subasta);
            return true;
        }

        public bool ActualizarPostorGanador(Subasta subasta)
        {
            Subasta existente = repository.ObtenerPoridSubasta(subasta.idDeSubasta);
            if (existente == null)
            {
                return false;
            }
            repository.ActualizarPostorGanador(subasta);
            return true;
        }

        
        public Subasta ObtenerPorid(int idSubasta)
        {
            return repository.ObtenerPoridSubasta(idSubasta);
        }

    }
}
