using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Subasta
    {
        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Subastador { get; set; }
        public decimal PujaInicial { get; set; }
        public decimal Incremento { get; set; }
        public TimeSpan Duracion { get; set; }
        public SubastaEstado Estado { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        public List<Puja> PujaList { get; private set; }
        public List<Postor> Postores { get; set; } = new List<Postor>();
        public Postor Ganador { get; set; }



        public Subasta(int id, string articulo, string subastador, decimal pujaInicial, decimal incremento, TimeSpan duracion)
        {
            Id = id;
            Articulo = articulo;
            Subastador = subastador;
            PujaInicial = pujaInicial;
            Incremento = incremento;
            Duracion = duracion;
            Estado = SubastaEstado.Pendiente;
            PujaList = new List<Puja>();
            Postores = new List<Postor>();
        }

        public void Iniciar()
        {
            if (Estado != SubastaEstado.Pendiente)
                throw new InvalidOperationException("La subasta ya fue iniciada o finalizada.");

            Estado = SubastaEstado.EnCurso;
            FechaInicio = DateTime.Now;
            FechaFin = FechaInicio.Add(Duracion);
        }

        public void Finalizar()
        {
            if (Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("La subasta no está en curso.");

            Estado = SubastaEstado.Finalizada;
        }

        public void AgregarPuja(Puja puja)
        {
            if (Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("No se pueden agregar pujas a una subasta que no está en curso.");

            decimal montoMinimo = PujaList.Any() ? PujaList.Max(p => p.Monto) + Incremento : PujaInicial;

            if (puja.Monto < montoMinimo)
                throw new InvalidOperationException($"La puja debe ser al menos {montoMinimo}.");

            PujaList.Add(puja);
        }

        public Puja CalcularGanador()
        {
            if (!PujaList.Any())
                return null;

            return PujaList.OrderByDescending(p => p.Monto).First();
        }
        public Puja OfertaGanadora => CalcularGanador();

        public decimal ObtenerPujaActual()
        {
            var ganadora = CalcularGanador();
            return ganadora != null ? ganadora.Monto : PujaInicial;
        }

        public Postor ObtenerPostorGanador()
        {
            var ganadora = CalcularGanador();
            return ganadora != null ? ganadora.Postor : null;
        }


    }
}
