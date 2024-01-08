using ProjetoPloomesMatheusChiga.AcoesUsuario;
using ProjetoPloomesMatheusChiga;
using ProjetoPloomesMatheusChiga.Modelos;

class Program
{
    static void Main(string[] args)
    {
        Usuario usuario = null;
        IMenu menu;

        if (usuario.GetType() == typeof(Professor))
        {
            menu = new MenuProfessor();
            menu.Menu(usuario);
        }
    }
}