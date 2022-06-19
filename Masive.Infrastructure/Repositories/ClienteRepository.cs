using Masive.Domain.Interfaces;
using MasiveApi.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masive.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private MusicaContext _context;

        public ClienteRepository(MusicaContext context)
        {
            _context = context;
        }


        public IEnumerable<Cliente> GetCliente()
        {
            return _context.Cliente;
        }

        public Cliente GetClienteById(int idCliente)
        {
            return _context.Cliente.FirstOrDefault(x => x.IdCliente == idCliente);
        }

        public void InsertCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateCliente(Cliente cliente)
        {
            var ClienteA = _context.Cliente.FirstOrDefault(x => x.IdCliente == cliente.IdCliente);
            ClienteA.Nombre = cliente.Nombre;
            ClienteA.Nombre2 = cliente.Nombre2;
            ClienteA.Apellido = cliente.Apellido;
            ClienteA.Apellido2 = cliente.Apellido2;
            ClienteA.Direccion = cliente.Direccion;
            ClienteA.Telefono = cliente.Telefono;
            ClienteA.Email = cliente.Email;
        }

        public void DeleteCliente(int idCliente)
        {
            var ClienteA = _context.Cliente.FirstOrDefault(x => x.IdCliente == idCliente);
            _context.Cliente.Remove(ClienteA);
            _context.SaveChanges();
        }
    }
}
