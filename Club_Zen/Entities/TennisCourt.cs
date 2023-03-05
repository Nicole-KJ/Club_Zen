using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class TennisCourt
    {
        public TennisCourt()
        {
            ReservacionTennis = new HashSet<ReservacionTenni>();
        }

        public int IdTennisCourt { get; set; }
        public string Desc { get; set; } = null!;

        public virtual ICollection<ReservacionTenni> ReservacionTennis { get; set; }
    }
}
