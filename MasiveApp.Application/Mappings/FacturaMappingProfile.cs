using AutoMapper;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request.Factura;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Mappings
{
    public class FacturaMappingProfile : Profile
    {
        public FacturaMappingProfile()
        {
            CreateMap<CreateFacturaRequest, Factura>();
            CreateMap<Factura, CreateFacturaRequest>();

            CreateMap<UpdateFacturaRequest, Factura>();
            CreateMap<Factura, UpdateFacturaRequest>();
        }
    }
}
