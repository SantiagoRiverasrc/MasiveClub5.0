using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masive.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        Categoria GetCategoriaById(int idCategoria);

        IEnumerable<Categoria> GetCategoria();

        void InsertCategoria(Categoria categoria);

        void UpdateCategoria(Categoria categoria);

        void DeleteCategoria(int idCategoria);
    }
}
