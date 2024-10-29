namespace LegacyRefactor.Domain
{
    public class Transacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public Transacao(int id, decimal valor = 0.0m, string descricao = "Descrição Padrão")
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }
    }
}