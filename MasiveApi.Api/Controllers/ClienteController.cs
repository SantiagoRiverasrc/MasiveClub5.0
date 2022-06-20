using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Cliente;
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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetCliente());
        }

        [HttpPost]
        public IActionResult Post(CreateClienteRequest request)
        {
            _service.InsertCliente(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetClienteRequest request)
        {
            return Ok(_service.GetClienteById(request.Id));
        }

        [HttpPut]
        public ActionResult Put(UpdateClienteRequest request)
        {
            _service.UpdateCliente(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {

            _service.DeleteCliente(request.Id);
            return Ok();
        }
    }
}