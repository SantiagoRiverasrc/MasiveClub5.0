using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masive.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Cliente GetClienteById(int idCliente);

        IEnumerable<Cliente> GetCliente();

        void InsertCliente(Cliente cliente);

        void UpdateCliente(Cliente cliente);

        void DeleteCliente(int idCliente);
    }
}
