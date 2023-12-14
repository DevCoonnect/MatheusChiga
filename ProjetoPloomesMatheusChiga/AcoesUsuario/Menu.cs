using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga.AcoesUsuario.Treino;
using ProjetoPloomesMatheusChiga.AcoesUsuario.IMC;

namespace ProjetoPloomesMatheusChiga.AcoesUsuario;

public class Menu
{
    public static void ExibirMenu(Usuario usuario)
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
                        ExibirTreino.ExibirTreinoUsuario(usuario);
                        break;
                    case 2:
                        Console.Clear();
                        MenuIMC.ExecutarMenu(usuario);
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
