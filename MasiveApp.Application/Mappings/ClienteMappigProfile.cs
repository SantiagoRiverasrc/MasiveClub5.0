using AutoMapper;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Mappings
{
    public class ClienteMappigProfile : Profile
    {
        public ClienteMappigProfile()
        {
            CreateMap<CreateClienteRequest, Cliente>();
            CreateMap<Cliente, CreateClienteRequest>();

            CreateMap<UpdateClienteRequest, Cliente>();
            CreateMap<Cliente, UpdateClienteRequest>();
        }
    }
}
