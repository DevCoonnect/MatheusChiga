using ProjetoPloomesMatheusChiga.Enum;
using System.Text;

namespace ProjetoPloomesMatheusChiga.Objeto;

public class Treino
{
    private GrupoMuscular _tipo;
    private GrauDeDificuldade _grauDeDificuldade;
    private List<Exercicio> _exercicios;

    public GrupoMuscular Tipo { get; set; }

    public GrauDeDificuldade GrauDeDificuldade { get; set; }

    public List<Exercicio> Exercicios{ get; private set; }
    public Treino(GrupoMuscular tipo, GrauDeDificuldade grauDeDificuldade, List<Exercicio> exercicios)
    {
        Tipo = tipo;
        GrauDeDificuldade = grauDeDificuldade;

        if (exercicios is null || exercicios.Count == 0)
        {
            throw new ArgumentException("A lista de exercícios não pode ser nula ou vazia");
        }

        Exercicios = exercicios ?? new List<Exercicio>();
    }

    public void AdicionarExercicio(string nome, int descanso, string repeticoes)
    {
        var exercicio = new Exercicio(nome, descanso, repeticoes);
        Exercicios.Add(exercicio);
    }

    public static void ExibirTreinoUsuario(Usuario usuario)
    {
        Console.Clear();
        Console.WriteLine($"Treino de {usuario.NomeUsuario}:");

        foreach (var dia in usuario.Treinos)
        {
            if (dia.Value != null)
            {
                Console.WriteLine($"{dia.Key} - {dia.Value.Tipo} - {dia.Value.GrauDeDificuldade}:");
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
