using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Evento
    {
        public Evento()
        {
            ReservacionEventos = new HashSet<ReservacionEvento>();
        }

        public int IdEvento { get; set; }
        public string Nombre { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public short CupoMax { get; set; }
        public short AsistenciaReservada { get; set; }

        public virtual ICollection<ReservacionEvento> ReservacionEventos { get; set; }
    }
}
