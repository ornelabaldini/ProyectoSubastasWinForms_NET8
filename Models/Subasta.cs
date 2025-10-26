using ProyectoSubastasWinForms_NET8.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Subasta
    {
        internal int Id { get; set; }
        public decimal PujaInicial;
        public decimal montoActual { get; }
        public decimal PujaAumento { get; set; }
        Articulo Articulo { get; set; }
        Subastador Subastador { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        readonly Timespan Duracion { get; set; }
        public SubastaEstado Estado { get; private set; }
        public List<Postor> Postores { get; set; } = new List<Postor>();
        public Postor Ganador { get; set; }


        public Subasta(int id, string articulo, string subastador, decimal pujaInicial, decimal pujaAumento, TimeSpan duracion)
        {
            Id = id;
            Articulo = articulo;
            Subastador = subastador;
            PujaInicial = pujaInicial;
            PujaAumento = pujaAumento;
            Duracion = TimeSpan.FromHours(24);
            Estado = SubastaEstado.Programada;
            Postores = new List<Postor>();
            this.montoActual = montoActual;
            this.Ganador = null;
        }
        
        //Propiedades condicionales

        public decimal PujaInicial
        {
            get { return pujaInicial; }
            set
            {
                if (value < 1000 || value % 1000 != 0)
                    throw new ArgumentException("La puja inicial debe ser mayor o igual a 500.");
                pujaInicial = value;
            }
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

        //Fin propiedades

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
            return ganadora?.Monto ?? PujaInicial;
        }

        public Postor ObtenerPostorGanador()
        {
            return CalcularGanador();
        }

        public override string ToString()
        {
            return $"ID: {Id} | Artículo: {Articulo} | Subastador: {Subastador} | Puja inicial: ${PujaInicial:0.00} | Estado: {Estado}";
        }

        public void ActualizarEstado(DateTime fechaActual)
        {
            if (Estado == SubastaEstado.EnCurso && fechaActual >= FechaFin)
            {
                Finalizar();
            }
        }
    }
}
