using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Ranchito
    {
        public Ranchito()
        {
            ReservacionRanchitos = new HashSet<ReservacionRanchito>();
        }

        public int IdRanchito { get; set; }
        public string Desc { get; set; } = null!;

        public virtual ICollection<ReservacionRanchito> ReservacionRanchitos { get; set; }
    }
}
