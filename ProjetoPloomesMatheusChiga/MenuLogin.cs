using ProjetoPloomesMatheusChiga.AcoesUsuario;
using ProjetoPloomesMatheusChiga.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPloomesMatheusChiga;

public class MenuLogin
{
    public void Registrar()
    {

    }

    public void MenuParaLogar()
    {
        List<Professor> usuarios = Seed.Inicializador();
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
            MenuProfessor.ExibirMenuProfessor(usuarioAutenticado);
        }
    }
}
