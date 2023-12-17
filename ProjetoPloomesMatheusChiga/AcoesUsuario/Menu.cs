using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga.AcoesUsuario.Treino;
using ProjetoPloomesMatheusChiga.AcoesUsuario.IMC;

namespace ProjetoPloomesMatheusChiga.AcoesUsuario;

public class Menu
{
    public static void ExibirMenuProfessor(Professor professor)
    {
        int escolha;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu do Professor:");
            Console.WriteLine("1. Exibir Treino");
            Console.WriteLine("2. Adicionar Treino");
            Console.WriteLine("3. TMB & IMC");
            Console.WriteLine("4. Sair");

            Console.WriteLine("Escolha uma opção:");
            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        ExibirTreino.ExibirTreinoUsuario(professor);
                        break;
                    case 2:
                        Console.WriteLine("Adicionar Treino");
                        // AdicionarTreino(professor);
                        break;
                    case 3:
                        Console.Clear();
                        MenuIMC.ExecutarMenu(professor);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }

        } while (escolha != 4);

    }
    public static void ExibirMenuAluno(Aluno aluno)
    {
        int escolha;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Treino");
            Console.WriteLine("2. TMB & IMC");
            Console.WriteLine("3. Sair");

            Console.WriteLine("Escolha uma opção:");
            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        ExibirTreino.ExibirTreinoUsuario(aluno);
                        break;
                    case 2:
                        Console.Clear();
                        MenuIMC.ExecutarMenu(aluno);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }

        } while (escolha != 3);
    }
}