namespace LegacyRefactor.Domain
{
    public class Cliente
    {
        public int Id { get; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime Cadastro { get; }

        public Cliente(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cadastro = DateTime.Now;
        }

        public void AtualizarNome(string novoNome)
        {
            if (!string.IsNullOrEmpty(novoNome))
            {
                Nome = novoNome;
            }
        }

        public void AtualizarEmail(string novoEmail)
        {
            if (!string.IsNullOrEmpty(novoEmail) && novoEmail.Contains("@"))
            {
                Email = novoEmail;
            }
        }
    }
}
