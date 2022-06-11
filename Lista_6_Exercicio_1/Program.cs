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


        public Funcionario(string Nome, string Departamento, double Salario, string DataAdmissao, string Rg, bool Ativo)
        {
            this.Nome = Nome;

            this.Departamento = Departamento;

            this.Salario = Salario;

            this.DataAdmissao = Convert.ToUInt64(DataAdmissao).ToString(@"00\/00\/0000");

            this.Rg = Convert.ToUInt64(Rg).ToString(@"00\.000\.000\-0");

            this.Ativo = Ativo;
        }

        public Funcionario()
        {

        }

        public void Bonifica(double valor)
        {
            this.Salario += valor;
            Console.WriteLine($"Salario atual após bonificação de {valor:C2} é: {Salario:C2}");
        }

        public void Demite()
        {
            bool status = false;
            this.Ativo = status;
            Console.WriteLine($"Funcionario foi demitido por justa causa.");
        }

        public void PreencherDados()
        {
            Console.WriteLine("Insira o nome do funcionário: ");
            this.Nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o departamento: ");
            this.Departamento = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o salário atual: ");
            this.Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a data em que foi admitido: ");
            this.DataAdmissao = Convert.ToUInt64(Console.ReadLine()).ToString(@"00\/00\/0000");

            Console.WriteLine("Insira o RG: ");
            this.Rg = Convert.ToUInt64(Console.ReadLine()).ToString(@"00\.000\.000\-0");

            Console.WriteLine("Ainta esta ativo na empresa? (digite True para sim, ou False para não): ");
            this.Ativo = Convert.ToBoolean(Console.ReadLine());
        }
    }
    public class Program
    { 
        static void Main(string[] args)
        {
            //preenchimento estático, com construtor preenchido, só posso chamar o que esta dentro do construtor;
            Funcionario funcionario1 = new Funcionario("Giulianno", "Financeiro", 2000, "08062022", "444804924", true);
            Console.WriteLine("Nome:" + funcionario1.Nome);
            Console.WriteLine("Departamento:" + funcionario1.Departamento);
            Console.WriteLine($"Salário:{funcionario1.Salario:C2}");
            Console.WriteLine("Admitido em:" + funcionario1.DataAdmissao);
            Console.WriteLine("RG:" + funcionario1.Rg);
            funcionario1.Demite();
            Console.WriteLine("Ativo:" + funcionario1.Ativo);
            

            //pular linha
            Console.WriteLine();

            //usuário preenche, com contrutor vazio, posso puxar oq quiser.          
            Funcionario funcionario2 = new Funcionario();
            funcionario2.PreencherDados();
            Console.WriteLine("Nome:" + funcionario2.Nome);
            Console.WriteLine("Departamento:" + funcionario2.Departamento);
            Console.WriteLine($"Salário:{funcionario2.Salario:C2}");
            Console.WriteLine($"Admitido em:{funcionario2.DataAdmissao}");
            Console.WriteLine("RG:" + funcionario2.Rg);            
            Console.WriteLine("Ativo:" + funcionario2.Ativo);
            funcionario2.Bonifica(1500);
        }

    }
}
