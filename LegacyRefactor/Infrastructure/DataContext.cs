using LegacyRefactor.Domain;
using System.Collections.Generic;

namespace LegacyRefactor.Infrastructure
{
    public class DataContext
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}
