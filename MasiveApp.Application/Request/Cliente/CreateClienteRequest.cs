using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request.Cliente
{
    public class CreateClienteRequest
    {
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
    }
}
