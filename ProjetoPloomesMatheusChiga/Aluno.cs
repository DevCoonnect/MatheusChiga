namespace ProjetoPloomesMatheusChiga.Modelos;

public class Aluno : Usuario
{
    public int MatriculaProfessor { get; set; }
    public Aluno(int matricula, string nomeUsuario, string senha, Genero genero) : base(matricula, nomeUsuario, senha, genero)
    {
        Matricula = matricula;
        NomeUsuario = nomeUsuario;
        Senha = senha;
        Genero = genero;
    }

    public override void VisualizarTreino()
    {
        Console.WriteLine("Visualizando...");
    }
}
