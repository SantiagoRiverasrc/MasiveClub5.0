using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request.Factura
{
    public class UpdateFacturaRequest
    {
        public int CodigoFactura { get; set; }
        public int IdCliente { get; set; }
    }
}
