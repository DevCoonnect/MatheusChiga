using ProjetoPloomesMatheusChiga.Modelos.Enumerados;
using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga.Modelos.Usuarios;

namespace ProjetoPloomesMatheusChiga;

public class Seed
{
    public static List<Professor> InicializarDados()
    {
        List<Professor> professores = new List<Professor>();
        List<Aluno> alunos = new List<Aluno>();

        // Exemplo de criação de um usuário
        Professor professor1 = new Professor(123, "Nome1", "Senha1", Genero.Masculino);
        Aluno aluno1 = new Aluno(1234,"Nome2", "Senha2", Genero.Masculino);
        AdicionarTreinoAoUsuario(professor1);

        alunos.Add(aluno1); 
        professores.Add(professor1);

        return professores;
    }  

<<<<<<< HEAD

    private static void AdicionarTreinoAoUsuario(Professor professor)
=======
    private static void AdicionarTreinoAoUsuario(Usuario usuario)
>>>>>>> acedc685a398e092ec2a956444615ea16cadaa13
    {
        // Exemplo de criação de um treino
        Treino treino = new Treino(Tipo.Peito, GrauDeDificuldade.Intermediario, Objetivo.Hipertrofiar, new List<Exercicio> { new Exercicio("Cruxifixo", 60, "4x10") });
        treino.AdicionarExercicio("Supino", 120, "4x10");

        // Adicionar o treino ao usuário
        professor.AdicionarTreino(DiaDaSemana.Segunda, treino);
    }
}