using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ReservacionRanchito
    {
        public int IdReservacionRanchito { get; set; }
        public int IdRanchito { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaReserva { get; set; }
        public byte[] LogFecha { get; set; } = null!;

        public virtual Ranchito IdRanchitoNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
