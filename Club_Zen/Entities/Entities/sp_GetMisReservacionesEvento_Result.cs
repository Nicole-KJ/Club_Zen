using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Keyless]
    public class sp_GetMisReservacionesEvento_Result
    {
        public int IdReservacionEvento { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public int Personas { get; set; }
    }
}
