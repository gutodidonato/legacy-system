using LegacyRefactor.Business.Repositories;
using LegacyRefactor.Domain;
using System;

namespace LegacyRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var clienteRepo = new ClienteRepository();
            var transacaoRepo = new TransacaoRepository();

            clienteRepo.Add(new Cliente(1, "Joao", "joao@email.com"));
            clienteRepo.Add(new Cliente(2, "Maria", "maria@email.com"));


            transacaoRepo.Add(new Transacao(1, 100.50m, "Compra de Produto"));
            transacaoRepo.Add(new Transacao(2, 200.00m, "Compra de Serviço"));

            foreach (var cliente in clienteRepo.GetAll())
            {
                Console.WriteLine($"Cliente: {cliente.Nome}, Email: {cliente.Email}");
            }

            foreach (var transacao in transacaoRepo.GetAll())
            {
                Console.WriteLine($"Transação: {transacao.Descricao}, Valor: {transacao.Valor}");
            }
        }
    }
}
