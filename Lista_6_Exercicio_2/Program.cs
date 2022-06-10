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
        public TipoMotor tipoMotor { get; set; }
        public TipoCombustivel tipoCombustivel { get; set; }
        public string descricao { get; set; }
        public string potencia { get; set; }
        public string torque { get; set; }
    }

    public class Modelo
    {
        public string descricao { get; set; }
    }

    public class Marca
    {
        public string descricao { get; set; }
        public string paisOrigem { get; set; }
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

        public Veiculo() { }
          
                

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public enum TipoCacamba
    {
        Basculante,
        Bau,
        Tanque,
    }

    public class Caminhao : Veiculo
    {
        public TipoCacamba TipoCacamba { get; set; }
        public string Eixos { get; set; }
        public double CapacidadeCarga { get; set; }
    }
}
