using System;

namespace Lista_6_Exercicio_3
{
    /*Faça um programa que grave os dados de um vendedor e de um cliente em uma venda.
     
      Vendedor
    -Nome;
    -Código Crachá;

      Cliente
    -Nome;
    -CPF;
    -Endereço;

      Venda 
    -Valor total na venda;
    -Vendedor;
    -Cliente;

    Depois, crie dois vendedores, dois clientes e cadastre duas vendas no programa principal.
     */
    public class Vendedor
    {
        public string NomeVendedor { get; set; }
        public string CodigoCracha { get; set; }

        public Vendedor(string NomeVendedor, string CodigoCracha)
        {
            this.NomeVendedor = NomeVendedor;

            this.CodigoCracha = CodigoCracha;
        }
    }
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        public Cliente(string NomeCliente, string Cpf, string Endereco)
        {
            this.NomeCliente = NomeCliente;

            this.Cpf = Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");

            this.Endereco = Endereco;
        }
    }
    public class Venda
    {
        public double ValorTotalVenda { get; set; }
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }       

        public Venda (double ValorTotalVenda, Vendedor Vendedor, Cliente Cliente)
        {
            this.ValorTotalVenda = ValorTotalVenda;
            this.Vendedor = Vendedor;
            this.Cliente = Cliente;
        }

        static void Main(string[] args)
        {
            Vendedor Vendedor1 = new Vendedor("roberto", "01");
            Console.WriteLine("Nome do vendedor:" + Vendedor1.NomeVendedor);
            Console.WriteLine("Código do crachá:" + Vendedor1.CodigoCracha);

            //pular linha
            Console.WriteLine();

            Vendedor Vendedor2 = new Vendedor("Carlos", "02");
            Console.WriteLine("Nome do vendedor:" + Vendedor2.NomeVendedor);
            Console.WriteLine("Código do crachá:" + Vendedor2.CodigoCracha);

            //pular linha
            Console.WriteLine();

            Cliente Cliente1 = new Cliente("Tim", "06498715495", "Av.Brasil, 933 - SC");
            Console.WriteLine("Nome do cliente:" + Cliente1.NomeCliente);
            Console.WriteLine("CPF:" + Cliente1.Cpf);
            Console.WriteLine("Endereço:" + Cliente1.Endereco);

            //pular linha
            Console.WriteLine();

            Cliente Cliente2 = new Cliente("Maia", "98457768156", "Rua Tamanduá, 1054 - BH");
            Console.WriteLine("Nome do cliente:" + Cliente2.NomeCliente);
            Console.WriteLine("CPF:" + Cliente2.Cpf);
            Console.WriteLine("Endereço:" + Cliente2.Endereco);

            //pular linha
            Console.WriteLine();

            Venda Venda1 = new Venda(10000, Vendedor1, Cliente1);
            Console.WriteLine($"Valor total da venda:{Venda1.ValorTotalVenda:C2}");
            Console.WriteLine($"Quem fez a venda foi:{Vendedor1.NomeVendedor}");
            Console.WriteLine($"Quem efetuou a compra foi:{Cliente1.NomeCliente}");

            //pular linha
            Console.WriteLine();

            Venda Venda2 = new Venda(5000, Vendedor2, Cliente2);
            Console.WriteLine($"Valor total da venda:{Venda2.ValorTotalVenda:C2}");
            Console.WriteLine($"Quem fez a venda foi:{Vendedor2.NomeVendedor}");
            Console.WriteLine($"Quem efetuou a compra foi:{Cliente2.NomeCliente}");
        }
    }
}