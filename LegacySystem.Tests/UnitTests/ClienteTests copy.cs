using System;
using System.Collections.Generic;
using LegacyRefactor.Domain;
using Xunit;

namespace LegacySystem.Tests.UnitTests
{
    public class ClienteTests
    {
        [Fact]
        public void AddCliente_DeveAdicionarClienteComSucesso()
        {
            var cliente = new Cliente(1, "Joao", "joao@email.com");

            Assert.Equal(1, cliente.Id);
            Assert.Equal("Joao", cliente.Nome);
            Assert.Equal("joao@email.com", cliente.Email);
        }

        [Fact]
        public void AtualizarNomeCliente_DeveAtualizarNomeCorretamente()
        {
            var cliente = new Cliente(2, "Maria", "maria@email.com");

            cliente.AtualizarNome("Maria Silva");

            Assert.Equal("Maria Silva", cliente.Nome);
        }

        [Fact]
        public void RemoverCliente_DeveRemoverClienteComSucesso()
        {
            var clientes = new List<Cliente>
            {
                new Cliente(1, "Joao", "joao@email.com"),
                new Cliente(2, "Maria", "maria@email.com")
            };

            clientes.RemoveAll(c => c.Id == 1);

            Assert.DoesNotContain(clientes, c => c.Id == 1);
        }
    }
}
