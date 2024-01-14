using ProjetoPloomesMatheusChiga.Enum;
using ProjetoPloomesMatheusChiga.Interface;

namespace ProjetoPloomesMatheusChiga.Objeto;

//Classe Abstrata,é ser utilizada como classe pai para Professor e Aluno 
public abstract class Usuario : ITreino
{
    public int Matricula { get; set; }
    //Atributo
    private string _nome;
    //Propriedade NomeUsuario, não pode ter um nome menor que 3 caracteres
    public string NomeUsuario
    {
        get { return _nome; }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("O nome não pode conter menos do que 3 caracteres.");
            }
            else
            {
                _nome = value;
            }
        }
    }
    //Atributo
    private string _senha;
    //Propreidade Senha, não pode ter menos que 6 caracteres
    public string Senha
    {
        get { return _senha; }
        set
        {
            if (value.Length < 6)
            {
                Console.WriteLine("A senha deve conter no minimo 6 caracteres");
            }
            else
            {
                _senha = value;
            }
        }
    }
    //Propriedade Genero, capta o genêro do objeto Genêro
    public Genero Genero { get; set; }
    //Atributo
    private double _peso;
    //Propriedade Peso, não pode ser menor que 0.
    public double Peso
    {
        get { return _peso; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Peso não pode ser menor do que 0");
            }
            else
            {
                _peso = value;
            }
        }
    }
    //Atributo
    private double _altura;
    //Propriedade Altura, Não pode ser menor que 0
    public double Altura
    {
        get { return _altura; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Altura não pode ser menor do que 0");
            }
            else
            {
                _altura = value;
            }
        }
    }
    //Atributo
    private short _idade;
    //Propriedade Altura, Não pode ser menor que 0 e maior que 120
    public short Idade
    {
        get { return _idade; }
        set
        {
            if (value < 0 || value > 120)
            {
                Console.WriteLine("A idade tem de estar entre 0 e 120 anos.");
            }
            else
            {
                _idade = value;
            }
        }
    }
    //Propriedade Treino, a chave sendo DiaDaSemana e Treino sendo o valor.
    public Dictionary<DiaDaSemana, Treino> Treinos { get; private set; }
    //Construtor do usuário, com parâmetros matricula, nomeUsuario, senha e genero
    public Usuario(int matricula, string nomeUsuario, string senha, Genero genero)
    {
        Matricula = matricula;
        NomeUsuario = nomeUsuario;
        Senha = senha;
        Genero = genero;
        Treinos = new Dictionary<DiaDaSemana, Treino>
        {
            {
                DiaDaSemana.Segunda, null
            },
            {
                DiaDaSemana.Terca, null
            },
            {
                DiaDaSemana.Quarta, null
            },
            {
                DiaDaSemana.Quinta, null
            },
            {
                DiaDaSemana.Sexta, null
            },
            {
                DiaDaSemana.Sabado, null
            },
            {
                DiaDaSemana.Domingo, null
            }
        };
    }

    //Método criado para outras duas classes não abstratas
    public abstract void VisualizarTreino();
}
