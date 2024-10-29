using LegacyRefactor.Domain;
using System.Collections.Generic;

namespace LegacyRefactor.Business.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public void Remove(int id)
        {
            var cliente = GetById(id);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
            }
        }

        public Cliente GetById(int id)
        {
            return _clientes.Find(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clientes;
        }

        public void Update(Cliente cliente)
        {
            var existingCliente = GetById(cliente.Id);
            if (existingCliente != null)
            {
                existingCliente.AtualizarNome(cliente.Nome);
                existingCliente.AtualizarEmail(cliente.Email);
            }
        }
    }
}
