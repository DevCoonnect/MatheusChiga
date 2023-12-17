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
        Validator(nome, descanso, repeticoes);
        Nome = nome;
        Descanso = descanso;
        Repeticoes = repeticoes;
    }

    public void Validator(string nome, int descanso, string repeticoes)
    {
        if (string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("Nome não pode ser nulo.");
        }
        if (descanso < 0)
        {
            throw new ArgumentException("Descanso não pode ser menor que 0.");
        }
        if (string.IsNullOrEmpty(repeticoes))
        {
            throw new ArgumentException("Nome não pode ser nulo.");
        }
    }
}
