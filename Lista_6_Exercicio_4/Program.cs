using System;
using System.Collections.Generic;
using System.Linq;

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

            List<Produto> Produtos = new List<Produto>();
            Produto produto1 = new Produto(1, "Tênis", "Nike", 550);
            Produto produto2 = new Produto(2, "Tênis", "Adidas", 400);
            Produto produto3 = new Produto(3, "Tênis", "Puma", 300);
            Produto produto4 = new Produto(4, "Camiseta", "Nike", 100);
            Produto produto5 = new Produto(5, "Camiseta", "Adidas", 100);
            Produto produto6 = new Produto(6, "Camiseta", "Puma", 100);
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

            Console.WriteLine($"Codigo do produto: {1} - Descrição do produto: {produto1.DescricaoProduto}, {produto1.Marca}, {produto1.Preco:C2}");
            Console.WriteLine($"Codigo do produto: {2} - Descrição do produto: {produto2.DescricaoProduto}, {produto2.Marca}, {produto2.Preco:C2}");
            Console.WriteLine($"Codigo do produto: {3} - Descrição do produto: {produto3.DescricaoProduto}, {produto3.Marca}, {produto3.Preco:C2}");
            Console.WriteLine($"Codigo do produto: {4} - Descrição do produto: {produto4.DescricaoProduto}, {produto4.Marca}, {produto4.Preco:C2}");
            Console.WriteLine($"Codigo do produto: {5} - Descrição do produto: {produto5.DescricaoProduto}, {produto5.Marca}, {produto5.Preco:C2}");
            Console.WriteLine($"Codigo do produto: {6} - Descrição do produto: {produto6.DescricaoProduto}, {produto6.Marca}, {produto6.Preco:C2}");

            //pular linha
            Console.WriteLine();

            CarrinhoDeCompras Carrinho = new CarrinhoDeCompras();
            Venda vendaAtual = new Venda();
            List<Venda> Vendas = new List<Venda>();
            Venda venda1 = new Venda(Carrinho, vendedor1, cliente1);
            Venda venda2 = new Venda(Carrinho, vendedor2, cliente2);
            Vendas.Add(venda1);
            Vendas.Add(venda2);
            //Cliente clienteAtual = new Cliente();
            //Vendedor vendedorAtual = new Vendedor();

            static Cliente EncontrarCliente(List<Cliente> clientes, int codigo)
            {
                Cliente cliente = null;
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].Cpf == codigo)
                    {
                        cliente = clientes[i];
                    }
                }
                return cliente;
            }

            static Vendedor EncontrarVendedor(List<Vendedor> vendedores, int codigo)
            {
                Vendedor vendedor = null;
                for (int i = 0; i < vendedores.Count; i++)
                {
                    if (vendedores[i].CodigoCracha == codigo)
                    {
                        vendedor = vendedores[i];
                    }
                }
                return vendedor;
            }

            static List<Produto> CopiarProdutosParaOutraLista(List<Produto> produtos)
            {
                List<Produto> produtosCopia = new List<Produto>();
                foreach (Produto p in produtos)
                {
                    produtosCopia.Add(new Produto(p.Codigo, p.DescricaoProduto, p.Marca, p.Preco));
                }
                return produtosCopia;
            }

            //static void ListarProdutos(List<Produto> produtos)
            //{
            //    foreach (Produto produto in produtos)
            //    {
            //        Console.WriteLine($"Descrição: {produto.DescricaoProduto}");
            //        Console.WriteLine($"Marca: {produto.Marca}");
            //        Console.WriteLine($"Preço: {produto.Preco}");
            //    }
            //}

            static Produto EncontrarProduto(List<Produto> produtos, int codigo)
            {
                Produto produto = null;
                for (int i = 0; i < produtos.Count; i++)
                {
                    if (produtos[i].Codigo == codigo)
                    {
                        produto = produtos[i];
                    }
                }
                return produto;
            }
            //ListarProdutos(Produtos);

            //Console.WriteLine("Insira o código do produto");
            //int codigoProduto = Convert.ToInt32(Console.ReadLine());
            ////usa a função "EncontrarProduto" para buscar um elemento baseado no campo "código" do produto.
            //Produto produtoEncontrado = EncontrarProduto(Produtos, codigoProduto);

            Console.WriteLine(" Com base nos produtos cadastrados acima;");
            Console.WriteLine(" Informe a operação desejada:");
            Console.WriteLine(" 1 - Adcionair produto ao carrinho.");
            Console.WriteLine(" 2 - Limpar o carrinho.");
            Console.WriteLine(" 3 - Criar a ordem de venda.");
            Console.WriteLine(" 4 - Finalizar a venda.");
            Console.WriteLine(" 0 - Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao != (int)Operacao.Sair)
            {
                if (opcao == (int)Operacao.adicionarAoCarrinho)
                {
                    //pedir pro usuário o código do produto.
                    Console.WriteLine("Insira o código do produto que deseja adcionar ao carrinho.");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    Produto pSelecionado = EncontrarProduto(Produtos, codigo);
                    //criar uma validação e etc.
                    if (pSelecionado != null)
                    {
                        //carrinho.Produtos.Add(produtoSelecionado);
                        Carrinho.Produtos.Add(new Produto(pSelecionado.Codigo, pSelecionado.DescricaoProduto,
                                              pSelecionado.Marca, pSelecionado.Preco));
                        Console.WriteLine("Produto adicionado ao carrinho.");
                    }
                }

                else if (opcao == (int)Operacao.limparCarrinho)
                {
                    Carrinho.Produtos.Clear();
                    Console.WriteLine("Seu carrinho está vazio.");
                }

                else if (opcao == (int)Operacao.criarVenda)
                {
                    Console.WriteLine("Para criar uma venda, insira os dados do cliente e do vendedor.");
                    //pedir pro usuário o CPF do cliente;
                    Console.WriteLine("Insira o cpf do cliente.");
                    //pedir pro usuário o cracha do vendedor;
                    Console.WriteLine("Insira o crachá do vendedor.");
                    //para poder criar a venda;
                    int codigoCliente = Convert.ToInt32(Console.ReadLine());
                    int codigoVendedor = Convert.ToInt32(Console.ReadLine());
                    //encontra o cliente
                    Cliente cSelecionado = EncontrarCliente(Clientes, codigoCliente);
                    //encontra o vendedor
                    Vendedor vSelecionado = EncontrarVendedor(vendedores, codigoVendedor);

                    //precisa achar os dois para poder criar a venda.
                    if (cSelecionado != null && vSelecionado != null)
                    {
                        vendaAtual.Cliente = cSelecionado;//fazer isso na hora de fechar a venda: new Cliente(cSelecionado.Codigo, cSelecionado.Nome, cSelecionado.Cpf, cSelecionado.Endereco);
                        vendaAtual.Vendedor = vSelecionado;
                        if (Carrinho.Produtos != null && Carrinho.Produtos.Any())
                        {
                            //pois assim, caso mexa no carrinho, a atualização aparecerá na venda.
                            vendaAtual.Produtos = Carrinho.Produtos;
                            //ou pode se fazer usando algum laço de repetição, adicionando novos objetos na lista.
                            Console.WriteLine("Venda criada com sucesso, pronta para ser finalizada. ");
                        }
                    }
                }

                else if (opcao == (int)Operacao.finalizarVenda)
                {
                    //pega os produtos do carrinho e joga na venda para finalizá-la e guardar o histórico dela.
                    vendaAtual.Produtos = CopiarProdutosParaOutraLista(Carrinho.Produtos);
                    vendaAtual.Cliente = new Cliente();
                    vendaAtual.Vendedor = new Vendedor();
                    vendaAtual.Finalizada = true;
                    Console.WriteLine($" Sua compra: {vendaAtual.Produtos}");
                    Console.WriteLine($" Seus dados: {vendaAtual.Cliente}");
                    Console.WriteLine($" Vendedor responsavel: {vendaAtual.Vendedor}");
                    Console.WriteLine($"Venda finalizada: {vendaAtual.Finalizada}");
                }

                Console.WriteLine(" Com base nos produtos cadastrados acima;");
                Console.WriteLine(" Informe a operação desejada:");
                Console.WriteLine(" 1 - Adcionair produto ao carrinho.");
                Console.WriteLine(" 2 - Limpar o carrinho.");
                Console.WriteLine(" 3 - Criar a ordem de venda.");
                Console.WriteLine(" 4 - Finalizar a venda.");
                Console.WriteLine(" 0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
                        
        }
    }

    enum Operacao
    {
        adicionarAoCarrinho = 1,
        limparCarrinho = 2,
        criarVenda = 3,
        finalizarVenda = 4,
        Sair = 0
    }
}

