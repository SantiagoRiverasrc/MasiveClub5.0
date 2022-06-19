using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masive.Infrastructure.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
        private MusicaContext _context;

        public FacturaRepository(MusicaContext context)
        {
            _context = context;
        }


        public IEnumerable<Factura> GetFactura()
        {
            return _context.Factura;
        }

        public Factura GetFacturaById(int idFactura)
        {
            return _context.Factura.FirstOrDefault(x => x.CodigoFactura == idFactura);
        }

        public void InsertFactura(Factura factura)
        {
            _context.Factura.Add(factura);
            _context.SaveChanges();
        }

        public void UpdateFactura(Factura factura)
        {
            var FacturaA = _context.Factura.FirstOrDefault(x => x.CodigoFactura == factura.CodigoFactura);
        }

        public void DeleteFactura(int idFactura)
        {
            var FacturaA = _context.Factura.FirstOrDefault(x => x.CodigoFactura == idFactura);
            _context.Factura.Remove(FacturaA);
            _context.SaveChanges();
        }
    }
}
