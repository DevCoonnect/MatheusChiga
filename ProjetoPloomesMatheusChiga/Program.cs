using ProjetoPloomesMatheusChiga;

class Program
{
    static void Main(string[] args)
    {
        Treino treino1 = new Treino("Treino A", "Força e resistência");

        Exercicio exercicio1 = new Exercicio { Nome = "Supino Reto", Descricao = "Exercício para peitorais" };
        treino1.AdicionarExercicio(exercicio1);

        treino1.ExecutarTreino();
    }
}