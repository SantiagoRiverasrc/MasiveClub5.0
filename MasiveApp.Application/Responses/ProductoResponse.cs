using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Responses
{
    public class ProductoResponse
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}
