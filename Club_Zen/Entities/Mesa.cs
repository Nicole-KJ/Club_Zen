using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Mesa
    {
        public Mesa()
        {
            ReservacionMesas = new HashSet<ReservacionMesa>();
        }

        public int IdMesa { get; set; }
        public short Cantidad { get; set; }

        public virtual ICollection<ReservacionMesa> ReservacionMesas { get; set; }
    }
}
