using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masive.Infrastructure.Repositories
{
    public class DetalleRepository : IDetalleRepository
    {
        private MusicaContext _context;

        public DetalleRepository(MusicaContext context)
        {
            _context = context;
        }


        public IEnumerable<Detalles> GetDetalle()
        {
            return _context.Detalles;
        }

        public Detalles GetDetalleById(int idDetalle)
        {
            return _context.Detalles.FirstOrDefault(x => x.IdDetalle == idDetalle);
        }

        public void InsertDetalle(Detalles detalle)
        {
            _context.Detalles.Add(detalle);
            _context.SaveChanges();
        }

        public void UpdateDetalle(Detalles detalle)
        {
            var DetalleA = _context.Detalles.FirstOrDefault(x => x.IdDetalle == detalle.IdDetalle);
            DetalleA.Cantidad = detalle.Cantidad;
            DetalleA.PrecioTotal = detalle.PrecioTotal;
            DetalleA.FechaCompra = detalle.FechaCompra;
        }

        public void DeleteDetalle(int idDetalle)
        {
            var DetalleA = _context.Detalles.FirstOrDefault(x => x.IdDetalle == idDetalle);
            _context.Detalles.Remove(DetalleA);
            _context.SaveChanges();
        }
    }
}
