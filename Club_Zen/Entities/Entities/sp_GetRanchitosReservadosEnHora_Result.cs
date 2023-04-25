using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Keyless]
    public class sp_GetRanchitosReservadosEnHora_Result
    {
        public int IdReservacionRanchito { get; set; }
        public int IdRanchito { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
