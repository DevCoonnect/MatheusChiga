using ProjetoPloomesMatheusChiga.Menu;
using ProjetoPloomesMatheusChiga.Objeto;
using ProjetoPloomesMatheusChiga;

class Program
{
    static void Main(string[] args)
    {
        List<Professor> professores = Seed.Inicializador();
        MenuLogin autenticacao = new MenuLogin(professores);
        try
        {
            autenticacao.MenuParaLogar();
        }
        catch (ArgumentException ax)
        {
            Console.WriteLine(ax.Message);
            Thread.Sleep(3000);
            autenticacao.MenuParaLogar();
        }
        
        /*        
        Inicializadores:
        - Program.cs                        -->      Inserir método que inicializa Program.cs
        - Seed                              -->      Criar um Seed
        
        Objetos: 
        - Usuario                           -->      Verificar objeto e documentar métodos, propriedades e suas funções
        - Professor : Usuario (Herança)     -->      Verificar objeto e documentar métodos, propriedades e suas funções
        - Aluno : Usuario (Herança)         -->      Verificar objeto e documentar métodos, propriedades e suas funções
        - Treino                            -->      Verificar objeto e documentar métodos, propriedades e suas funções
        - Exercicio                         -->      Verificar objeto e documentar métodos, propriedades e suas funções

        Interfaces:
        - IMenu                             -->      Verificar uso da Interface
        - ITreino                           -->      Criar a Interface

        Classes para ações:                 -->      Verificar e documentar
        - MenuLogin : IMenu                 -->      Verificar e documentar
        - MenuProfessor : IMenu             -->      Verificar e documentar
        - MenuAluno : IMenu                 -->      Verificar e documentar
         */
    }
}