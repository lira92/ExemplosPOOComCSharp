using Enumeracoes;

namespace Classes
{
    public class Cliente
    {
        private const decimal RENDA_MINIMA_PREMIUM = 5000;
        private const decimal RENDA_MINIMA_MASTER = 8500;
        private const decimal VALOR_MINIMO_EM_COMPRAS_PREMIUM = 8000;
        private const decimal VALOR_MINIMO_EM_COMPRAS_MASTER = 10000;
        public Cliente(int codigo, string nome, decimal rendaMensal, string[] emails)
        {
            Codigo = codigo;
            Nome = nome;
            RendaMensal = rendaMensal;
            Classificacao = DefinirClassificacao();
            Emails = emails;
        }

        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public decimal RendaMensal { get; set; }
        public EClassificacao Classificacao { get; private set; }
        public string[] Emails { get; private set; }

        public string GerarListaDeEmails()
        {
            var listaEmails = "O cliente possui " + Emails.Length + " e-mails:\n";
            foreach (var email in Emails)
            {
                listaEmails += email + "\n";
            }
            return listaEmails;
        }

        private EClassificacao DefinirClassificacao()
        {
            if (RendaMensal < RENDA_MINIMA_PREMIUM)
            {
                return EClassificacao.Convencional;
            }
            if (RendaMensal < RENDA_MINIMA_MASTER)
            {
                return EClassificacao.Premium;
            }
            return EClassificacao.Master;
        }
    }
}