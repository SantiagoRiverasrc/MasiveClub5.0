using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
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
        private readonly IFacturaRepository _repository;
        private readonly IMapper _mapper;


        public FacturaController(IFacturaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetFactura());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetFacturaRequest request)
        {
            return Ok(_repository.GetFacturaById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateFacturaRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.InsertFactura(factura);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(UpdateFacturaRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.UpdateFactura(factura);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteFacturaRequest request)
        {
            _repository.DeleteFactura(request.Id);
            return Ok();
        }
    }
}
