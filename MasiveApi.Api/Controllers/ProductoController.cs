using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using MasiveApp.Application.Interfaces_App;
using MasiveApp.Application.Request.Producto;
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
    public class ProductoController : ControllerBase 
    {
            private readonly IProductoService _service;

            public ProductoController (IProductoService service)
            {
                _service = service;
            }

            [HttpGet]
            [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<ProductoResponse>))]
            [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
            [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ProblemDetails))]

            public IActionResult Get()
            {
                return Ok(_service.GetProducto());
            }

            [HttpPost]
            [ProducesResponseType((int)HttpStatusCode.OK)]
            [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
            [ProducesResponseType((int)HttpStatusCode.BadRequest)]
             public IActionResult Post(CreateProductoRequest request)
             {
                _service.InsertProducto(request);
                return Ok();
             }

            [HttpGet("{id}")]
            [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ProductoResponse))]
            [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
            [ProducesResponseType((int)HttpStatusCode.BadRequest)]
             public IActionResult Get([FromRoute] GetProductoRequest request)
             {
                return Ok(_service.GetProductoById(request.Id));
             }

            [HttpPut]
            [ProducesResponseType((int)HttpStatusCode.OK)]
            [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
            [ProducesResponseType((int)HttpStatusCode.BadRequest)]
             public ActionResult Put(UpdateProductoRequest request)
             {
                _service.UpdateProducto(request);
                return Ok();
             }

            [HttpDelete("{id}")]
            [ProducesResponseType((int)HttpStatusCode.OK)]
            [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
            [ProducesResponseType((int)HttpStatusCode.BadRequest)]

        public IActionResult Delete([FromRoute] DeleteProductoRequest request)
        {
                _service.DeleteProducto(request.Id);
                return Ok();
        }
    }
}
   