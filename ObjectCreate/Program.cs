internal class Program
{
    public class Pessoa
    {
        string nome;

        //public int idade { get; set; }
        //public int altura { get; set; }

        public Pessoa() { }

        public void DefinirNome (string nome) 
        {
            this.nome = nome;
        }

        public string RetornarNome() 
        {
            return this.nome;
        }
    }
    private static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Informe seu nome: ");
        p.DefinirNome(Console.ReadLine());

        Console.WriteLine("Informe seu nome: ");
        p2.DefinirNome(Console.ReadLine());


        Console.WriteLine("Seja bem vindo a orientação a objetivos, " + p.RetornarNome());
        Console.WriteLine("Seja bem vindo a orientação a objetivos, " + p2.RetornarNome());


    }
}