using System;

namespace Lista_6_Exercicio_2
{
    /* Faça um programa que possua uma classe de veículos e tenha as seguintes classes básicas com os respectivos atributos:
     OBS: usar construtores para carregar os dados e criar instâncias das classes especializadas criadas.
    
    Motor;
    Tipo de motor;
    Tipo de combustível;
    Descrição;
    Potência;
    Torque;
    
     Modelo:
    Descrição;
    
     Marca:
    Descrição;
    País Origem;

     Veículo:
    Chassis;
    Ano;
    Modelo;
    Marca;
    Preço;
    Motor;

    Crie outras classes que caracterizem outros tipos de veículos e seus atributos específicos, como exemplo:
    Caminhão;
    */

    public enum TipoMotor
    {
        Combustao,
        Eletrico,
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Alcool,
        Diesel,
    }

    public class Motor
    {
        public TipoMotor TipoMotor { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
        public string Descricao { get; set; }
        public double Potencia { get; set; }
        public double Torque { get; set; }
        public Motor(TipoMotor tipoMotor, TipoCombustivel tipoCombustivel,
                     string descricao, double potencia, double torque)
        {
            this.TipoMotor = tipoMotor;
            this.TipoCombustivel = tipoCombustivel;
            this.Descricao = descricao;
            this.Potencia = potencia;
            this.Torque = torque;
        }

        public class Modelo
        {
            public string Descricao { get; set; }
            public Modelo(string descricao)
            {
                this.Descricao = descricao;
            }
        }

        public class Marca
        {
            public string Descricao { get; set; }
            public string PaisOrigem { get; set; }
            public Marca(string descricao, string paisOrigem)
            {
                this.Descricao = descricao;
                this.PaisOrigem = paisOrigem;
            }
        }

        public class Veiculo
        {
            public string chassis { get; set; }
            public string ano { get; set; }
            public Modelo modelo { get; set; }
            public Marca marca { get; set; }
            public double preco { get; set; }
            public Motor motor { get; set; }

            public Veiculo(string chassis, string ano, Modelo modelo, Marca marca, double preco, Motor motor)
            {
                this.chassis = chassis;
                this.ano = ano;
                this.modelo = modelo;
                this.marca = marca;
                this.preco = preco;
                this.motor = motor;
            }

            public Veiculo()
            {

            }

            static void Main(string[] args)
            {
                Console.WriteLine("Informe o modelo do veículo:");
                string entradaModelo = Console.ReadLine();
                Console.WriteLine("Informe o tipo de motor:");
                int entradaTipoMotor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o tipo de combustível:");
                int entradaTipoCombustivel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a descrição de motor:");
                string entradaDescMotor = Console.ReadLine();
                Console.WriteLine("Informe a potência do motor:");
                double entradaPotencia = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o torque do motor:");
                double entradaTorque = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Informe a descrição da marca ");
                string entradaDescMarca = Console.ReadLine();
                Console.WriteLine("Informe o país de origem da marca:");
                string entradaPaisorigemMarca = Console.ReadLine();
                Console.WriteLine("Informe o tipo de caçamba:");
                int entradaTipoCacamba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a quantidade de eixos:");
                string entradaEixos = Console.ReadLine();
                Console.WriteLine("Informe a capacidade de carga:");
                double entradaCapacidadeCarga = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe quantidade de marcha:");
                string entradaQtdMarcha = Console.ReadLine();
                Console.WriteLine("Informe o chassis:");
                string entradaChassis = Console.ReadLine();
                Console.WriteLine("Informe o ano:");
                string entradaAno = Console.ReadLine();

                Modelo modelo = new Modelo(entradaModelo);
                Motor motor = new Motor((TipoMotor)entradaTipoMotor, (TipoCombustivel)entradaTipoCombustivel,
                                        entradaDescMotor, entradaPotencia, entradaTorque);
                Marca marca = new Marca(entradaDescMarca, entradaPaisorigemMarca);
                Caminhao caminhao1 = new Caminhao((TipoCacamba)entradaTipoCacamba, entradaEixos, entradaCapacidadeCarga
                                                  , entradaQtdMarcha, modelo, motor, marca
                                                  , entradaChassis, entradaAno);

                Console.WriteLine("Descricao do modelo:" + caminhao1.modelo.Descricao);
                Console.WriteLine("Descricao do motor:" + caminhao1.motor.Descricao);
                Console.WriteLine("Descricao do motor:potência:" + caminhao1.motor.Potencia);
                Console.WriteLine("Descricao do motor:tipo combustível:" + caminhao1.motor.TipoCombustivel);
                Console.WriteLine("Descricao do motor:tipo do motor:" + caminhao1.motor.TipoMotor);
                Console.WriteLine("Descricao do motor:torque:" + caminhao1.motor.Torque);
                Console.WriteLine("Descricao do motor:marca:descrição:" + caminhao1.marca.Descricao);
                Console.WriteLine("Descricao do motor:marca:país origem:" + caminhao1.marca.PaisOrigem);
                Console.WriteLine("Descricao do motor:ano:" + caminhao1.ano);
                Console.WriteLine("Descricao do motor:chassis:" + caminhao1.chassis);
                Console.WriteLine("Descricao do motor:eixos:" + caminhao1.Eixos);
                Console.WriteLine("Descricao do motor:tipo caçamba:" + caminhao1.TipoCacamba);
                Console.WriteLine("Descricao do motor:capacidade de carga:" + caminhao1.CapacidadeCarga);
            }

        }

        public enum TipoCacamba
        {
            Basculante,
            Bau,
            Graneleiro,
            Container,
            Bitrem,
            Tanque
        }

        public class Caminhao : Veiculo
        {
            public TipoCacamba TipoCacamba { get; set; }
            public string Eixos { get; set; }
            public double CapacidadeCarga { get; set; }
            public string QuantidadeMarcha { get; set; }
            public Caminhao() { }
            public Caminhao(TipoCacamba tipoCacamba, string eixos, double capacidadeCarga, string quantidadeMarcha)
            {
                this.TipoCacamba = tipoCacamba;
                this.Eixos = eixos;
                this.CapacidadeCarga = capacidadeCarga;
                this.QuantidadeMarcha = quantidadeMarcha;
            }

            public Caminhao(TipoCacamba tipoCacamba, string eixos, double capacidadeCarga,
                            string quantidadeMarcha, Modelo modelo, Motor motor, Marca marca,
                            string chassis, string ano)
            {
                this.TipoCacamba = tipoCacamba;
                this.Eixos = eixos;
                this.CapacidadeCarga = capacidadeCarga;
                this.QuantidadeMarcha = quantidadeMarcha;
                this.modelo = modelo;
                this.motor = motor;
                this.marca = marca;
                this.chassis = chassis;
                this.ano = ano;
            }
            //public Caminhao(TipoCacamba tipoCacamba, string eixos, double capacidadeCarga, 
            //                string quantidadeMarcha, Modelo modelo, Motor motor, Marca marca,
            //                string chassis, string ano):base(chassis, ano, modelo,marca,motor)
            //{
            //    this.TipoCacamba = tipoCacamba;
            //    this.Eixos = eixos;
            //    this.CapacidadeCarga = capacidadeCarga;
            //    this.QuantidadeMarcha = quantidadeMarcha;
            //}
        }
    }
}
