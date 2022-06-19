using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Request;
using MasiveApp.Application.Request.Usuario;
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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;


        public UsuarioController(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetUsuario());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetUsuarioRequest request)
        {
            return Ok(_repository.GetUsuarioById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateUsuarioRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            _repository.InsertUsuario(usuario);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(UpdateUsuarioRequest request)
        {
            var usuario = _mapper.Map<Usuario>(request);
            _repository.UpdateUsuario(usuario);
            return Ok();
        }

        [HttpDelete("{id}")]
        
        public IActionResult Delete([FromRoute] DeleteUsuarioRequest request)
        {
            _repository.DeleteUsuario(request.Id);
            return Ok();
        }


    }
}
