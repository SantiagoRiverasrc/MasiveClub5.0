using MasiveApp.Application.Request.Producto;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Interfaces_App
{
    public interface IProductoService
    {

        ProductoResponse GetProductoById(int idProducto);
        IEnumerable<ProductoResponse> GetProducto();

        void InsertProducto(CreateProductoRequest producto);

        void UpdateProducto(UpdateProductoRequest producto);

        void DeleteProducto(int idProducto);
    }
}
