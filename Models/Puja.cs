using System;

namespace ProyectoSubastasWinForms_NET8.Models
{
    public class Puja
    {
        public Postor Postor { get; }
        public decimal Monto { get; }
        public DateTime Fecha { get; }

        public Puja(Postor postor, decimal monto)
        {
            Postor = postor ?? throw new ArgumentNullException(nameof(postor));
            if (monto <= 0) throw new ArgumentException("El monto debe ser mayor a cero.", nameof(monto));

            Monto = monto;
            Fecha = DateTime.Now;
        }
    }
}
