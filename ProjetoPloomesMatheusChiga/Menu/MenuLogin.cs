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
    public void MenuParaLogar()
    {
        Usuario usuarioAutenticado = null;

        do
        {
            Console.Clear();
            Console.Write("Digite a matrícula: ");
            string inputMatricula = Console.ReadLine()!;
            int.TryParse(inputMatricula, out int matricula);

            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            usuarioAutenticado = AutenticarUsuario(matricula, senha);

            if (usuarioAutenticado == null)
            {
                Console.WriteLine("Usuário ou senha inválidos. Tente novamente.");
                Console.ReadKey();
            }

        } while (usuarioAutenticado == null);

        IMenu menu = GetMenu(usuarioAutenticado);
        menu.Menu(usuarioAutenticado);
    }

    private IMenu GetMenu(Usuario usuario)
    {
        return usuario switch
        {
            Aluno _ => new MenuAluno(),
            Professor _ => new MenuProfessor(),
            _ => throw new InvalidOperationException("Tipo de usuário não suportado."),
        };
    }

    public Usuario AutenticarUsuario(int matricula, string senha)
    {
        Professor professor = AutenticarProfessor(matricula, senha);

        if (professor != null)
        {
            return professor;
        }

        Aluno aluno = AutenticarAluno(matricula, senha);

        return aluno;
    }

    public Professor AutenticarProfessor(int matricula, string senha)
    {
        Professor professor = _professores.FirstOrDefault(u => u.Matricula == matricula);

        if (professor != null && professor.Senha.Equals(senha))
        {
            return professor;
        }

        return null;
    }
    public Aluno AutenticarAluno(int matricula, string senha)
    {
        foreach (var professorIndex in _professores)
        {
            Aluno aluno = professorIndex.Alunos.FirstOrDefault(u => u.Matricula == matricula);

            if (aluno != null && aluno.Senha.Equals(senha))
            {
                return aluno;
            }
        }
        throw new ArgumentException("Matrícula ou senha inválida para Aluno.");
    }
}
