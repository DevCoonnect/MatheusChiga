using ProjetoPloomesMatheusChiga.Modelos;
using System.ComponentModel;

namespace ProjetoPloomesMatheusChiga;

public class Treino
{
    private Tipo _tipo;
    private GrauDeDificuldade _grauDeDificuldade;
    private Objetivo _objetivo;
    private List<Exercicio> _exercicios;

    public Tipo Tipo { get; set; }

    public GrauDeDificuldade GrauDeDificuldade { get; set; }

    public Objetivo Objetivo { get; set; }

    public List<Exercicio> Exercicios{ get; private set; }
    public Treino(Tipo tipo, GrauDeDificuldade grauDeDificuldade, Objetivo objetivo, List<Exercicio> exercicios)
    {
        Tipo = tipo;
        GrauDeDificuldade = grauDeDificuldade;
        Objetivo = objetivo;

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
}
