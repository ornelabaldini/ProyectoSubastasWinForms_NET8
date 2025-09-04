using System;
using ProyectoSubastasWinForms_NET8.Models;
using ProyectoSubastasWinForms_NET8.Repository;

namespace ProyectoSubastasWinForms_NET8.Services
{
    public class SubastaService
    {
        private readonly SubastaRepository repository;

        public SubastaService(SubastaRepository repository)
        {
            this.repository = repository;
        }

        public void IniciarSubasta(int subastaId)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new InvalidOperationException("Subasta no encontrada.");
            subasta.Iniciar();
        }

        public void FinalizarSubasta(int subastaId)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new InvalidOperationException("Subasta no encontrada.");
            subasta.Finalizar();
        }

        public Puja CalcularGanador(int subastaId)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new InvalidOperationException("Subasta no encontrada.");
            return subasta.CalcularGanador();
        }
    }
}
