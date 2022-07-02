using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista_6_Exercicio_7
{
    class Program
    {
        static List<Motorista> Motoristas = new List<Motorista>();
        static List<Caminhao> Caminhoes = new List<Caminhao>();
        static List<Viagem> Viagens = new List<Viagem>();
        static void Main(string[] args)
        {
            //Dados em Mock:
            Motoristas.Add(new Motorista() { Endereco = "AAAAAA", Nome = "BBBBBBB" });
            Motoristas.Add(new Motorista() { Endereco = "CCCC", Nome = "DDDDDDDD" });
            Motoristas.Add(new Motorista() { Endereco = "EEEEEEE", Nome = "FFFFF" });
            Motoristas.Add(new Motorista() { Endereco = "GGGGGG", Nome = "HHHHH" });
            Motoristas.Add(new Motorista() { Endereco = "IIIIIIIII", Nome = "JJJJJJ" });

            Caminhoes.Add(new Caminhao() { Modelo = "KKKKKKKK", Placa = "LLLLLLLLLL" });
            Caminhoes.Add(new Caminhao() { Modelo = "KKKKKKKK", Placa = "LLLLLLLLLL" });
            Caminhoes.Add(new Caminhao() { Modelo = "KKKKKKKK", Placa = "LLLLLLLLLL" });
            Caminhoes.Add(new Caminhao() { Modelo = "KKKKKKKK", Placa = "LLLLLLLLLL" });

            Operacoes operacao;
            Console.WriteLine("Informe a opção que deseja:");
            Console.WriteLine("0-Cadastrar um Motorista;");
            Console.WriteLine("1-Atualizar um Motorista;");
            Console.WriteLine("2-Remover um Motorista;");
            Console.WriteLine("3-Cadastrar um Caminhão;");
            Console.WriteLine("4-Atualizar um Caminhão;");
            Console.WriteLine("5-Remover um Caminhão;");
            Console.WriteLine("6-Cadastrar uma Viagem;");
            Console.WriteLine("7-Atualizar uma Viagem;");
            Console.WriteLine("8-Remover uma Viagem;");
            Console.WriteLine("9-Finalizar programa.");
            operacao = (Operacoes)Convert.ToInt32(Console.ReadLine());

            while (operacao != Operacoes.Sair)
            {
                switch (operacao)
                {
                    case Operacoes.CadastrarMotorista:
                        Motorista motorista = new Motorista();
                        Console.WriteLine("Informe o nome do Motorista");
                        motorista.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o endereço do Motorista");
                        motorista.Endereco = Console.ReadLine();
                        Motoristas.Add(motorista);
                        break;
                    case Operacoes.AtualizarMotorista:
                        //pedir uma entrada do usuário para encontrar o motorista (id);
                        Console.WriteLine("Informe o código do motorista");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Motorista mot = EncontrarMotorista(Motoristas, id);
                        if (mot != null)
                        {
                            Console.WriteLine("Informe o nome do motorista");
                            mot.Nome = Console.ReadLine();
                            Console.WriteLine("Informe o endereço do motorista");
                            mot.Endereco = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Motorista não encontrado.");
                        }
                        break;
                    case Operacoes.RemoverMotorista:
                        //pedir uma entrada do usuário para encontrar o motorista (id);
                        Console.WriteLine("Informe o código do motorista");
                        int idRemover = Convert.ToInt32(Console.ReadLine());
                        Motorista motRemover = EncontrarMotorista(Motoristas, idRemover);
                        if (motRemover != null)
                        {
                            Motoristas.Remove(motRemover);
                        }
                        else
                        {
                            Console.WriteLine("Informe o código do motorista");
                        }
                        break;
                    case Operacoes.CadastrarCaminhao:
                        Caminhao caminhao = new Caminhao();
                        Console.WriteLine("Informe a placa do caminhão");
                        caminhao.Placa = Console.ReadLine();
                        Console.WriteLine("Informe o modelo do caminhão");
                        caminhao.Modelo = Console.ReadLine();
                        Caminhoes.Add(caminhao);
                        break;
                    case Operacoes.AtualizarCaminhao:
                        Console.WriteLine("Informe o código do caminhão");
                        int idCaminhaoAtualizar = Convert.ToInt32(Console.ReadLine());
                        Caminhao caminhaoAtualizar = EncontrarCaminhao(Caminhoes, idCaminhaoAtualizar);
                        if (caminhaoAtualizar != null)
                        {
                            Console.WriteLine("Informe a placa do caminhão");
                            caminhaoAtualizar.Placa = Console.ReadLine();
                            Console.WriteLine("Informe o modelo do caminhão");
                            caminhaoAtualizar.Modelo = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Caminhão não encontrado.");
                        }
                        break;
                    case Operacoes.RemoverCaminhao:
                        Console.WriteLine("Informe o código do caminhão");
                        int idCaminhaoRemover = Convert.ToInt32(Console.ReadLine());
                        Caminhao caminhaoRemover = EncontrarCaminhao(Caminhoes, idCaminhaoRemover);
                        if (caminhaoRemover != null)
                        {
                            Caminhoes.Remove(caminhaoRemover);
                        }
                        else
                        {
                            Console.WriteLine("Caminhão não encontrado.");
                        }
                        break;
                    case Operacoes.CadastrarViagem:
                        Viagem viagem = new Viagem();
                        Console.WriteLine("Informe o código do motorista:");
                        int codigoMotoristaViagem = Convert.ToInt32(Console.ReadLine());
                        Motorista motoristaViagem = EncontrarMotorista(Motoristas, codigoMotoristaViagem);
                        if (motoristaViagem == null)
                        {
                            Console.WriteLine("Motorista não encontrado");
                            break;
                        }
                        Console.WriteLine("Informe o código do caminhão:");
                        int codigoCaminhaoViagem = Convert.ToInt32(Console.ReadLine());
                        Caminhao caminhaoViagem = EncontrarCaminhao(Caminhoes, codigoCaminhaoViagem);
                        if (caminhaoViagem == null)
                        {
                            Console.WriteLine("Caminhão não encontrado");
                            break;
                        }
                        viagem.Caminhao = caminhaoViagem;
                        viagem.Motorista = motoristaViagem;
                        Viagens.Add(viagem);
                        break;
                    case Operacoes.AtualizarViagem:
                        Console.WriteLine("Informe o código da viagem");
                        int codigoViagemAtualizar = Convert.ToInt32(Console.ReadLine());
                        Viagem viagemAtualizar = EncontrarViagem(Viagens, codigoViagemAtualizar);
                        if (viagemAtualizar != null)
                        {
                            Console.WriteLine("Informe o código do motorista novo");
                            int codigoMotViagemNovo = Convert.ToInt32(Console.ReadLine());
                            Motorista motoristaNovoViagem = EncontrarMotorista(Motoristas, codigoMotViagemNovo);
                            if (motoristaNovoViagem == null)
                            {
                                Console.WriteLine("Motorista não encontrado");
                                break;
                            }
                            Console.WriteLine("Informe o código do caminhão novo:");
                            int codigoCaminhaoNovoViagem = Convert.ToInt32(Console.ReadLine());
                            Caminhao caminhaoNovoViagem = EncontrarCaminhao(Caminhoes, codigoCaminhaoNovoViagem);
                            if (caminhaoNovoViagem == null)
                            {
                                Console.WriteLine("Caminhão não encontrado");
                                break;
                            }
                            viagemAtualizar.Caminhao = caminhaoNovoViagem;
                            viagemAtualizar.Motorista = motoristaNovoViagem;
                        }
                        else
                        {
                            Console.WriteLine("Viagem não encontrada");
                        }
                        break;
                    case Operacoes.RemoverViagem:
                        Console.WriteLine("Informe o código da viagem:");
                        int codigoViagemRemover = Convert.ToInt32(Console.ReadLine());
                        Viagem viagemRemover = EncontrarViagem(Viagens, codigoViagemRemover);
                        if (viagemRemover == null)
                        {
                            Console.WriteLine("Viagem não encontrada.");
                            break;
                        }
                        Viagens.Remove(viagemRemover);
                        break;
                }
                Console.WriteLine("Informe a opção que deseja:");
                Console.WriteLine("0-Cadastrar um Motorista;");
                Console.WriteLine("1-Atualizar um Motorista;");
                Console.WriteLine("2-Remover um Motorista;");
                Console.WriteLine("3-Cadastrar um Caminhão;");
                Console.WriteLine("4-Atualizar um Caminhão;");
                Console.WriteLine("5-Remover um Caminhão;");
                Console.WriteLine("6-Cadastrar uma Viagem;");
                Console.WriteLine("7-Atualizar uma Viagem;");
                Console.WriteLine("8-Remover uma Viagem;");
                Console.WriteLine("9-Finalizar programa.");
                operacao = (Operacoes)Convert.ToInt32(Console.ReadLine());
            }

            Operacoes2 operacao2;
            Console.WriteLine("Informe a opção que deseja:");
            Console.WriteLine("0-Listar todas as viagens;");
            Console.WriteLine("1-Listar todas as viagens de um mesmo motorista (usando o nome);");
            Console.WriteLine("2-Listar todas as viagens que possuem um mesmo caminhão (usando o modelo do caminhao);");
            Console.WriteLine("3-Listar todos os caminhões que fizeram uma viagem com um determinado motorista (usando o nome do motorista);");
            Console.WriteLine("4-Listar todas as viagens de um caminhão em específico e um motorista específico (usando a placa do caminhão e o nome do motorista);");
            Console.WriteLine("5-Listar todas as viagens em que um determinado motorista não estava (usando o nome do motorista);");
            Console.WriteLine("6-Listar todas as viagens em que determinado motorista e determinado caminhão não estavam (usando o nome do motorista e a placa do caminhão);");
            Console.WriteLine("7-Finalizar programa."); 
            operacao2 = (Operacoes2)Convert.ToInt32(Console.ReadLine());

            while (operacao2 != Operacoes2.Sair)
            {
                switch (operacao2)
                {
                    case Operacoes2.ListarTodasViagens:
                        Viagem ListarViagens()
                        break;
                    case Operacoes2.ListarTodosCaminhoesComMesmoMotorista:
                        
                        break;
                    case Operacoes2.ListarViagensCaminhaoComMotorista:
                        
                        break;
                    case Operacoes2.ListarViagensMesmoCaminhao:
                        
                        break;
                    case Operacoes2.ListarViagensMesmoMotorista:
                        
                        break;
                    case Operacoes2.ListarViagensQueMotoristaComCaminhaoNaoEstava:
                        
                        break;
                    case Operacoes2.ListarViagensQueMotoristaNaoEstava:                       
                            
                        break;
                    case Operacoes2.Sair:
                        
                        break;
                   
                }
                Console.WriteLine("Informe a opção que deseja:");
                Console.WriteLine("0-Listar todas as viagens;");
                Console.WriteLine("1-Listar todas as viagens de um mesmo motorista (usando o nome);");
                Console.WriteLine("2-Listar todas as viagens que possuem um mesmo caminhão (usando o modelo do caminhao);");
                Console.WriteLine("3-Listar todos os caminhões que fizeram uma viagem com um determinado motorista (usando o nome do motorista);");
                Console.WriteLine("4-Listar todas as viagens de um caminhão em específico e um motorista específico (usando a placa do caminhão e o nome do motorista);");
                Console.WriteLine("5-Listar todas as viagens em que um determinado motorista não estava (usando o nome do motorista);");
                Console.WriteLine("6-Listar todas as viagens em que determinado motorista e determinado caminhão não estavam (usando o nome do motorista e a placa do caminhão);");
                Console.WriteLine("7-Finalizar programa.");
                operacao2 = (Operacoes2)Convert.ToInt32(Console.ReadLine());
            }
        }

    
        static Motorista EncontrarMotorista(List<Motorista> motoristas, int id)
        {
            //return motoristas.Find(x=> x.Id == id);
            //return motoristas.Where(x=> x.Id == id);
            //vai buscar o motorista que possua o "Id" informado e vai retornar;
            //se ele não encontrar, ele vai retornar null.
            return motoristas.SingleOrDefault(x => x.Id == id);
        }
        static Caminhao EncontrarCaminhao(List<Caminhao> caminhoes, int id)
        {
            return caminhoes.SingleOrDefault(x => x.Id == id);
        }
        static Viagem EncontrarViagem(List<Viagem> viagens, int id)
        {
            return viagens.SingleOrDefault(x => x.Id == id);
        }
        
        public static List<Viagem> ListarViagens(List<Viagem> viagens, int id)
        {
            //consulta usando linq:
            var viagensFeitas = viagens.Where(x => x.Id == (id)).ToList();
            return viagensFeitas;
        }

        public static List<Motorista> MostrarViagensDeMotorista(List<Motorista> motoristas, string Nome)
        {
            //consulta usando linq:
            var viagensDoMotorista = motoristas.Where(x => x.Nome.Contains(Nome)).ToList();
            return viagensDoMotorista;
        }

    }
}
