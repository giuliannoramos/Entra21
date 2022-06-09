using System;

namespace Lista_6_Exercicio_1
{
    /*Modele um funcionário.Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salario(double), a data de entrada de admissão(string), seu RG(string) e
    um valor booleano que indique se o funcionário ainda está ativo na empresa ou se já foi mandado em bora.Você deve criar alguns métodos de acordo com sua necessidade.
    Além deles , crie um método "bonifica" que aumenta o salário do funcionário de acordo com o parâmetro passado como argumento.Crie, também, um método "Demite", que não
    recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.*/

    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataAdmissao { get; set; }
        public string Rg { get; set; }
        public bool Ativo { get; set; }


        public Funcionario(string Nome, string Departamento, double Salario, string Admissao, string Rg, bool Ativo)
        {
            this.Nome = Nome;
            this.Departamento = Departamento;
            this.Salario = Salario;
            this.DataAdmissao = Admissao;
            this.Rg = Rg;
            this.Ativo = Ativo;
        }

        public Funcionario()
        {

        }

        public void Bonifica(double valor)
        {
            this.Salario += valor;
        }

        public void Demite(bool status)
        {
            this.Ativo = status;
        }


        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("Giulianno", "Financeiro", 2000, "08/06/2022", "44.480.492-4", true);
            Console.WriteLine("Nome:" + funcionario1.Nome);
            Console.WriteLine("Departamento:" + funcionario1.Departamento);
            Console.WriteLine("Salário:R$" + funcionario1.Salario);
            Console.WriteLine("Admitido em:" + funcionario1.DataAdmissao);
            Console.WriteLine("RG:" + funcionario1.Rg);
            Console.WriteLine("Ativo:" + funcionario1.Ativo);
            funcionario1.Bonifica(1500);
            //pular linha
            Console.WriteLine();

            Funcionario funcionario2 = new Funcionario("Lechinski", "TI", 2500, "08/06/2022", "69.750.298-4", true);
            Console.WriteLine("Nome:" + funcionario2.Nome);
            Console.WriteLine("Departamento:" + funcionario2.Departamento);
            Console.WriteLine("Salário:R$" + funcionario2.Salario);
            Console.WriteLine("Admitido em:" + funcionario2.DataAdmissao);
            Console.WriteLine("RG:" + funcionario2.Rg);
            Console.WriteLine("Ativo:" + funcionario2.Ativo);
            funcionario2.Demite(false);
        }

    }
}
