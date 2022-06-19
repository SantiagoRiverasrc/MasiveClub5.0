using AutoMapper;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request.Detalle;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Mappings
{
    public class DetalleMappingProfile : Profile
    {
        public DetalleMappingProfile()
        {
            CreateMap<CreateDetalleRequest, Detalles>();
            CreateMap<Detalles, CreateDetalleRequest>();

            CreateMap<UpdateDetalleRequest, Detalles>();
            CreateMap<Detalles, UpdateDetalleRequest>();
        }
    }
}
