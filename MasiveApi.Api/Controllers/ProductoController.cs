using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Producto;
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
    public class ProductoController : ControllerBase 
    {
            private readonly IProductoService _service;

            public ProductoController (IProductoService service)
            {
                _service = service;
            }

            [HttpGet]

            public IActionResult Get()
            {
                return Ok(_service.GetProducto());
            }

            [HttpPost]
            public IActionResult Post(CreateProductoRequest request)
            {
                _service.InsertProducto(request);
                return Ok();
            }

            [HttpGet("{id}")]
            public IActionResult Get([FromRoute] GetProductoRequest request)
            {
                return Ok(_service.GetProductoById(request.Id));
            }

            [HttpPut]
            public ActionResult Put(UpdateProductoRequest request)
            {
                _service.UpdateProducto(request);
                return Ok();
            }

            [HttpDelete("{id}")]

            public IActionResult Delete([FromRoute] DeleteProductoRequest request)
            {

                _service.DeleteProducto(request.Id);
                return Ok();
            }
    }
}
   