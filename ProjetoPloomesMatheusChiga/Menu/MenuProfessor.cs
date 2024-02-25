using ProjetoPloomesMatheusChiga.Enum;
using ProjetoPloomesMatheusChiga.Interface;
using ProjetoPloomesMatheusChiga.Objeto;

namespace ProjetoPloomesMatheusChiga.Menu;

public class MenuProfessor : IMenu
{
    //Menu interativo do Professor, para verificar, adicionar e remover treinos e exercícios
    public void Menu(Usuario usuario)
    {
        bool continuarNoMenu = true;
        while (continuarNoMenu)
        {
            Console.Clear();
            Console.WriteLine("Menu do Professor:");
            Console.WriteLine("1. Lista de Alunos"); //             --->        Declarar dentro de Professor uma lista de Alunos para o Professor acessar
            Console.WriteLine("2. Exibir Treino"); //               --->        Acessar o Aluno para buscar seu treino
            Console.WriteLine("3. Adicionar Treino"); //            --->        Acessar o método que adicionaTreino para adicionar o treino buscado ao aluno em especifico
            Console.WriteLine("4. Remover Treino"); //              --->        Acessar o método que adicionaTreino para adicionar o treino buscado ao aluno em especifico
            Console.WriteLine("5. Ficha do Aluno"); //              --->        Questionário que o professor deverá responder para verificar IMC e TMB do Aluno em específico
            Console.WriteLine("6. Taxa Metabólica Basal"); //       --->        Acessar o Aluno em específico e verificar sua TMB
            Console.WriteLine("7. Índice de Massa Corporal"); //    --->        Acessar o Aluno em específico e verificar seu IMC
            Console.WriteLine("8. Sair"); //                        --->        Sair

            Console.WriteLine("Escolha uma opção:");
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                switch (escolha)
                {
                    // Dentro da classe MenuProfessor
                    case 1:
                        //Fazer métodos para diminuir complexidade do código.
                        Console.Clear();
                        Console.WriteLine("Lista de alunos:");
                        foreach (var aluno in ((Professor)usuario).Alunos)
                        {
                            Console.WriteLine($"Matrícula: {aluno.Matricula}, Nome: {aluno.NomeUsuario}");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Exibir Treino de Aluno");
                        Console.Write("Digite a matrícula do aluno: ");
                        if (int.TryParse(Console.ReadLine(), out int matriculaAluno))
                        {
                            ((Professor)usuario).VisualizarTreinoAluno(matriculaAluno);
                            //Não existe treino pressione em qualquer tecla para voltar
                        }
                        else
                        {
                            Console.WriteLine("Matrícula inválida. Tente novamente.");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        //Implemente a lógica para adicionar treino com seleção de grau de dificuldade
                        Console.Clear();
                        Console.WriteLine("Adicionar Treino");
                        Console.ReadKey();
                        break;
                    case 4:                        
                        Console.Clear();                        
                        Console.WriteLine("Remover Treino");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ficha do Aluno");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Taxa Metabólica Basal");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Índice de Massa Corporal");
                        Console.ReadKey();
                        break;
                    case 8:
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