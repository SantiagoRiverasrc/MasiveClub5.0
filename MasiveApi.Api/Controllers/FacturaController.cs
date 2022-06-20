using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Factura;
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
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _service;

        public FacturaController(IFacturaService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetFactura());
        }

        [HttpPost]
        public IActionResult Post(CreateFacturaRequest request)
        {
            _service.InsertFactura(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetFacturaRequest request)
        {
            return Ok(_service.GetFacturaById(request.Id));
        }

        [HttpPut]
        public ActionResult Put(UpdateFacturaRequest request)
        {
            _service.UpdateFactura(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteFacturaRequest request)
        {

            _service.DeleteFactura(request.Id);
            return Ok();
        }
    }
}

