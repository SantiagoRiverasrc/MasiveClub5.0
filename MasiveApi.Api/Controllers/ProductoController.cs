using AutoMapper;
using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
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
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;


        public ProductoController(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProducto());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetProductoRequest request)
        {
            return Ok(_repository.GetProductoById(request.Id));
        }

        [HttpPost]
        public IActionResult Post(CreateProductoRequest request)
        {
            var producto = _mapper.Map<Productos>(request);
            _repository.InsertProducto(producto);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(UpdateProductoRequest request)
        {
            var producto = _mapper.Map<Productos>(request);
            _repository.UpdateProducto(producto);
            return Ok();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete([FromRoute] DeleteProductoRequest request)
        {
            _repository.DeleteProducto(request.Id);
            return Ok();
        }
    }
}
