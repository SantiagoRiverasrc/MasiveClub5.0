using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Categoria;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Services
{
    public class CategoriaService : ICategoriaService
    {

        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCategoria(int idCategoria)
        {
            _repository.DeleteCategoria(idCategoria);
        }

        public CategoriaResponse GetCategoriaById(int idCategoria)
        {
            var categoria = _repository.GetCategoriaById(idCategoria);
            var categoriaResponse = _mapper.Map<CategoriaResponse>(categoria);
            return categoriaResponse;
        }

        public IEnumerable<CategoriaResponse> GetCategoria()
        {
            var categoria = _repository.GetCategoria();
            var categoriaResponse = _mapper.Map<IEnumerable<CategoriaResponse>>(categoria);
            return categoriaResponse;
        }

        public void InsertCategoria(CreateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.InsertCategoria(categoria);
        }

        public void UpdateCategoria(UpdateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.UpdateCategoria(categoria);
        }

       
    }
}
