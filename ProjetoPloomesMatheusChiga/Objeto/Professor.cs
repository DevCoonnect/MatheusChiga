using ProjetoPloomesMatheusChiga.Enum;

namespace ProjetoPloomesMatheusChiga.Objeto;

public class Professor : Usuario
{
    //Propriedade Alunos. Lista de Alunos
    public List<Aluno> Alunos { get; set; }
    //Construtor com parametros, matricula, nomeUsuario, senha, Genero
    public Professor(int matricula, string nomeUsuario, string senha, Genero genero) : base(matricula, nomeUsuario, senha, genero)
    {
        Alunos = new List<Aluno>();
    }
    
    public void AdicionarTreinoAluno(DiaDaSemana diaDaSemana, Treino treino, int matricula)
    {
        var aluno = Alunos.FirstOrDefault(a => a.Matricula == matricula);
        aluno.Treinos[diaDaSemana] = treino;
    }

    public void VisualizarTreinoAluno(int matricula)
    {
        var aluno = Alunos.FirstOrDefault(a => a.Matricula == matricula);
        Console.WriteLine($"Aluno: {aluno.NomeUsuario}");
        aluno.VisualizarTreino();
    }

    public override void VisualizarTreino()
    {
        Console.WriteLine("T");
    }
}
