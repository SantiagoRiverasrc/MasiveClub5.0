using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Cliente;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCliente(int idCliente)
        {
            _repository.DeleteCliente(idCliente);
        }

        public ClienteResponse GetClienteById(int idCliente)
        {
            var cliente = _repository.GetClienteById(idCliente);
            var clienteResponse = _mapper.Map<ClienteResponse>(cliente);
            return clienteResponse;
        }

        public IEnumerable<ClienteResponse> GetCliente()
        {
            var cliente = _repository.GetCliente();
            var clienteResponse = _mapper.Map<IEnumerable<ClienteResponse>>(cliente);
            return clienteResponse;
        }

        public void InsertCliente(CreateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.InsertCliente(cliente);
        }

        public void UpdateCliente(UpdateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.UpdateCliente(cliente);
        }

        
    }
}
