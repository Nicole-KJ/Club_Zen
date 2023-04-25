using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Keyless]
    public class sp_GetMesasParaCantidad_Result
    {
        public int IdMesa { get; set; }
        public short Cantidad { get; set; }
    }
}
