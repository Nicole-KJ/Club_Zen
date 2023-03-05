using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class LineaFactura
    {
        public int IdLinea { get; set; }
        public int IdFactura { get; set; }
        public string Detalle { get; set; } = null!;
        public short Cantidad { get; set; }
        public decimal Monto { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; } = null!;
    }
}
