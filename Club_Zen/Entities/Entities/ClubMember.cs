using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ClubMember
    {
        public ClubMember()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdClubMember { get; set; }
        public string Estado { get; set; } = null!;
        public string Pago { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
