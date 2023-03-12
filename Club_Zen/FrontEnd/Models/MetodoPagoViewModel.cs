namespace FrontEnd.Models
{
    public class MetodoPagoViewModel
    {
        public int IdMetodoPago { get; set; }
        public int IdUsuario { get; set; }
        public string TipoTarjeta { get; set; } = null!;
        public long NumTarjeta { get; set; }
        public string TitularTarjeta { get; set; } = null!;
        public DateTime FechaExp { get; set; }
        public short CodigoSeguridad { get; set; }
    }
}
