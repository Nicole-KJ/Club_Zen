using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ReservacionTenni
    {
        public int IdReservacionTennis { get; set; }
        public int IdTennisCourt { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public byte[] LogFecha { get; set; } = null!;

        public virtual TennisCourt IdTennisCourtNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
