using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request.Detalle
{
    public class UpdateDetalleRequest
    {
        public int IdDetalle { get; set; }
        public int IdProducto { get; set; }
        public int CodigoFactura { get; set; }
        public int Cantidad { get; set; }
        public int PrecioTotal { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
