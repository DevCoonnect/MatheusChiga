using ProjetoPloomesMatheusChiga.Modelos;
using ProjetoPloomesMatheusChiga.Modelos.Usuarios;

namespace ProjetoPloomesMatheusChiga.AcoesUsuario;

public class Autenticacao
{
    private List<Professor> _professores;

    public Autenticacao(List<Professor> professores)
    {
        _professores = professores;
    }

    public Usuario AutenticarUsuario(int matricula, string senha)
    {
        var professor = _professores.FirstOrDefault(u => u.Matricula== matricula);
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
}
