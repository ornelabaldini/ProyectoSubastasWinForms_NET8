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
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void IniciarSubasta(int subastaId)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new KeyNotFoundException("Subasta no encontrada.");
            subasta.Iniciar();
        }

        public void FinalizarSubasta(int subastaId)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new KeyNotFoundException("Subasta no encontrada.");
            subasta.Finalizar();
        }

        public void AgregarPostor(int subastaId, Postor postor)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new KeyNotFoundException("Subasta no encontrada.");
            subasta.AgregarPostor(postor);
        }

        public void RegistrarPuja(int subastaId, Postor postor, decimal monto)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new KeyNotFoundException("Subasta no encontrada.");
            subasta.RegistrarPuja(postor, monto);
        }

        public Puja CalcularGanador(int subastaId)
        {
            var subasta = repository.ObtenerPorId(subastaId) ?? throw new KeyNotFoundException("Subasta no encontrada.");
            return subasta.CalcularGanador();
        }

        public void ActualizarEstadoSubastas()
        {
            var ahora = DateTime.Now;
            foreach (var subasta in repository.ObtenerTodas())
            {
                subasta.ActualizarEstado(ahora);
            }
        }
    }
}
