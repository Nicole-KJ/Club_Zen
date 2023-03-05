using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Permiso
    {
        public Permiso()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPermiso { get; set; }
        public string Desc { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
