using ProjetoPloomesMatheusChiga.Enum;

namespace ProjetoPloomesMatheusChiga.Objeto;

public class Professor : Usuario
{
    public List<Aluno> Alunos { get; set; }
    public Professor(int matricula, string nomeUsuario, string senha, Genero genero) : base(matricula, nomeUsuario, senha, genero)
    {
        Alunos = new List<Aluno>();
    }

    public void AdicionarTreino(DiaDaSemana diaDaSemana, Treino treino)
    {
        Treinos[diaDaSemana] = treino;
    }

    public override void VisualizarTreino()
    {
        Console.WriteLine("Visualizando");
    }
}
