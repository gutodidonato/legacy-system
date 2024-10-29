using LegacyRefactor.Business.Repositories;
using LegacyRefactor.Domain;
using Xunit;

public class TransacaoRepositoryTests
{
    [Fact]
    public void Add_DeveAdicionarTransacao()
    {
        var repository = new TransacaoRepository();
        var transacao = new Transacao(1, 100.0m, "Compra de Produto");

        repository.Add(transacao);

        Assert.Equal(transacao, repository.GetById(1));
    }

    [Fact]
    public void GetById_DeveRetornarTransacaoCorreta()
    {
        var repository = new TransacaoRepository();
        var transacao = new Transacao(2, 200.0m, "Compra de Serviço");
        repository.Add(transacao);

        var result = repository.GetById(2);

        Assert.Equal(transacao, result);
    }

    [Fact]
    public void GetById_DeveLancarExcecaoSeNaoEncontrada()
    {
        var repository = new TransacaoRepository();

        Assert.Throws<KeyNotFoundException>(() => repository.GetById(99));
    }

    [Fact]
    public void GetAll_DeveRetornarTodasTransacoes()
    {
        var repository = new TransacaoRepository();
        var transacao1 = new Transacao(1, 100.0m, "Compra A");
        var transacao2 = new Transacao(2, 200.0m, "Compra B");
        repository.Add(transacao1);
        repository.Add(transacao2);

        var result = repository.GetAll();

        Assert.Contains(transacao1, result);
        Assert.Contains(transacao2, result);
    }
}
