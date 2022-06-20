using MasiveApp.Application.Request.Detalle;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Interfaces_App
{
    public interface IDetalleService
    {
        DetalleResponse GetDetalleById(int idDetalle);
        IEnumerable<DetalleResponse> GetDetalle();

        void InsertDetalle(CreateDetalleRequest detalle);

        void UpdateDetalle(UpdateDetalleRequest detalle);

        void DeleteDetalle(int idDetalle);
    }
}
