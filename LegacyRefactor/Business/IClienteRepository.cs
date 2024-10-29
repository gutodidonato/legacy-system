using LegacyRefactor.Domain;
using System.Collections.Generic;

namespace LegacyRefactor.Business
{
    public interface IClienteRepository
    {
        void Add(Cliente cliente);
        void Remove(int id);
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        void Update(Cliente cliente);
    }
}
