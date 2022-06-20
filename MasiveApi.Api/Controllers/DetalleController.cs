using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Detalle;
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
    public class DetalleController : ControllerBase
    {
        private readonly IDetalleService _service;

        public DetalleController(IDetalleService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetDetalle());
        }

        [HttpPost]
        public IActionResult Post(CreateDetalleRequest request)
        {
            _service.InsertDetalle(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetDetalleRequest request)
        {
            return Ok(_service.GetDetalleById(request.Id));
        }

        [HttpPut]
        public ActionResult Put(UpdateDetalleRequest request)
        {
            _service.UpdateDetalle(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteDetalleRequest request)
        {

            _service.DeleteDetalle(request.Id);
            return Ok();
        }
    }
}
