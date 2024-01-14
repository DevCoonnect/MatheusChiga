using ProjetoPloomesMatheusChiga.Interface;
using ProjetoPloomesMatheusChiga.Objeto;

namespace ProjetoPloomesMatheusChiga.Menu;

public class MenuLogin
{
    private List<Professor> _professores;

    public MenuLogin(List<Professor> professores)
    {
        _professores = professores;
    }

    public Usuario AutenticarUsuario(int matricula, string senha)
    {
        var professor = _professores.FirstOrDefault(u => u.Matricula == matricula);
        if (professor is not null)
        {
            if (professor.Senha.Equals(senha))
            {
                return professor;
            }
            throw new ArgumentException("Cara a senha ta errada");
        }
        foreach (var professorIndex in _professores)
        {
            var aluno = professorIndex.Alunos.FirstOrDefault(u => u.Matricula == matricula);
            if (aluno is not null)
            {
                if (aluno.Senha.Equals(senha))
                {
                    return aluno;
                }
                throw new ArgumentException("Cara a senha ta errada. ft professor Lotti");
            }
        }
        return null;
    }
    public void RegistrarAluno()
    {

    }

    public void MenuParaLogar()
    {
        //List<Professor> usuarios = Seed.Inicializador();
        //MenuLogin autenticacao = new MenuLogin(usuarios);
        Professor usuarioAutenticado = null;

        do
        {
            Console.Clear();
            Console.Write("Digite a matrícula: ");
            string inputMatricula = Console.ReadLine()!;
            int.TryParse(inputMatricula, out int matricula);

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            //usuarioAutenticado = autenticacao.AutenticarUsuario(matricula, senha) as Professor;

            if (usuarioAutenticado == null)
            {
                Console.WriteLine("Usuário ou senha inválidos. Tente novamente.");
                Console.ReadKey();
            }

        } while (usuarioAutenticado == null);

        IMenu menuProfessor = new MenuProfessor();

        if (usuarioAutenticado is Professor)
        {
            menuProfessor.Menu(usuarioAutenticado);
        }
    }
}
