using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
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
        private readonly IDetalleRepository _repository;
        private readonly IMapper _mapper;


        public DetalleController(IDetalleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetDetalle());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetDetalleRequest request)
        {
            return Ok(_repository.GetDetalleById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateDetalleRequest request)
        {
            var detalle = _mapper.Map<Detalles>(request);
            _repository.InsertDetalle(detalle);
            return Ok();
        }


        [HttpPut]
        public ActionResult Put(UpdateDetalleRequest request)
        {
            var detalle = _mapper.Map<Detalles>(request);
            _repository.UpdateDetalle(detalle);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteDetalleRequest request)
        {
            _repository.DeleteDetalle(request.Id);
            return Ok();
        }
    }
}
