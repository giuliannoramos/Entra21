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
            List<Vendedor> Vendedores = new List<Vendedor>();
            Vendedor vendedor1 = new Vendedor("Tim", 01);
            Vendedor vendedor2 = new Vendedor("Micael", 02);
            Vendedores.Add(vendedor1);
            Vendedores.Add(vendedor2);

            List<Cliente> Clientes = new List<Cliente>();
            Cliente cliente1 = new Cliente("Maia", "25687419963", "Rua Exquina, 256 - RJ");
            Cliente cliente2 = new Cliente("Jackson", "25687458963", "Rua Broklin, 655 - SP");
            Clientes.Add(cliente1);
            Clientes.Add(cliente2);

            CarrinhoDeCompras Carrinho = new CarrinhoDeCompras();

            List<Venda> Vendas = new List<Venda>();
            Venda venda1 = new Venda(Carrinho, vendedor1, cliente1);
            Venda venda2 = new Venda(Carrinho, vendedor2, cliente2);
            Vendas.Add(venda1);
            Vendas.Add(venda2);

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
        }
    }
}

