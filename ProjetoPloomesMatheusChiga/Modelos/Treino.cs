using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga.Modelos.Enumerados;

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

    public List<Exercicio> Exercicios
    {
        get { return _exercicios; }
        set 
        {
            if (value == null)
            {
                Console.WriteLine("A lista de exercícios não pode ser nula.");
            }
            else {
                _exercicios = value; 
            } 
        }
    }
    public Treino(Tipo tipo, GrauDeDificuldade grauDeDificuldade, Objetivo objetivo, List<Exercicio> exercicios)
    {
        Tipo = tipo;
        GrauDeDificuldade = grauDeDificuldade;
        Objetivo = objetivo;
        Exercicios = exercicios ?? new List<Exercicio>();
    }
}
