using AutoMapper;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request.Categoria;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Mappings
{
    public class CategoriaMappingProfile : Profile
    {
        public CategoriaMappingProfile()
        {
            CreateMap<CreateCategoriaRequest, Categoria>();
            CreateMap<Categoria, CreateCategoriaRequest>();

            CreateMap<UpdateCategoriaRequest, Categoria>();
            CreateMap<Categoria, UpdateCategoriaRequest>();
        }
    }
}
