using ProjetoPloomesMatheusChiga.Modelos.Enumerados;
using ProjetoPloomesMatheusChiga.AcoesUsuario;
using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = Seed.InicializarDados();

        Autenticacao autenticacao = new Autenticacao(usuarios);

        Usuario usuarioAutenticado = null;

        do
        {
            Console.Clear();
            Console.Write("Nome de usuário: ");
            string nomeUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            usuarioAutenticado = autenticacao.AutenticarUsuario(nomeUsuario, senha);

            if (usuarioAutenticado == null)
            {
                Console.WriteLine("Usuário ou senha inválidos. Tente novamente.");
                Console.ReadKey();
            }

        } while (usuarioAutenticado == null);

        Menu.ExibirMenu(usuarioAutenticado);
    }
}