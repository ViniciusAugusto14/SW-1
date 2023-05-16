namespace EXERCICIO_CONTRATO;
class Program
{
    static void Main(string[] args)
    {
        Contrato p1 = new Contrato();
        ContratoPessoaFisica p2 = new ContratoPessoaFisica();
        

        Console.WriteLine("Qual é o seu nome?");
        p1.Nome = Console.ReadLine();
        Console.WriteLine("Qual é seu email?");
        p1.Email = Console.ReadLine();
        Console.WriteLine("Qual é o seu telefone?");
        p1.Telefone = Console.ReadLine();
        Console.WriteLine("Qual é o seu CPF?");
        p2.Cpf = Console.ReadLine();
        Console.WriteLine("Qual é o sua Idade?");
        p2.Idade = int.Parse(Console.ReadLine());
    
        

        p2.MostrarDados();
    }
}
