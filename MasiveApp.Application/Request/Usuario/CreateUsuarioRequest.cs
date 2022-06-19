using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request
{
    public class CreateUsuarioRequest
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}
