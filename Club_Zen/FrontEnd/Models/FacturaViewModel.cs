namespace FrontEnd.Models
{
    public class FacturaViewModel
    {
        public int IdFactura { get; set; }
        public int IdUsuario { get; set; }
        public int IdMetodoPago { get; set; }
        public byte[] Fecha { get; set; } = null!;
        public decimal Total { get; set; }
    }
}
