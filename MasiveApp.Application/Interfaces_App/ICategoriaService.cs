using MasiveApp.Application.Request.Categoria;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Interfaces_App
{
    public interface ICategoriaService
    {
        CategoriaResponse GetCategoriaById(int idCategoria);
        IEnumerable<CategoriaResponse> GetCategoria();

        void InsertCategoria(CreateCategoriaRequest categoria);

        void UpdateCategoria(UpdateCategoriaRequest categoria);

        void DeleteCategoria(int idCategoria);

    }
}

