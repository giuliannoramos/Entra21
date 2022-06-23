using System;
using System.Collections.Generic;

namespace Lista_6_Exercicio_4
{
    /*
     Faça um programa que receba os dados de uma venda:
    As entidades que devem ter os dados guardados:
    (USAR LISTAS) List<>

    Adicionar um produto na lista:
    Produto produto = new Produto();
    lista.Add(produto);

    Vendedor
    -Nome;
    -Código Crachá;

    Cliente
    -Nome;
    -CPF;
    -Endereço;

    Carrinho de compras
    -Lista de produtos;

    Venda
    -Lista de produtos;
    -Valor total na venda (somatório do preço de todos os itens)
    -Vendedor
    -Cliente;

    Produto
    -Descrição do produto
    -Marca
    -Preço

    Observações: 
    Antes de cadastrar uma venda, o vendedor e o cliente precisam estar cadastrados, assim como o produto (os produtos devem vir do carrinho). 
    Para o carrinho de compras, deve-se ter uma lista com os produtos adicionados pelo cliente.  

    O programa deve ter:
    Uma opção para cadastrar Vendedor;
    Uma opção para cadastrar Cliente;
    Uma opção para cadastrar Produto;
    Uma opção para inserir um Produto no carrinho de compras;
    Uma opção para criar uma Venda;
    Uma opção para finalizar a Venda;
    Uma opção para limpar o Carrinho;     
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Cadastre dois vendedores");
            List<Vendedor> vendedores = new List<Vendedor>();

            //pular linha
            Console.WriteLine();
                        
            Console.WriteLine(" Vendedor 1");
            Vendedor vendedor1 = new Vendedor();
            vendedor1.PreencherDadosVendedor();
            Console.WriteLine("Nome:" + vendedor1.NomeVendedor);
            Console.WriteLine("Código do crachá:" + vendedor1.CodigoCracha);
            vendedores.Add(vendedor1);

            //pular linha
            Console.WriteLine();

            Console.WriteLine(" Vendedor 2");
            Vendedor vendedor2 = new Vendedor();
            vendedor2.PreencherDadosVendedor();
            Console.WriteLine("Nome:" + vendedor2.NomeVendedor);
            Console.WriteLine("Código do crachá:" + vendedor2.CodigoCracha);            
            vendedores.Add(vendedor2);

            //pular linha
            Console.WriteLine();
            //pular linha
            Console.WriteLine();

            Console.WriteLine(" Cadastre dois clientes");
            List<Cliente> Clientes = new List<Cliente>();

            //pular linha
            Console.WriteLine();

            Console.WriteLine(" Cliente 1");
            Cliente cliente1 = new Cliente();
            cliente1.PreencherDadosCliente();
            Console.WriteLine("Nome:" + cliente1.NomeCliente);
            Console.WriteLine("CPF:" + cliente1.Cpf);
            Console.WriteLine("Endereço:" + cliente1.Endereco);
            Clientes.Add(cliente1);

            //pular linha
            Console.WriteLine();

            Console.WriteLine(" Cliente 2");
            Cliente cliente2 = new Cliente();
            cliente2.PreencherDadosCliente();
            Console.WriteLine("Nome:" + cliente2.NomeCliente);
            Console.WriteLine("CPF:" + cliente2.Cpf);
            Console.WriteLine("Endereço:" + cliente2.Endereco);
            Clientes.Add(cliente2);

            //pular linha
            Console.WriteLine();
            //pular linha
            Console.WriteLine();

            List<Produto> Produtos = new List<Produto>();
            Produto produto1 = new Produto("Tênis", "Nike", 550);
            Produto produto2 = new Produto("Tênis", "Adidas", 400);
            Produto produto3 = new Produto("Tênis", "Puma", 300);
            Produto produto4 = new Produto("Camiseta", "Nike", 100);
            Produto produto5 = new Produto("Camiseta", "Adidas", 100);
            Produto produto6 = new Produto("Camiseta", "Puma", 100);
            Produtos.Add(produto1);
            Produtos.Add(produto2);
            Produtos.Add(produto3);
            Produtos.Add(produto4);
            Produtos.Add(produto5);
            Produtos.Add(produto6);

            Console.WriteLine(" - Vendedores cadastrados com sucesso");
            Console.WriteLine(" - Clientes cadastrados com sucesso");
            Console.WriteLine(" - Produtos cadastrados com sucesso");

            //pular linha
            Console.WriteLine();

            Console.WriteLine($"{produto1.DescricaoProduto}, {produto1.Marca}, {produto1.Preco}C2"); 
            Console.WriteLine($"{produto2.DescricaoProduto}, {produto2.Marca}, {produto2.Preco}C2"); 
            Console.WriteLine($"{produto3.DescricaoProduto}, {produto3.Marca}, {produto3.Preco}C2"); 
            Console.WriteLine($"{produto4.DescricaoProduto}, {produto4.Marca}, {produto4.Preco}C2"); 
            Console.WriteLine($"{produto5.DescricaoProduto}, {produto5.Marca}, {produto5.Preco}C2"); 
            Console.WriteLine($"{produto6.DescricaoProduto}, {produto6.Marca}, {produto6.Preco}C2");

            //pular linha
            Console.WriteLine();

            Console.WriteLine(" Com base nos produtos cadastrados acima;");
            Console.WriteLine(" Informe a operação desejada:");
            Console.WriteLine(" 1 - Adcionair um produto ao carrinho.");
            Console.WriteLine(" 2 - Limpar o carrinho.");
            Console.WriteLine(" 3 - Efetuar compra do carrinho.");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {

                if (opcao == (int)Operacao.adicionarAoCarrinho)
                {

                }

                else if (opcao == (int)Operacao.limparCarrinho)
                {

                }

                else if (opcao == (int)Operacao.finalizarVenda)
                { 
                
                }

                Console.WriteLine(" Com base nos produtos cadastrados acima;");
                Console.WriteLine(" Informe a operação desejada:");
                Console.WriteLine(" 1 - Adcionair um produto ao carrinho.");
                Console.WriteLine(" 2 - Limpar o carrinho.");
                Console.WriteLine(" 3 - Efetuar compra do carrinho.");
                Console.WriteLine(" 0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }

            //pular linha
            Console.WriteLine();

            Console.WriteLine(" Carrinho concluido com sucesso.");
            

            CarrinhoDeCompras Carrinho = new CarrinhoDeCompras();

            List<Venda> Vendas = new List<Venda>();
            Venda venda1 = new Venda(Carrinho, vendedor1, cliente1);
            Venda venda2 = new Venda(Carrinho, vendedor2, cliente2);
            Vendas.Add(venda1);
            Vendas.Add(venda2);                        
        }
    }       

    enum Operacao
    {       
        adicionarAoCarrinho = 1,        
        limparCarrinho = 2,
        finalizarVenda = 3,
        Sair = 0
    }
}

