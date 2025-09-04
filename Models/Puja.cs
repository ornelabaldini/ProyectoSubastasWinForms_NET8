using System;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Puja
    {
        public Postor Postor { get; private set; }
        public decimal Monto { get; private set; }
        public DateTime Fecha { get; private set; }

        public Puja(Postor postor, decimal monto)
        {
            Postor = postor;
            Monto = monto;
            Fecha = DateTime.Now;
        }
    }
}
