using ProjetoPloomesMatheusChiga.Modelos;

namespace ProjetoPloomesMatheusChiga.AcoesUsuario;

public class Autenticacao
{
    private List<Usuario> usuarios;

    public Autenticacao(List<Usuario> usuarios)
    {
        this.usuarios = usuarios;
    }

    public Usuario AutenticarUsuario(string nomeUsuario, string senha)
    {
        return usuarios.Find(u => u.NomeUsuario == nomeUsuario && u.Senha == senha);
    }
}
