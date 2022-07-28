using Exercicios_API.Models;
using System.Collections.Generic;

namespace Exercicios_API.FakeDb
{
    public static class FakeData
    {
        public static List<Usuario> Usuarios = new List<Usuario>
        {
            new Usuario { Id = 1, Nome = "Remix", Cpf = "000.000.000", Senha = "ABC", User = "remix" },
            new Usuario { Id = 2, Nome = "Lucas", Cpf = "000.000.000" , Senha = "ABC", User = "lugues" },
            new Usuario { Id = 3, Nome = "Felipe", Cpf = "000.000.000", Senha = "ABC", User = "felipe" },
            new Usuario { Id = 4, Nome = "Deq", Cpf = "000.000.000", Senha = "ABC", User = "deq" },
            new Usuario { Id = 5, Nome = "Blade", Cpf = "000.000.000", Senha = "ABC", User = "blade" },
            new Usuario { Id = 6, Nome = "Valheim", Cpf = "000.000.000", Senha = "ABC", User = "val" },
            new Usuario { Id = 7, Nome = "Jose", Cpf = "000.000.000", Senha = "ABC", User = "jose" },
            new Usuario { Id = 8, Nome = "Ana", Cpf = "000.000.000", Senha = "ABC", User = "ana" },
            new Usuario { Id = 9, Nome = "Jurandir", Cpf = "000.000.000", Senha = "ABC", User = "jurandir" },
            new Usuario { Id = 10, Nome = "xpto", Cpf = "000.000.000", Senha = "ABC", User = "xpto" },
        };

        public static List<Produto> Produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Memoria ram", Valor = 200.99 },
            new Produto { Id = 2, Nome = "Processador intel", Valor = 2500 },
            new Produto { Id = 3, Nome = "Processador ryzen", Valor = 2200 },
            new Produto { Id = 4, Nome = "Placa mãe amd", Valor = 1300 },
            new Produto { Id = 5, Nome = "Placa mãe intel", Valor = 1500 },
            new Produto { Id = 6, Nome = "Gabinete", Valor = 300 },
            new Produto { Id = 7, Nome = "Gabinete ultra ", Valor = 1000 },
            new Produto { Id = 8, Nome = "Water cooler", Valor = 860 },
            new Produto { Id = 9, Nome = "Fonte 500W", Valor = 700 },
            new Produto { Id = 10, Nome = "Fonte 850W", Valor = 1100 },
            new Produto { Id = 11, Nome = "3060 TI", Valor = 5700 },
            new Produto { Id = 12, Nome = "3080 TI", Valor = 100000 },
            new Produto { Id = 13, Nome = "3070 TI", Valor = 6800 },
        };

        public static List<Carrinho> Carrinhos = new List<Carrinho> { };
        public static List<Compra> Compras = new List<Compra> { };

        public static List<ProdutoCarrinho> ProdutosCarrinho = new List<ProdutoCarrinho> { };
    }
}
