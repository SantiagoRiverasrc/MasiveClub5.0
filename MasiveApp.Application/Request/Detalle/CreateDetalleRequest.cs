using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request.Detalle
{
    public class CreateDetalleRequest
    {
        public int Cantidad { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
