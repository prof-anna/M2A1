namespace Agenda
{
    public class ItemDaAgenda
    {
        public static int QuantidadeDeItensNaAgenda;
        public string Nome;
        public string Telefone;
        public string Endereco;
        public string Profissao;

        public ItemDaAgenda(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;

            QuantidadeDeItensNaAgenda++;
        }

        public ItemDaAgenda(string nome, string telefone, string endereco, string profissao) : this(nome, telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Profissao = profissao;

            QuantidadeDeItensNaAgenda++;
        }
    }
}