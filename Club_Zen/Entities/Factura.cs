using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Factura
    {
        public Factura()
        {
            LineaFacturas = new HashSet<LineaFactura>();
        }

        public int IdFactura { get; set; }
        public int IdUsuario { get; set; }
        public int IdMetodoPago { get; set; }
        public byte[] Fecha { get; set; } = null!;
        public decimal Total { get; set; }

        public virtual MetodoPago IdMetodoPagoNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<LineaFactura> LineaFacturas { get; set; }
    }
}
