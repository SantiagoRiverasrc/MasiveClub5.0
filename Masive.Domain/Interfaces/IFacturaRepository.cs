using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masive.Domain.Interfaces
{
    public interface IFacturaRepository
    {
        Factura GetFacturaById(int idFactura);

        IEnumerable<Factura> GetFactura();

        void InsertFactura(Factura factura);

        void UpdateFactura(Factura factura);

        void DeleteFactura(int idFactura);
    }
}
