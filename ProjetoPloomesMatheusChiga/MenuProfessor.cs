using ProjetoPloomesMatheusChiga.AcoesUsuario.Treino;
using ProjetoPloomesMatheusChiga.Modelos;

namespace ProjetoPloomesMatheusChiga;

public class MenuProfessor : IMenu
{

    public void Menu(Usuario usuario)
    {
        bool continuarNoMenu = true;
        while (continuarNoMenu)
        {
            Console.Clear();
            Console.WriteLine("Menu do Professor:");
            Console.WriteLine("1. Lista de Alunos");
            Console.WriteLine("2. Exibir Treino");
            Console.WriteLine("3. Adicionar Treino");
            Console.WriteLine("4. Remover Treino");
            Console.WriteLine("5. Ficha do Aluno");
            Console.WriteLine("6. Taxa Metabólica Basal");
            Console.WriteLine("7. Índice de Massa Corporal");
            Console.WriteLine("8. Sair");

            Console.WriteLine("Escolha uma opção:");
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Exibir Treino");
                        break;
                    case 2:
                        Console.WriteLine("Adicionar Treino");
                        break;
                    case 3:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        continuarNoMenu = false;
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
        }
    }
}