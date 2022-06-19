using AutoMapper;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request.Producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Mappings
{
    public class ProductoMappingProfile : Profile
    {
        public ProductoMappingProfile()
        {
            CreateMap<CreateProductoRequest, Productos>();
            CreateMap<Productos, CreateProductoRequest>();

            CreateMap<UpdateProductoRequest, Productos>();
            CreateMap<Productos, UpdateProductoRequest>();
        }
    }
}
