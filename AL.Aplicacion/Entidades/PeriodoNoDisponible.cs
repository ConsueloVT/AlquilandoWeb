using System;

namespace AL.Aplicacion.Entidades
{
    public class PeriodoNoDisponible
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        // FK
        public int AlojamientoId { get; set; }
        public Alojamiento Alojamiento { get; set; } = null!;
    }
}
