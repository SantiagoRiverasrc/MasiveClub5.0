using MasiveApp.Application.Request.Cliente;
using MasiveApp.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasiveApp.Application.Interfaces_App
{
    public interface IClienteService
    {
        ClienteResponse GetClienteById(int idCliente);
        IEnumerable<ClienteResponse> GetCliente();

        void InsertCliente(CreateClienteRequest cliente);

        void UpdateCliente(UpdateClienteRequest cliente);

        void DeleteCliente(int idCliente);

    }
}
