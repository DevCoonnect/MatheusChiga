using ProjetoPloomesMatheusChiga.AcoesUsuario;
using ProjetoPloomesMatheusChiga;
using ProjetoPloomesMatheusChiga.Modelos;

class Program
{
    static void Main(string[] args)
    {
        List<Professor> usuarios = Seed.InicializarDados();

        Autenticacao autenticacao = new Autenticacao(usuarios);

        Professor usuarioAutenticado = null;

        do
        {
            Console.Clear();
            Console.Write("Digite a matrícula: ");
            string inputMatricula = Console.ReadLine()!;
            int.TryParse(inputMatricula, out int matricula);

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            usuarioAutenticado = autenticacao.AutenticarUsuario(matricula, senha) as Professor;

            if (usuarioAutenticado == null)
            {
                Console.WriteLine("Usuário ou senha inválidos. Tente novamente.");
                Console.ReadKey();
            }

        } while (usuarioAutenticado == null);

        if (usuarioAutenticado is Professor)
        {
            Menu.ExibirMenuProfessor(usuarioAutenticado);
        }
    }

}