using System;

using System.Collections.Generic;


namespace Aula28LerDadosDoExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 2;
            p1.Nome = "Fender";
            p1.Preco = 5500f;

            p1.Cadastrar(p1);

            List<Produto> lista = p1.Ler();

            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}
