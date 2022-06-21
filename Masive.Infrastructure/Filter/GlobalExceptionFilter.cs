using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Masive.Infrastructure.Filter
{
    public  class GlobalExceptionFilter : IExceptionFilter 
    {
        public void OnException(ExceptionContext context) 
        {
            var validation = new
            {
                Status = 500,
                Title = "Se presento una excepción en el Programa",
                Detalle = context.Exception.Message
            };

            context.Result = new ObjectResult(validation);
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.ExceptionHandled = true;
        }
    }
    
}
