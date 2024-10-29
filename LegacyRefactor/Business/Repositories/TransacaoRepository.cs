using LegacyRefactor.Domain;
using System.Collections.Generic;

namespace LegacyRefactor.Business.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly List<Transacao> _transacoes = new List<Transacao>();

        public void Add(Transacao transacao)
        {
            _transacoes.Add(transacao);
        }

        public Transacao GetById(int id)
        {
            var transacao = _transacoes.Find(t => t.Id == id);
            if (transacao == null)
            {
                throw new KeyNotFoundException($"Transação com ID {id} não encontrada.");
            }
            return transacao;
        }

        public IEnumerable<Transacao> GetAll()
        {
            return _transacoes;
        }
    }
}
