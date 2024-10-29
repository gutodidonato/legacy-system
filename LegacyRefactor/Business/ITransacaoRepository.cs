using LegacyRefactor.Domain;
using System.Collections.Generic;

namespace LegacyRefactor.Business
{
    public interface ITransacaoRepository
    {
        void Add(Transacao transacao);   
        Transacao GetById(int id);       
        IEnumerable<Transacao> GetAll(); 
    }
}
