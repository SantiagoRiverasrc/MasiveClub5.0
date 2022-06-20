using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Categoria;
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
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;
        
        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_service.GetCategoria());
        }

        [HttpPost]
        public IActionResult Post(CreateCategoriaRequest request)
        {
            _service.InsertCategoria(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetCategoriaRequest request)
        {
            return Ok(_service.GetCategoriaById(request.Id));
        }

        [HttpPut]
        public ActionResult Put(UpdateCategoriaRequest request)
        {
            _service.UpdateCategoria(request);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteCategoriaRequest request)
        {
          
            _service.DeleteCategoria(request.Id);
            return Ok();
        }
    }
}
