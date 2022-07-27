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
            Console.WriteLine($"Código do armazém: {armazem2.CodigoArmazem} - Descrição do armazém: {armazem2.DescricaoArmazem}");

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
            Console.WriteLine(" 1 - Criar um novo armazém.");
            Console.WriteLine(" 2 - Alterar um armazém já existente.");
            Console.WriteLine(" 3 - Remover um armazém.");
            Console.WriteLine(" 4 - Mostrar lista atualizada de armazéns.");
            Console.WriteLine(" 5 - Criar um novo produto.");
            Console.WriteLine(" 6 - Alterar um produto da lista.");
            Console.WriteLine(" 7 - Remover um produto da lista.");
            Console.WriteLine(" 8 - Mostrar lista atualizada dos produtos existentes.");
            Console.WriteLine(" 9 - Adcionar um produto da lista ao estoque de um armazém.");
            Console.WriteLine(" 10 - Exibir o estoque de um armazém.");
            Console.WriteLine(" 11 - Remover um produto do estoque de um armazém."); 
            Console.WriteLine(" 12 - Localizar armazéns que tenham um produto específico em estoque.");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {
                if (opcao == (int)Operacao.CriarArmazem)
                {
                    Console.WriteLine("\nInsira um código para o novo armazém: ");
                    int codigoAmazem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nInsira uma descrição para o novo armazém: ");
                    string descricaoArmazem = Convert.ToString(Console.ReadLine());
                    Armazem armazemNovo = new Armazem(codigoAmazem, descricaoArmazem);
                    Armazens.Add(armazemNovo);
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
                    Console.WriteLine(" 0 - Voltar ao menu principal.");
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
                        Console.WriteLine(" 0 - Voltar ao menu principal.");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                    }
                }

                else if (opcao == (int)Operacao.RemoverArmazem)
                {
                    Console.WriteLine("\n Insira o código do armazém que deseja excluir");
                    int codigoAmazem = Convert.ToInt32(Console.ReadLine());
                    Armazem aSelecionado = EncontrarArmazem(Armazens, codigoAmazem);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{aSelecionado.DescricaoArmazem} localizado e removido ");
                    Armazem armazem = aSelecionado;
                    Armazens.Remove(armazem);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (opcao == (int)Operacao.MostrarListaDeArmazens)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lista atualizada de armazéns existentes no sistema:");
                    foreach (var elemento in Armazens)
                    {
                        Console.WriteLine($"\nCódigo:{elemento.CodigoArmazem} \nDescrição:{elemento.DescricaoArmazem}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (opcao == (int)Operacao.CriarProduto)
                {
                    Console.WriteLine("\nInsira um código para o novo produto: ");
                    int codigoProduto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nInsira uma descrição para o novo produto: ");
                    string descricaoProduto = Convert.ToString(Console.ReadLine());
                    Produto produtoNovo = new Produto(codigoProduto, descricaoProduto);
                    Produtos.Add(produtoNovo);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n Peoduto criado com sucesso.");
                    Console.WriteLine("Codigo:" + produtoNovo.CodigoProduto);
                    Console.WriteLine("Descrição:" + produtoNovo.DescricaoProduto);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (opcao == (int)Operacao.AlterarProdutoLista)
                {
                    Console.WriteLine("\n Insira o código do produto que deseja alterar");
                    int codigoProduto = Convert.ToInt32(Console.ReadLine());
                    Produto pSelecionado = EncontrarProduto(Produtos, codigoProduto);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{pSelecionado.DescricaoProduto} localizado ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n Informe a opção desejada:");
                    Console.WriteLine(" 1 - Alterar código do produto.");
                    Console.WriteLine(" 2 - Alterar descrição do produto.");
                    Console.WriteLine(" 0 - Voltar ao menu principal.");
                    int opcao2 = Convert.ToInt32(Console.ReadLine());

                    while (opcao2 != 0)
                    {
                        if (opcao2 == 1)
                        {
                            Console.WriteLine("\n Insira um novo código para o armazém: ");
                            pSelecionado.CodigoProduto = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\n Código alterado para {pSelecionado.CodigoProduto} com sucesso.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (opcao2 == 2)
                        {
                            Console.WriteLine("\n Insira uma nova descrição para o produto: ");
                            pSelecionado.DescricaoProduto = Convert.ToString(Console.ReadLine());
                            Console.WriteLine($"\n Descrição alterada para {pSelecionado.DescricaoProduto} com sucesso.");
                        }

                        Console.WriteLine("\n\n Informe a opção desejada:");
                        Console.WriteLine(" 1 - Alterar código do produto.");
                        Console.WriteLine(" 2 - Alterar descrição do produto.");
                        Console.WriteLine(" 0 - Voltar ao menu principal.");
                        opcao2 = Convert.ToInt32(Console.ReadLine());
                    }
                }

                else if (opcao == (int)Operacao.RemoverProdutoLista)
                {
                    Console.WriteLine("\n Insira o código do produto que deseja excluir");
                    int codigoProduto = Convert.ToInt32(Console.ReadLine());
                    Produto pSelecionado = EncontrarProduto(Produtos, codigoProduto);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{pSelecionado.DescricaoProduto} localizado e removido ");
                    Produto produto = pSelecionado;
                    Produtos.Remove(produto);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (opcao == (int)Operacao.MostrarListaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Lista atualizada de produtos existentes:");
                    foreach (var elemento in Produtos)
                    {
                        Console.WriteLine($"\nCódigo:{elemento.CodigoProduto} \nDescrição:{elemento.DescricaoProduto}");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (opcao == (int)Operacao.AdcionarProdutoAoEstoque)
                {                    
                    Console.WriteLine("\n Insira o código do produto que deseja adcionar ao armazem.");
                    int CodigoProduto = Convert.ToInt32(Console.ReadLine());
                    Produto pSelecionado = EncontrarProduto(Produtos, CodigoProduto);
                    //criar uma validação e etc.
                    if (pSelecionado != null)
                    {
                        Produtos.Add(new Produto(pSelecionado.CodigoProduto, pSelecionado.DescricaoProduto));
                    }                    
                    Console.WriteLine("\n Insira o código do armazem.");
                    int codigoAmazem = Convert.ToInt32(Console.ReadLine());
                    Armazem aSelecionado = EncontrarArmazem(Armazens, codigoAmazem);                    
                    if (aSelecionado != null)
                    {                        
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        AdicionarProdutoAoArmazem(aSelecionado, pSelecionado);
                        Console.WriteLine($"\n O produto {pSelecionado.DescricaoProduto} foi adicionado ao {aSelecionado.DescricaoArmazem} com sucesso.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }  
                }
                  
                else if (opcao == (int)Operacao.ExibirEstoque)
                {
                   
                }

                else if (opcao == (int)Operacao.ExcluirProdutoDoEstoque)
                {

                }

                else if (opcao == (int)Operacao.ProcurarArmazensPorProduto)
                {

                }


                Console.WriteLine(" 1 - Criar um novo armazém.");
                Console.WriteLine(" 2 - Alterar um armazém já existente.");
                Console.WriteLine(" 3 - Remover um armazém.");
                Console.WriteLine(" 4 - Mostrar lista atualizada de armazéns.");
                Console.WriteLine(" 5 - Criar um novo produto.");
                Console.WriteLine(" 6 - Alterar um produto da lista.");
                Console.WriteLine(" 7 - Remover um produto da lista.");
                Console.WriteLine(" 8 - Mostrar lista atualizada dos produtos existentes.");
                Console.WriteLine(" 9 - Adcionar um produto da lista ao estoque de um armazém.");
                Console.WriteLine(" 10 - Exibir o estoque de um armazém.");
                Console.WriteLine(" 11 - Remover um produto do estoque de um armazém.");
                Console.WriteLine(" 12 - Localizar armazéns que tenham um produto específico em estoque.");
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

        static void AdicionarProdutoAoArmazem(Armazem armazem, Produto produto)
        {
            armazem.Produtos.Add(produto);
        }

        //static Armazem EncontrarArmazemPorEstoque( List<Produto> pSelecionado, List<Armazem> armazens)
        //{
        //    List<Armazem> resultado = pSelecionado.Where(x => x.Produtos == armazens).ToList();
        //    return ;
        //}
        
    }


    enum Operacao
    {
        CriarArmazem = 1,
        AlterarArmazem = 2,
        RemoverArmazem = 3,
        MostrarListaDeArmazens = 4,
        CriarProduto = 5,
        AlterarProdutoLista = 6,
        RemoverProdutoLista = 7,        
        MostrarListaDeProdutos = 8,
        AdcionarProdutoAoEstoque = 9,
        ExibirEstoque = 10,
        ExcluirProdutoDoEstoque = 11,
        ProcurarArmazensPorProduto = 12,
        Sair = 0
    }
}


