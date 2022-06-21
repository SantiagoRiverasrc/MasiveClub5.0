using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Cliente;
using MasiveApp.Application.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MasiveApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ClienteResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]

        public IActionResult Get()
        {
            return Ok(_service.GetCliente());
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateClienteRequest request)
        {
            _service.InsertCliente(request);
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ClienteResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetClienteRequest request)
        {
            return Ok(_service.GetClienteById(request.Id));
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult Put(UpdateClienteRequest request)
        {
            _service.UpdateCliente(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {

            _service.DeleteCliente(request.Id);
            return Ok();
        }
    }
}