using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
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
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetUsuario());
        }

        [HttpPost]
        public IActionResult Post(CreateUsuarioRequest request)
        {
            _service.InsertUsuario(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetUsuarioRequest request)
        {
            return Ok(_service.GetUsuarioById(request.Id));
        }

        [HttpPut]
        public ActionResult Put(UpdateUsuarioRequest request)
        {
            _service.UpdateUsuario(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteUsuarioRequest request)
        {

            _service.DeleteUsuario(request.Id);
            return Ok();
        }
    }
}
