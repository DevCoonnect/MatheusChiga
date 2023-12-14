namespace ProjetoPloomesMatheusChiga;

public class Exercicio
{
    private string _nome;
    private int _descanso;
    private string _repeticoes;

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value == "" || value == null)
            {
                Console.WriteLine("O nome do exercício não pode vazio.");
            }
            else
            {
                _nome = value;
            }

        }
    }

    public int Descanso
    {
        get { return _descanso; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O tempo de descanso não pode ser negativo ou zero.");
            }
            _descanso = value;
        }
    }

    public string Repeticoes
    {
        get { return _repeticoes; }
        set
        {
            if (value == "" || value == null)
            {
                Console.WriteLine("As repetições não pode ser vazias.");
            }
            else
            {
                _repeticoes = value;
            }
        }
    }

    public Exercicio(string nome, int descanso, string repeticoes)
    {
        Nome = nome;
        Descanso = descanso;
        Repeticoes = repeticoes;
    }

    public static void AdicionarExercicio(List<Exercicio> listaExercicios, Exercicio novoExercicio)
    {
        if (listaExercicios == null)
        {
            Console.WriteLine("A lista de exercícios não pode ser nula.");
        }

        listaExercicios!.Add(novoExercicio);
    }
}
