using System;
using System.Collections.Generic;
using System.Linq;
namespace Prova_0707
{
    class Program
    {
        static void Main(string[] args)
        {                        

            List<Armazem> Armazens = new List<Armazem>();
            Armazem armazem1 = new Armazem(1, "Armazém do Alemão");
            Armazem armazem2 = new Armazem(2, "Armazém Fitness");
            Armazens.Add(armazem1);
            Armazens.Add(armazem2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n¦==============================================================¦");
            Console.WriteLine("¦======================      ARMAZÉNS      ====================¦");
            Console.WriteLine("¦==============================================================¦");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"\nCódigo do armazém: {armazem1.CodigoArmazem} - Descrição do armazém: {armazem1.DescricaoArmazem}");
            Console.WriteLine($"Código do armazém: {armazem2} - Descrição do armazém: {armazem2.DescricaoArmazem}");            

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
                        
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n¦==============================================================¦");
            Console.WriteLine("¦======================      PRODUTOS      ====================¦");
            Console.WriteLine("¦==============================================================¦");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"\nCodigo do produto: {1} - Descrição do produto: {produto1.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {2} - Descrição do produto: {produto2.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {3} - Descrição do produto: {produto3.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {4} - Descrição do produto: {produto4.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {5} - Descrição do produto: {produto5.DescricaoProduto}");
            Console.WriteLine($"Codigo do produto: {6} - Descrição do produto: {produto6.DescricaoProduto}");
            
            Console.WriteLine("\n\n Informe a operação desejada:");
            Console.WriteLine(" 1 - Adcionar um novo armazém.");
            Console.WriteLine(" 2 - Alterar um armazém já existente.");
            Console.WriteLine(" 3 - Remover um armazém.");
            Console.WriteLine(" 4 - Adcionar um novo produto.");
            Console.WriteLine(" 5 - Adcionair um produto já existente ao estoque de um armazém.");
            Console.WriteLine(" 6 - Remover um produto de um armazém.");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {
                if (opcao == (int)Operacao.CriarArmazem)
                {
                    Armazem armazemNovo = new Armazem(3, "provisório");
                    armazemNovo.CriarArmazem();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n Armazém criado com sucesso.");
                    Console.WriteLine("Codigo:" + armazemNovo.CodigoArmazem);
                    Console.WriteLine("Descrição:" + armazemNovo.DescricaoArmazem);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (opcao == (int)Operacao.AlterarArmazem)
                {
                    Console.WriteLine("\n Insira o código do armazém que deseja alterar");
                    int codigoAmazem = Convert.ToInt32(Console.ReadLine());
                    Armazem aSelecionado = EncontrarArmazem(Armazens, codigoAmazem);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{aSelecionado.DescricaoArmazem} localizado ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n Informe a opção desejada:");
                    Console.WriteLine(" 1 - Alterar código do armazém.");
                    Console.WriteLine(" 2 - Alterar nome do armazém.");
                    Console.WriteLine(" 0 - Sair.");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    while (opcao2 != 0)
                    {
                        if (opcao2 == 1)
                        {
                            Console.WriteLine("\n Insira um novo código para o armazém: ");
                            aSelecionado.CodigoArmazem = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\n Código alterado para {aSelecionado.CodigoArmazem} com sucesso.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (opcao2 == 2)
                        {
                            Console.WriteLine("\n Insira uma nova descrição para o armazém: ");
                            aSelecionado.DescricaoArmazem = Convert.ToString(Console.ReadLine());
                            Console.WriteLine($"\n Descrição alterada para {aSelecionado.DescricaoArmazem} com sucesso.");
                        }

                        Console.WriteLine("\n\n Informe a opção desejada:");
                        Console.WriteLine(" 1 - Alterar código do armazém.");
                        Console.WriteLine(" 2 - Alterar nome do armazém.");
                        Console.WriteLine(" 0 - Sair.");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                    }
                }

                else if (opcao == (int)Operacao.RemoverArmazem)
                {

                }

                else if (opcao == (int)Operacao.CriarProduto)
                {
                    
                }

                else if (opcao == (int)Operacao.AdcionarProduto)
                {
                    //pedir pro usuário o código do produto.
                    Console.WriteLine("\n Insira o código do produto que deseja adcionar ao armazem.");
                    int CodigoProduto = Convert.ToInt32(Console.ReadLine());
                    Produto pSelecionado = EncontrarProduto(Produtos, CodigoProduto);
                    //criar uma validação e etc.
                    if (pSelecionado != null)
                    {
                        Produtos.Add(new Produto(pSelecionado.CodigoProduto, pSelecionado.DescricaoProduto));
                    }
                    //pedir pro usuário o código do armazém.
                    Console.WriteLine("\n Insira o código do armazem.");
                    int codigoAmazem = Convert.ToInt32(Console.ReadLine());
                    Armazem aSelecionado = EncontrarArmazem(Armazens, codigoAmazem);
                    //criar uma validação e etc.
                    if (pSelecionado != null)
                    {
                        Produtos.Add(new Produto(aSelecionado.CodigoArmazem, aSelecionado.DescricaoArmazem));
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"\n O produto {pSelecionado.DescricaoProduto} foi adicionado ao armazém {aSelecionado.CodigoArmazem} com sucesso.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else if (opcao == (int)Operacao.RemoverProduto)
                {

                }

                Console.WriteLine("\n\n Informe a operação desejada:");
                Console.WriteLine(" 1 - Adcionar um novo armazém.");
                Console.WriteLine(" 2 - Alterar um armazém já existente.");
                Console.WriteLine(" 3 - Remover um armazém.");
                Console.WriteLine(" 4 - Adcionar um novo produto.");
                Console.WriteLine(" 5 - Adcionair um produto já existente ao estoque de um armazém.");
                Console.WriteLine(" 6 - Remover um produto de um armazém.");
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
        CriarProduto = 4,
        AdcionarProduto = 5,
        RemoverProduto = 6,
        Sair = 0
    }
}
