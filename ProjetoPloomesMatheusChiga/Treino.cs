namespace ProjetoPloomesMatheusChiga;

public class Treino
{
    public string Nome { get; set; }
    public string Objetivo { get; set; }
    public List<Exercicio> Exercicios { get; set; }

    public Treino(string nome, string objetivo)
    {
        Nome = nome;
        Objetivo = objetivo;
        Exercicios = new List<Exercicio>();
    }
    public virtual void AdicionarExercicio(Exercicio exercicio)
    {
        Exercicios.Add(exercicio);
        Console.WriteLine($"Exercício {exercicio.Nome} adicionado ao treino {Nome}.");
    }

    public virtual void ExecutarTreino()
    {
        Console.WriteLine($"Executando o treino {Nome}...");
        foreach (var exercicio in Exercicios)
        {
            Console.WriteLine($"Realizando {exercicio.Nome}...");
        }
    }
}
