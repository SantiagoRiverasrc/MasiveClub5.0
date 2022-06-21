using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Detalle;
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
    public class DetalleController : ControllerBase
    {
        private readonly IDetalleService _service;

        public DetalleController(IDetalleService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<DetalleResponse>))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]

        public IActionResult Get()
        {
            return Ok(_service.GetDetalle());
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Post(CreateDetalleRequest request)
        {
            _service.InsertDetalle(request);
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(DetalleResponse))]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromRoute] GetDetalleRequest request)
        {
            return Ok(_service.GetDetalleById(request.Id));
        }

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public ActionResult Put(UpdateDetalleRequest request)
        {
            _service.UpdateDetalle(request);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete([FromRoute] DeleteDetalleRequest request)
        {

            _service.DeleteDetalle(request.Id);
            return Ok();
        }
    }
}
