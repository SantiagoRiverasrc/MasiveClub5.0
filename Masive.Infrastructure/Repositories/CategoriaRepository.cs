using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masive.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private MusicaContext _context;

        public CategoriaRepository(MusicaContext context)
        {
            _context = context;
        }


        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.Categoria;
        }

        public Categoria GetCategoriaById(int idCategoria)
        {
            return _context.Categoria.FirstOrDefault(x => x.IdCategoria == idCategoria);
        }

        public void InsertCategoria(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            var CategoriaA = _context.Categoria.FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
            CategoriaA.Nombre = categoria.Nombre;
            
        }

        public void DeleteCategoria(int idCategoria)
        {
            var CategoriaA = _context.Categoria.FirstOrDefault(x => x.IdCategoria == idCategoria);
            _context.Categoria.Remove(CategoriaA);
            _context.SaveChanges();
        }
    }
}
