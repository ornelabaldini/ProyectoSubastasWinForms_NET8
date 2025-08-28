using System;
using System.Collections.Generic;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Subasta
    {
        public string NombreSubastador { get; set; }
        public string Articulo { get; set; }
        public decimal Pujainicial { get; set; }
        public decimal PujadeAumento { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Duracion { get; set; }
        public List<Postor> Postores { get; set; } = new List<Postor>();
        public Postor Ganador { get; set; }
        public decimal OfertaGanadora { get; set; }

        public override string ToString() => $"{Articulo} ({NombreSubastador})";
    }
}
