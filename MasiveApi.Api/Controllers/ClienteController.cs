using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
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
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;


        public ClienteController(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCliente());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetClienteRequest request)
        {
            return Ok(_repository.GetClienteById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.InsertCliente(cliente);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(UpdateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.UpdateCliente(cliente);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {
            _repository.DeleteCliente(request.Id);
            return Ok();
        }
    }
}
