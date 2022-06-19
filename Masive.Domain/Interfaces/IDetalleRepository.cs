using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masive.Domain.Interfaces
{
    public interface IDetalleRepository
    {
        Detalles GetDetalleById(int idDetalle);

        IEnumerable<Detalles> GetDetalle();

        void InsertDetalle(Detalles detalle);

        void UpdateDetalle(Detalles detalle);

        void DeleteDetalle(int idDetalle);
    }
}
