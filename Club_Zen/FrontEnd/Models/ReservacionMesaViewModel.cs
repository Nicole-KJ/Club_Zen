namespace FrontEnd.Models
{
    public class ReservacionMesaViewModel
    {
        public int IdReservacionMesa { get; set; }
        public int IdMesa { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Personas { get; set; }
    }
}
