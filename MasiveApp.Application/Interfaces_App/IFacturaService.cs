using MasiveApp.Application.Request.Factura;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Interfaces_App
{
    public interface IFacturaService
    {
        FacturaResponse GetFacturaById(int idFactura);
        IEnumerable<FacturaResponse> GetFactura();

        void InsertFactura(CreateFacturaRequest factura);

        void UpdateFactura(UpdateFacturaRequest factura);

        void DeleteFactura(int idFactura);
    }
}
