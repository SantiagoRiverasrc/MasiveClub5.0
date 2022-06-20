using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Detalle;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Services
{
    public class DetalleService : IDetalleService
    {

        private readonly IDetalleRepository _repository;
        private readonly IMapper _mapper;

        public DetalleService(IDetalleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteDetalle(int idDetalle)
        {
            _repository.DeleteDetalle(idDetalle);
        }

        public DetalleResponse GetDetalleById(int idDetalle)
        {
            var detalle = _repository.GetDetalleById(idDetalle);
            var detalleResponse = _mapper.Map<DetalleResponse>(detalle);
            return detalleResponse;
        }

        public IEnumerable<DetalleResponse> GetDetalle()
        {
            var detalle = _repository.GetDetalle();
            var detalleResponse = _mapper.Map<IEnumerable<DetalleResponse>>(detalle);
            return detalleResponse;
        }

        public void InsertDetalle(CreateDetalleRequest request)
        {
            var detalle = _mapper.Map<Detalles>(request);
            _repository.InsertDetalle(detalle);
        }

        public void UpdateDetalle(UpdateDetalleRequest request)
        {
            var detalle = _mapper.Map<Detalles>(request);
            _repository.UpdateDetalle(detalle);
        }

    }
}