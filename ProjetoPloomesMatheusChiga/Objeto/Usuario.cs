using ProjetoPloomesMatheusChiga.Enum;
using ProjetoPloomesMatheusChiga.Interface;

namespace ProjetoPloomesMatheusChiga.Objeto;

public abstract class Usuario : ITreino
{
    public int Matricula { get; set; }
    private string _nome;
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
    private string _senha;
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
    public Genero Genero { get; set; }
    private double _peso;
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
    private double _altura;
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
    private short _idade;
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
    public Dictionary<DiaDaSemana, Treino> Treinos { get; private set; }

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

    public abstract void VisualizarTreino();
}
