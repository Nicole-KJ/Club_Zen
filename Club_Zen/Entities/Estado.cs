﻿using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Estado
    {
        public Estado()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEstado { get; set; }
        public string Estado1 { get; set; } = null!;

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
