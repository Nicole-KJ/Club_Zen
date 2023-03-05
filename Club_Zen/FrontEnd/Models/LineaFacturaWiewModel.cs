namespace FrontEnd.Models
{
    public class LineaFacturaWiewModel
    {
        public int IdLinea { get; set; }
        public int IdFactura { get; set; }
        public string Detalle { get; set; } = null!;
        public short Cantidad { get; set; }
        public decimal Monto { get; set; }
    }
}
