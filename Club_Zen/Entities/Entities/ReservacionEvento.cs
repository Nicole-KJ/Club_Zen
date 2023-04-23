using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ReservacionEvento
    {
        public int IdReservacionEvento { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public int Personas { get; set; }
        public byte[] LogFecha { get; set; } = null!;

        public virtual Evento IdEventoNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
