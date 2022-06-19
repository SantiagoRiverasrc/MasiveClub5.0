using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Request.Categoria
{
    public class UpdateCategoriaRequest
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
