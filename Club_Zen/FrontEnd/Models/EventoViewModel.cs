namespace FrontEnd.Models
{
    public class EventoViewModel
    {
        public int IdEvento { get; set; }
        public string Nombre { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public short CupoMax { get; set; }
        public short AsistenciaReservada { get; set; }
    }
}
