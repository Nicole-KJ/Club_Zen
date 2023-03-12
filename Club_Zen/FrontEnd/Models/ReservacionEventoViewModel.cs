namespace FrontEnd.Models
{
    public class ReservacionEventoViewModel
    {
        public int IdReservacionEvento { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public int Personas { get; set; }
        public byte[] LogFecha { get; set; } = null!;
    }
}
