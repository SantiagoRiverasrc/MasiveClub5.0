using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request.Producto
{
    public class CreateProductoRequest
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}
