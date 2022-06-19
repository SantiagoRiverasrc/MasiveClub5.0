using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request.Categoria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasiveApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;


        public CategoriaController(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCategoria());
        }

        [HttpPost]
        public IActionResult Post(CreateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.InsertCategoria(categoria);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetCategoriaRequest request)
        {
            return Ok(_repository.GetCategoriaById(request.Id));
        }

        [HttpPut]
        public ActionResult Put(UpdateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.UpdateCategoria(categoria);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteCategoriaRequest request)
        {
            _repository.DeleteCategoria(request.Id);
            return Ok();
        }
    }
}
