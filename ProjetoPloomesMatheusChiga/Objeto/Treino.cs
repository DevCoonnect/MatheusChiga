using ProjetoPloomesMatheusChiga.Enum;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoPloomesMatheusChiga.Objeto;

public class Treino
{
    //Atributo
    private GrupoMuscular _tipo;
    //Atributo
    private GrauDeDificuldade _grauDeDificuldade;
    //Propriedade Tipo
    public GrupoMuscular Tipo { get; set; }
    //Propriedade GrauDeDificuldade
    public GrauDeDificuldade GrauDeDificuldade { get; set; }
    //Propriedade Exercicios, lista de exercicios
    public List<Exercicio> Exercicios{ get; private set; }
    //Construtor do Treino, paramentros, tipo, grauDeDificuldade e Exercícios
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
    //Método para adicionar um exercício
    public void AdicionarExercicio(string nome, int descanso, string repeticoes)
    {
        //variável exercício para o objeto(Tipo) e declarar os parametros
        var exercicio = new Exercicio(nome, descanso, repeticoes);
        //Adiciona o exercício a Lista
        Exercicios.Add(exercicio);
    }
    public string ExibirTreinoUsuario()
    {
        Console.Clear();
        return ExibirExercicios();
    }
    private string ExibirExercicios()
    {
        var strb = new StringBuilder();

        foreach (var exercicio in Exercicios)
        {
            //Encapsulamento
            strb.AppendLine(exercicio.RetornarExercicio());
        }

        return strb.ToString();
    }
}
