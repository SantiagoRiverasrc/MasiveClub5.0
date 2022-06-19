using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masive.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private MusicaContext _context;

        public ProductoRepository(MusicaContext context)
        {
            _context = context;
        }


        public IEnumerable<Productos> GetProducto()
        {
            return _context.Productos;
        }

        public Productos GetProductoById(int idProducto)
        {
            return _context.Productos.FirstOrDefault(x => x.IdProducto == idProducto);
        }

        public void InsertProducto(Productos producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Productos producto)
        {
            var ProductoA = _context.Productos.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
            ProductoA.Nombre = producto.Nombre;
            ProductoA.Precio = producto.Precio;
            
        }

        public void DeleteProducto(int idProducto)
        {
            var ProductoA = _context.Productos.FirstOrDefault(x => x.IdProducto == idProducto);
            _context.Productos.Remove(ProductoA);
            _context.SaveChanges();
        }
    }
}
