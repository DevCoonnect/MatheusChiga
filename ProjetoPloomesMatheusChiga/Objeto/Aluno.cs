using ProjetoPloomesMatheusChiga.Enum;
using System.Text;

namespace ProjetoPloomesMatheusChiga.Objeto;
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
        var strb = new StringBuilder();
        foreach (var dia in Treinos)
        {
            strb.AppendLine($"{dia.Key} - {dia.Value.Tipo} - {dia.Value.GrauDeDificuldade}:");
            strb.AppendLine(dia.Value.ExibirTreinoUsuario());
        }
        Console.WriteLine(strb.ToString());
    }
}
