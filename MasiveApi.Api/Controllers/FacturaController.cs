using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Factura;
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
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _service;

        public FacturaController(IFacturaService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            return Ok(_service.GetFactura());
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<FacturaResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]

        public IActionResult Post(CreateFacturaRequest request)
        {
            _service.InsertFactura(request);
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(FacturaResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetFacturaRequest request)
        {
            return Ok(_service.GetFacturaById(request.Id));
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult Put(UpdateFacturaRequest request)
        {
            _service.UpdateFactura(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Delete([FromRoute] DeleteFacturaRequest request)
        {

            _service.DeleteFactura(request.Id);
            return Ok();
        }
    }
}

