using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoSubastasWinForms_NET8.Exceptions;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Subasta
    {
        public int Id { get; }
        public string Articulo { get; }
        public string Subastador { get; }
        public decimal PujaInicial { get; }
        public decimal Incremento { get; }
        public TimeSpan Duracion { get; }
        public SubastaEstado Estado { get; private set; } = SubastaEstado.Pendiente;
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        public Postor Ganador { get; private set; }

        private readonly List<Puja> pujas = new();
        private readonly List<Postor> postores = new();

        // Constructor
        public Subasta(int id, string articulo, string subastador, decimal pujaInicial, decimal incremento, TimeSpan duracion)
        {
            if (duracion <= TimeSpan.Zero)
                throw new ArgumentException("La duración debe ser mayor a cero.", nameof(duracion));

            Id = id;
            Articulo = articulo ?? throw new ArgumentNullException(nameof(articulo));
            Subastador = subastador ?? throw new ArgumentNullException(nameof(subastador));
            PujaInicial = pujaInicial;
            Incremento = incremento;
            Duracion = duracion;
            
        }


        // Iniciar subasta
        public void Iniciar()
        {
            if (Estado != SubastaEstado.Pendiente)
                throw new InvalidOperationException("La subasta ya fue iniciada o finalizada.");

            Estado = SubastaEstado.EnCurso;
            FechaInicio = DateTime.Now;
            FechaFin = FechaInicio.Add(Duracion);
        }

        // Finalizar subasta
        public void Finalizar()
        {
            if (Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");

            Estado = SubastaEstado.Finalizada;
            Ganador = ObtenerPostorGanador();
        }

        // Registrar postores
        public void AgregarPostor(Postor postor)
        {
            if (postor == null)
                throw new ArgumentNullException(nameof(postor));

            if (!postores.Any(p => p.Dni == postor.Dni))
                postores.Add(postor);
        }

        // Registrar puja
        public void RegistrarPuja(Postor postor, decimal monto)
        {
            if (Estado != SubastaEstado.EnCurso)
                throw new SubastaNoEnCursoException();

            if (!postores.Any(p => p.Dni == postor.Dni))
                throw new PostorInvalidoException();

            decimal montoMinimo = pujas.Any() ? pujas.Max(p => p.Monto) + Incremento : PujaInicial;

            if (monto < montoMinimo)
                throw new PujaInvalidaException($"La puja debe ser al menos {montoMinimo}.");

            pujas.Add(new Puja(postor, monto));
        }

        // Obtener la puja actual
        public decimal ObtenerPujaActual()
        {
            return pujas.OrderByDescending(p => p.Monto).FirstOrDefault()?.Monto ?? PujaInicial;
        }


        // Obtener postor ganador
        public Postor ObtenerPostorGanador()
        {
            return pujas.OrderByDescending(p => p.Monto).FirstOrDefault()?.Postor;
        }

        // Exponer colecciones como solo lectura
        public IReadOnlyCollection<Puja> Pujas => pujas.AsReadOnly();
        public IReadOnlyCollection<Postor> PostoresRegistrados => postores.AsReadOnly();

        // Actualizar estado según la fecha
        public void ActualizarEstado(DateTime ahora)
        {
            if (Estado == SubastaEstado.Finalizada) return;

            if (ahora >= FechaInicio.Add(Duracion))
                Estado = SubastaEstado.Finalizada;
            else if (ahora >= FechaInicio)
                Estado = SubastaEstado.EnCurso;
            else
                Estado = SubastaEstado.Pendiente;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Artículo: {Articulo} | Subastador: {Subastador} | Puja inicial: ${PujaInicial:0.00} | Estado: {Estado}";
        }
        
    }
}
