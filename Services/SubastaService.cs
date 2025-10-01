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

        public SubastaService(SubastaRepository repo)
        {
            repository = repo;
        }

        public List<Subasta> ObtenerSubastas()
        {
            return repository.ObtenerTodos();
        }

        public void AgregarSubasta(Subasta subasta)
        {
            repository.Agregar(subasta);
        }

        public int ObtenerNuevoId()
        {
            return repository.ObtenerNuevoId();
        }

        public void RegistrarPuja(Subasta subasta, Postor postor, decimal monto)
        {
            if (subasta.Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");

            var pujaActual = subasta.ObtenerPujaActual();

            if (monto < pujaActual + subasta.PujaAumento)
                throw new InvalidOperationException($"El monto debe ser al menos {pujaActual + subasta.PujaAumento}");

            var oferta = new Oferta(postor, monto);
            subasta.Ofertas.Add(oferta);

            if (!subasta.Postores.Contains(postor))
                subasta.Postores.Add(postor);
        }
    }
}
