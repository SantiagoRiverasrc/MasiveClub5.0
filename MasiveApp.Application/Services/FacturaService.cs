using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Factura;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Services
{
    public class FacturaService : IFacturaService
    {
        private readonly IFacturaRepository _repository;
        private readonly IMapper _mapper;

        public FacturaService(IFacturaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteFactura(int idFactura)
        {
            _repository.DeleteFactura(idFactura);
        }

        public FacturaResponse GetFacturaById(int idFactura)
        {
            var factura = _repository.GetFacturaById(idFactura);
            var facturaResponse = _mapper.Map<FacturaResponse>(factura);
            return facturaResponse;
        }

        public IEnumerable<FacturaResponse> GetFactura()
        {
            var factura = _repository.GetFactura();
            var facturaResponse = _mapper.Map<IEnumerable<FacturaResponse>>(factura);
            return facturaResponse;
        }

        public void InsertFactura(CreateFacturaRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.InsertFactura(factura);
        }

        public void UpdateFactura(UpdateFacturaRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.UpdateFactura(factura);
        }

    }
}
