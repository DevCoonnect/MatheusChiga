using ProjetoPloomesMatheusChiga.AcoesUsuario.Treino;
using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga.Modelos.Enumerados;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoPloomesMatheusChiga.AcoesUsuario.IMC;

public class MenuIMC
{
    private static double ObterEntradaDouble(string prompt)
    {
        double valor;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out valor));
        return valor;
    }

    private static short ObterEntradaInt(string prompt)
    {
        short valor;
        do
        {
            Console.Write(prompt);
        } while (!short.TryParse(Console.ReadLine(), out valor));
        return valor;
    }

    public static void PerguntarAlturaPesoIdade(Usuario usuario)
    {
        Console.Clear();
        Console.WriteLine("Informe suas informações:");

        usuario.Altura = ObterEntradaDouble("Altura (em metros): ");
        usuario.Peso = ObterEntradaDouble("Peso (em kg): ");
        usuario.Idade = ObterEntradaInt("Idade: ");
    }
    public static void ExibirMenuIMC()
    {
        Console.Clear();
        Console.WriteLine("1. Perguntas");
        Console.WriteLine("2. Calcular IMC");
        Console.WriteLine("3. Calcular TMB");
        Console.WriteLine("0. Sair");
    }

    public static void CalcularIMC(Usuario usuario)
    {
        Console.Clear();
        double imc = usuario.Peso / Math.Pow(usuario.Altura, 2);
        Console.WriteLine($"IMC: {imc}");
        Console.ReadKey();
    }

    public static void CalcularTMB(Usuario usuario)
    {
        Console.Clear();
        double tmb;

        if (usuario.Genero == Genero.Masculino)
        {
            tmb = 66.5 + (13.75 * usuario.Peso) + (5.003 * usuario.Altura * 100) - (6.75 * usuario.Idade);
        }
        else
        {
            tmb = 655.1 + (9.563 * usuario.Peso) + (1.850 * usuario.Altura * 100) - (4.676 * usuario.Idade);
        }

        Console.WriteLine($"TMB: {tmb} calorias por dia");
        Console.ReadKey();
    }

    public static void ExecutarMenu(Usuario usuario)
    {
        int escolha;
        do
        {
            ExibirMenuIMC();
            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out escolha))
            {
                switch (escolha)
                {
                    case 1:
                        PerguntarAlturaPesoIdade(usuario);
                        break;
                    case 2:
                        CalcularIMC(usuario);
                        break;
                    case 3:
                        CalcularTMB(usuario);
                        break;
                    case 0:
                        Menu.ExibirMenu(usuario);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

        } while (escolha != 0);
    }
}
