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
        public SubastaEstado Estado { get; set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        public Dictionary<Postor, decimal> Pujas { get; private set; } = new();
        public Postor Ganador { get; private set; }

        public Subasta(int id, string articulo, string subastador, decimal pujaInicial, decimal incremento, TimeSpan duracion)
        {
            Id = id;
            Articulo = articulo;
            Subastador = subastador;
            PujaInicial = pujaInicial;
            Incremento = incremento;
            Duracion = duracion;
            Estado = SubastaEstado.Pendiente;
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
            Ganador = CalcularGanador();
        }

        public void Pujar(Postor postor, decimal monto)
        {
            if (Estado != SubastaEstado.EnCurso)
                throw new InvalidOperationException("No se puede pujar en una subasta que no está en curso.");

            decimal pujaActual = ObtenerPujaActual();
            decimal minimoPermitido = pujaActual + Incremento;

            if (monto < minimoPermitido)
                throw new InvalidOperationException($"La puja debe ser al menos ${minimoPermitido:0.00}");

            Pujas[postor] = monto; 
        }

        public decimal ObtenerPujaActual()
        {
            if (Pujas.Count == 0)
                return PujaInicial;

            return Pujas.Values.Max();
        }

        public Postor CalcularGanador()
        {
            if (Pujas.Count == 0)
                return null;

            return Pujas.OrderByDescending(p => p.Value).First().Key;
        }


        public void ActualizarEstado(DateTime ahora)
        {
            if (Estado == SubastaEstado.Finalizada)
                return;

            if (FechaInicio == default)
            {
                Estado = SubastaEstado.Pendiente;
            }
            else if (ahora >= FechaInicio.Add(Duracion))
            {
                Finalizar(); // Usamos el método que ya calcula el ganador
            }
            else if (ahora >= FechaInicio){
                Estado = SubastaEstado.EnCurso;
            }
            else
            {
                Estado = SubastaEstado.Pendiente;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id} | Artículo: {Articulo} | Subastador: {Subastador} | Puja actual: ${ObtenerPujaActual():0.00} | Estado: {Estado}";
        }
    }
}
