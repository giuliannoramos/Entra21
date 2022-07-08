using System;
using System.Collections.Generic;
using System.Linq;
namespace Prova_0707
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> Produtos = new List<Produto>();
            Produto produto1 = new Produto(1, "Frutas");
            Produto produto2 = new Produto(2, "Verduras");
            Produto produto3 = new Produto(3, "Saladas");
            Produto produto4 = new Produto(4, "Carnes");
            Produto produto5 = new Produto(5, "Bebidas");
            Produto produto6 = new Produto(6, "Limpeza");
            Produtos.Add(produto1);
            Produtos.Add(produto2);
            Produtos.Add(produto3);
            Produtos.Add(produto4);
            Produtos.Add(produto5);
            Produtos.Add(produto6);

            //pular linha
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                          --------------");
            Console.WriteLine("                          -- PRODUTOS --");
            Console.WriteLine("                          --------------");
            //pular linha
            Console.WriteLine();
            Console.WriteLine($"Codigo do produto: {1} - Descrição do produto: {produto1.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {2} - Descrição do produto: {produto2.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {3} - Descrição do produto: {produto3.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {4} - Descrição do produto: {produto4.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {5} - Descrição do produto: {produto5.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {6} - Descrição do produto: {produto6.DescricaoProduto}");

            //pular linha
            Console.WriteLine();

            List<Armazem> Armazens = new List<Armazem>();
            Armazem armazem1 = new Armazem(1, "Armazem Palestina");
            Armazem armazem2 = new Armazem(2, "Armazem Beira-Rio");
            Armazens.Add(armazem1);
            Armazens.Add(armazem2);
            
            Console.WriteLine(" Informe a operação desejada:");
            Console.WriteLine(" 1 - Criar um armazém.");
            Console.WriteLine(" 2 - Alterar um armazém.");
            Console.WriteLine(" 3 - Remover um armazém.");
            Console.WriteLine(" 4 - Adcionair um produto a um armazém.");
            Console.WriteLine(" 5 - Remover um produto de um armazém.");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {
                if (opcao == (int)Operacao.CriarArmazem)
                {
                    Armazem armazem3 = new Armazem();
                    armazem3.CriarArmazem();
                    Console.WriteLine("Armazém criado com sucesso.");
                    Console.WriteLine("Codigo:" + armazem3.CodigoArmazem);
                    Console.WriteLine("Descrição:" + armazem3.DescricaoArmazem);
                }

                else if (opcao == (int)Operacao.AlterarArmazem)
                {
                    
                }

                else if (opcao == (int)Operacao.RemoverArmazem)
                {
                    
                }

                else if (opcao == (int)Operacao.AdcionarProduto)
                {
                    //pedir pro usuário o código do produto.
                    Console.WriteLine("Insira o código do produto que deseja adcionar ao armazem.");
                    int CodigoProduto = Convert.ToInt32(Console.ReadLine());                    
                    Produto pSelecionado = EncontrarProduto(Produtos, CodigoProduto);
                    //criar uma validação e etc.
                    if (pSelecionado != null)
                    {                        
                        Produtos.Add(new Produto(pSelecionado.CodigoProduto, pSelecionado.DescricaoProduto));                        
                    }
                    //pedir pro usuário o código do armazém.
                    Console.WriteLine("Insira o código do armazem.");
                    int codigoAmazem = Convert.ToInt32(Console.ReadLine());
                    Armazem aSelecionado = EncontrarArmazem(Armazens, codigoAmazem);
                    //criar uma validação e etc.
                    if (pSelecionado != null)
                    {
                        Produtos.Add(new Produto(aSelecionado.CodigoArmazem, aSelecionado.DescricaoArmazem));
                        Console.WriteLine("Produto adicionado ao armazem.");
                    }
                }
                else if (opcao == (int)Operacao.RemoverProduto)
                {

                }

                Console.WriteLine(" Informe a operação desejada:");
                Console.WriteLine(" 1 - Criar um armazém.");
                Console.WriteLine(" 2 - Alterar um armazém.");
                Console.WriteLine(" 3 - Remover um armazém.");
                Console.WriteLine(" 4 - Adcionair um produto a um armazém.");
                Console.WriteLine(" 5 - Remover um produto de um armazém.");
                Console.WriteLine(" 0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

        }
        static Produto EncontrarProduto(List<Produto> produtos, int codigo)
        {
            Produto produto = null;
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].CodigoProduto == codigo)
                {
                    produto = produtos[i];
                }
            }
            return produto;
        }

        static Armazem EncontrarArmazem(List<Armazem> armazens, int codigo)
        {
            Armazem armazem = null;
            for (int i = 0; i < armazens.Count; i++)
            {
                if (armazens[i].CodigoArmazem == codigo)
                {
                    armazem = armazens[i];
                }
            }
            return armazem;
        }
        
    }
    enum Operacao
    {
        CriarArmazem = 1,
        AlterarArmazem = 2,
        RemoverArmazem = 3,
        AdcionarProduto = 4,
        RemoverProduto = 5,
        Sair = 0
    }
}
