using ProjetoPloomesMatheusChiga.Modelos.Enumerados;
using ProjetoPloomesMatheusChiga.Modelos;

namespace ProjetoPloomesMatheusChiga;

public class Seed
{
    public static List<Usuario> InicializarDados()
    {
        List<Usuario> usuarios = new List<Usuario>();

        // Exemplo de criação de um usuário
        Usuario usuario1 = new Usuario("Nome1", "Senha1", Genero.Masculino);
        AdicionarTreinoAoUsuario(usuario1);

        // Exemplo de criação de outro usuário
        Usuario usuario2 = new Usuario("Nome2", "Senha2", Genero.Feminino);
        AdicionarTreinoAoUsuario(usuario2);

        usuarios.Add(usuario1);
        usuarios.Add(usuario2);

        return usuarios;
    }  

    private static void AdicionarTreinoAoUsuario(Usuario usuario)
    {
        // Exemplo de criação de um treino
        Treino treino = new Treino(Tipo.Peito, GrauDeDificuldade.Intermediario, Objetivo.Hipertrofiar, new List<Exercicio> { new Exercicio("Cruxifixo", 60, "4x10") });
        treino.AdicionarExercicio("Supino", 120, "4x10");

        // Adicionar o treino ao usuário
        usuario.AdicionarTreino(DiaDaSemana.Segunda, treino);
    }
}