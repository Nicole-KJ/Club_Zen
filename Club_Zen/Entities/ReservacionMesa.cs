using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class ReservacionMesa
    {
        public int IdReservacionMesa { get; set; }
        public int IdMesa { get; set; }
        public int IdUsuario { get; set; }
        public byte[] LogFecha { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Personas { get; set; }

        public virtual Mesa IdMesaNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
