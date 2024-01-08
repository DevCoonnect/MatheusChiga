using ProjetoPloomesMatheusChiga.Modelos;
using System.Text;

namespace ProjetoPloomesMatheusChiga.AcoesUsuario.Treino;

public class ExibirTreino
{
    public static void ExibirTreinoUsuario(Usuario usuario)
    {
        Console.Clear();
        Console.WriteLine($"Treino de {usuario.NomeUsuario}:");

        foreach (var dia in usuario.Treinos)
        {
            if (dia.Value != null)
            {
                Console.WriteLine($"{dia.Key} - {dia.Value.Tipo} - {dia.Value.GrauDeDificuldade} - {dia.Value.Objetivo}:");
                ExibirExercicios(dia.Value.Exercicios);
            }
            else
            {
                Console.WriteLine($"{dia.Key} - Nenhum treino cadastrado.");
            }
        }

        Console.ReadKey();
    }

    private static void ExibirExercicios(List<Exercicio> exercicios)
    {
        var strb = new StringBuilder();

        foreach (var exercicio in exercicios)
        {
            strb.AppendLine($"   - {exercicio.Nome} - Descanso: {exercicio.Descanso} segundos - Repetições: {exercicio.Repeticoes}");
        }

        Console.WriteLine(strb.ToString());
    }
}
