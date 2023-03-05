using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdMetodoPago { get; set; }
        public int IdUsuario { get; set; }
        public string TipoTarjeta { get; set; } = null!;
        public long NumTarjeta { get; set; }
        public string TitularTarjeta { get; set; } = null!;
        public DateTime FechaExp { get; set; }
        public short CodigoSeguridad { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
