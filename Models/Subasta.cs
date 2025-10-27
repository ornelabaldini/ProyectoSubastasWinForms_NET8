using ProyectoSubastasWinForms_NET8.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Subasta
    {
        private int Id { get; set; }
        private decimal precioBase { get; set; }
        private decimal montoActual { get; }
        private decimal pujaAumento { get; set; }
        private Articulo articulo { get; set; }
        private Subastador subastador { get; set; }
        private DateTime fechaHoraInicio { get; set; }
        private readonly TimeSpan duracion { get; set; }
        private SubastaEstado estado { get; set; }
        private List<Postor> postores { get; set; } = new List<Postor>();
        private Postor ganador { get; set; }
        private contadorPujas  int { get; set; } = 0;
    

        public Subasta(int id, string articulo, string subastador, decimal precioBase, decimal pujaAumento, TimeSpan duracion)
        {
            Id = id;
            Articulo = articulo;
            Subastador = subastador;
            precioBase = precioBase;
            PujaAumento = pujaAumento;
            Duracion = TimeSpan.FromHours(24);
            Estado = SubastaEstado.Programada;
            Postores = new List<Postor>();
            MontoActual = montoActual;
            Ganador = null;
            contadorPujas = 0;
        }
        
        public decimal getPrecioBase(){
            return precioBase;
        }

        public decimal setPrecioBase(decimal precioBase){
            this.precioBase = precioBase;
        }
          public decimal PujaAumento
        {
            get { return pujaAumento; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La puja de aumento debe ser mayor a cero.");
                pujaDeAumento = value;
            }
        }

        //Metodos 

        public void Iniciar()
        {
            if (Estado != SubastaEstado.Programada)
                throw new InvalidOperationException("La subasta ya fue iniciada o finalizada.");

            Estado = SubastaEstado.EnCurso;
            FechaInicio = DateTime.Now;
            FechaFin = FechaInicio.Add(Duracion);
        }

        public void Finalizar()
        {
            if (Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");

            var pujaGanadora = CalcularGanador();

            if (pujaGanadora != null)
            {
                Ganador = pujaGanadora;
            }

            Estado = SubastaEstado.Finalizada;
        }

        public void AgregarPuja(Postor p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p), "El postor no puede ser nulo."); 
            if (Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("No se pueden agregar pujas a una subasta que no está en curso.");
        }

        public Postor CalcularGanador()
        {
            if (Postores == null || Postores.Count == 0)
                return null;

            return Postores.OrderByDescending(p => p.Monto).FirstOrDefault();
        }

        public Postor OfertaGanadora => CalcularGanador();

        public decimal ObtenerPujaActual()
        {
            var ganadora = CalcularGanador();
            return ganadora?.Monto ?? precioBase;
        }

        public Postor ObtenerPostorGanador()
        {
            return CalcularGanador();
        }

        public override string ToString()
        {
            return $"ID: {Id} | Artículo: {Articulo} | Subastador: {Subastador} | Puja inicial: ${precioBase:0.00} | Estado: {Estado}";
        }

        public void ActualizarEstado(DateTime fechaActual)
        {
            if (Estado == SubastaEstado.EnCurso && fechaActual >= FechaFin)
            {
                Finalizar();
            }
        }

        //+ IncrementarContadorPuja(): void
    }
}
