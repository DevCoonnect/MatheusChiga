using ProjetoPloomesMatheusChiga.Objeto;
using ProjetoPloomesMatheusChiga.Interface;

namespace ProjetoPloomesMatheusChiga.Menu;

public class MenuAluno : IMenu
{
    public void Menu(Usuario usuario)
    {
        bool continuarNoMenu = true;
        while (continuarNoMenu)
        {
            Console.Clear();
            Console.WriteLine("Menu do Aluno:");
            Console.WriteLine("1. Exibir Treino");   //             --->    Acessar o Aluno para buscar seu treino
            Console.WriteLine("2. Taxa Metabólica Basal"); //       --->    Acessar o Aluno em específico e verificar sua TMB
            Console.WriteLine("3. Índice de Massa Corporal"); //    --->    Acessar o Aluno em específico e verificar seu IMC
            Console.WriteLine("4. Sair"); //                        --->    Sair

            Console.WriteLine("Escolha uma opção:");
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Exibir Treino");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Taxa Metabólica Basal");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Índice de Massa Corporal");
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
