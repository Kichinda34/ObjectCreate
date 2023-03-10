internal class Program
{
    public class Pessoa
    {
        string? _nome;
        string? _sobrenome;

        public Pessoa() { }

        public void DefinirNome(string nome)
        {
            this._nome = nome;
        }

        public string RetornarNome()
        {
            return this._nome;
        }

        public void DefinirSobreNome(string s)
        {
            this._sobrenome = s;
        }

        public string RetornarSobrenome()
        {
            return this._sobrenome;
        }

        public string RetornarNomeCompleto()
        {
            return RetornarNome() + " " + RetornarSobrenome();
        }
    }
    private static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Informe seu nome: ");
        p.DefinirNome(Console.ReadLine());

        Console.WriteLine("Informe o seu sobrenome: ");
        p.DefinirSobreNome(Console.ReadLine());

        Console.WriteLine("Bem vindo ao inferno, "+ p.RetornarNomeCompleto());
    }
}