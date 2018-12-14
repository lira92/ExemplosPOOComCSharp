using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqELambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoas = new List<Pessoa>()
            {
                new Pessoa
                {
                    Email = "maria@maria.com",
                    Idade = 16,
                    Nome = "Maria"
                },
                new Pessoa
                {
                    Email = "pedro@pedro.com",
                    Idade = 17,
                    Nome = "Pedro"
                },
                new Pessoa
                {
                    Email = "joao@joao.com",
                    Idade = 24,
                    Nome = "João"
                }
            };

            var menoresDeIdade =
                listaPessoas.Where(pessoa => pessoa.Idade < 18)
                .Select(pessoa => new PessoaMaior
                {
                    Nome = pessoa.Nome,
                    Email = pessoa.Email
                }).ToList();

            List<PessoaMaior> maioresDeIdade = 
                listaPessoas.Where(pessoa => pessoa.Idade > 18)
                .Select(pessoa => new PessoaMaior
                {
                    Nome = pessoa.Nome,
                    Email = pessoa.Email
                }).ToList();

            maioresDeIdade.ForEach(pessoa => EncaminharEmail(pessoa));
        }

        private static void EncaminharEmail(PessoaMaior pessoa)
        {
            // Envia e-mail para pessoas maiores de 18 anos
        }
    }
}
