using ProjetoPloomesMatheusChiga.Enum;
using ProjetoPloomesMatheusChiga.Objeto;

namespace ProjetoPloomesMatheusChiga;

public class Seed
{
    public static List<Professor> Inicializador()
    {
        // Inicialize sua lista de professores aqui
        var professores = new List<Professor>
        {
            new Professor(1, "ProfA", "senhaA", Genero.Masculino),
            new Professor(2, "ProfB", "senhaB", Genero.Feminino),
            // Adicione mais professores conforme necessário
        };

        // Adicione alunos aos professores se necessário
        // Exemplo:
        professores[0].Alunos.Add(new Aluno(101, "AlunoA", "senhaAlunoA", Genero.Masculino));

        return professores;
    }
}
