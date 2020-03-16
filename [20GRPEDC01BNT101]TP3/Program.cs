using DomainTP3;
using InfraEstrutura.Data;
using System;
using System.Globalization;

namespace ConsoleAppTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

            var repositorioDb = new AniversarianteDB();

            const string pressioneQualquerTecla = "Pressione qualquer tecla para exibir o menu principal...";

            string opcaoEscolhida;
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Gerenciamento de Aniversarios");
                Console.WriteLine("1 - Pesquisar pessoas");
                Console.WriteLine("2 - Adicionar nova pessoa");
                Console.WriteLine("3 - Sair");

                opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.WriteLine("Digite o nome ou parte do nome da(o) aniversariante que deseja pesquisar:");
                        var termoDePesquisa = Console.ReadLine();
                        var buscaAniversariante = repositorioDb.Pesquisar(termoDePesquisa);

                        if (buscaAniversariante.Count > 0)
                        {
                            Console.WriteLine($"Selecione uma das opções abaixo para os detalhes do aniversariante:");
                            for (var index = 0; index < buscaAniversariante.Count; index++)
                                Console.WriteLine($"{index} - Aniversariante: {buscaAniversariante[index].Nome}");

                            ushort indexAExibir;
                            if (!ushort.TryParse(Console.ReadLine(), out indexAExibir) || indexAExibir >= buscaAniversariante.Count)
                            {
                                Console.WriteLine($"Opcao inválida! {pressioneQualquerTecla}");
                                Console.ReadKey();
                                break;
                            }

                            if (indexAExibir < buscaAniversariante.Count)
                            {
                                var aniversarianteEncontrado = buscaAniversariante[indexAExibir];

                                Console.WriteLine("Dados do aniversariante:");
                                Console.WriteLine($"Nome completo: {aniversarianteEncontrado.Nome}");
                                Console.WriteLine($"DataNascimento: { aniversarianteEncontrado.DataNascimento}");

                                var tempo = aniversarianteEncontrado.CalcularDiasParaAniversario();
                                if (tempo.Days > 0)
                                    Console.Write($"Falta(m) {tempo.Days} dia(s) para esse aniversário. {pressioneQualquerTecla}");
                                else if (tempo.Days == 0)
                                    Console.Write($"Parabéns. Você está fazendo aniversário hoje! {pressioneQualquerTecla}");
                                else
                                    Console.Write($"Você já fez aniversário neste ano. {pressioneQualquerTecla}");

                                Console.WriteLine(pressioneQualquerTecla);
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Não foi encontrado nenhum aniversariante! {pressioneQualquerTecla}");
                            Console.ReadKey();
                        }
                        break;

                    case "2":

                        Console.WriteLine("Informe o nome da(0) aniversariante que deseja adicionar");
                        var nome = Console.ReadLine();

                        Console.WriteLine("Informe o sobrenome(o) da aniversariante que deseja adicionar");
                        var sobreNome = Console.ReadLine();

                        Console.WriteLine("Informe a data de nascimento no formato dd/MM/yyyy");
                        DateTime inputDataNascimento;
                        if (!DateTime.TryParse(Console.ReadLine(), out inputDataNascimento))
                        {
                            Console.WriteLine($"Data de nascimento não permitido! Dados descartados! {pressioneQualquerTecla}");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Os Dados do aniversariante estão corretos? ");
                        Console.WriteLine($"Nome: {nome} {sobreNome}");
                        Console.WriteLine($"Data de Nascimento: {inputDataNascimento: dd/MM/yyyy}");
                        Console.WriteLine("1 - Sim \n2 - Não");
                        var opcaoAdicionar = Console.ReadLine();

                        if (opcaoAdicionar == "1")
                        {
                            var aniversariante = new Aniversariante(nome, sobreNome, Convert.ToDateTime(inputDataNascimento));

                            repositorioDb.Adicionar(aniversariante);

                            Console.WriteLine($"Aniversariante adicionado com sucesso! {pressioneQualquerTecla}");
                        }
                        else if (opcaoAdicionar == "2")
                            Console.WriteLine($"Dados descartados! {pressioneQualquerTecla}");
                        else
                            Console.WriteLine($"Opção inválida! {pressioneQualquerTecla}");

                        Console.ReadKey();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine($"Opção inválida! {pressioneQualquerTecla}");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcaoEscolhida != "3");
        }
    }
}
